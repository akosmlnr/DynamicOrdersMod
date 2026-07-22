using System;
using System.Collections.Generic;
using HarmonyLib;
using MelonLoader;
using UnityEngine;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.UI.Handover;
using DynamicOrdersMod.Core;
using DynamicOrdersMod.Models;
using DynamicOrdersMod.Persistence;
using DynamicOrdersMod.Systems;
using DynamicOrdersMod.UI;

namespace DynamicOrdersMod.Patches
{
    // ============================================================
    // PATCH 1: Customer.OfferContract PREFIX
    // Scaling + dead drop interception. Mutates ContractInfo
    // BEFORE contract creation so changes propagate via the game's
    // existing network sync.
    // ============================================================
    [HarmonyPatch(typeof(Il2CppScheduleOne.Economy.Customer), "OfferContract")]
    public static class OfferContractPatch
    {
        public static void Prefix(Customer __instance, ContractInfo info)
        {
            string guid = null;
            try
            {
                // --- 1. Identity ---
                try { guid = __instance?.NPC?.GUID.ToString(); } catch { }
                string tag = "cust=" + DebugLog.Short(guid);

                // --- 2. Guards ---
                if (DynamicEconomyCore.Instance == null || !DynamicEconomyCore.Instance.ScalingEnabled)
                {
                    DebugLog.Msg(tag, "OfferContract skip: scaling disabled");
                    return;
                }
                if (__instance == null || info == null)
                {
                    DebugLog.Msg(tag, "OfferContract skip: instance/info null");
                    return;
                }
                if (!DynamicEconomyCore.IsHost())
                {
                    DebugLog.Msg(tag, "OfferContract skip: not host");
                    return;
                }
                if (__instance.NPC == null)
                {
                    DebugLog.Warn(tag, "OfferContract skip: NPC null");
                    return;
                }
                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null)
                {
                    DebugLog.Warn(tag, "OfferContract skip: profile null");
                    return;
                }

                // --- 3. Cache base quantity + drug type ---
                int baseQuantity = 1;
                string drugType = "";
                var entries = info.Products?.entries;
                if (entries != null && entries.Count > 0)
                {
                    try
                    {
                        baseQuantity = info.Products.GetTotalQuantity();
                        if (baseQuantity <= 0) baseQuantity = 1;
                        drugType = entries[0].ProductID ?? "";
                    }
                    catch (Exception ex)
                    {
                        DebugLog.Warn(tag, $"OfferContract products cache failed: {ex.Message}");
                    }
                }

                // --- 4. Record last requested ---
                profile.LastRequestedDrugType = drugType;
                profile.LastRequestedQuantity = baseQuantity;

                // --- 5. Current day ---
                int currentDay = 0;
                try { currentDay = TimeManager.Instance.ElapsedDays; } catch { }

                // --- 5b. Anti-double-scale guard ---
                // OfferContract can fire multiple times for the same contract (build pass + finalize pass).
                // Without this guard, the second pass sees the already-scaled baseQuantity and scales AGAIN,
                // causing exponential growth. Skip if we already scaled for this customer today AND the
                // incoming baseQuantity matches what we previously scaled FROM (meaning it's a re-fire).
                // A FRESH contract offer will have a different baseQuantity than our last scaled value.
                if (currentDay == profile.LastScaledDay && profile.LastScaledBaseQty == baseQuantity)
                {
                    DebugLog.Msg(tag, $"OfferContract skip: already scaled today (day={currentDay}, base_qty={baseQuantity})");
                    return;
                }

                // --- 6. Availability (hospitalized / refusal) ---
                if (currentDay > 0 && !CustomerProfileManager.IsCustomerAvailable(profile, currentDay))
                {
                    string reason = profile.IsHospitalized ? "hospitalized" : "in refusal window";
                    DebugLog.Msg(tag, $"OfferContract skip: {reason} (release_day={profile.HospitalReleaseDay})");
                    return;
                }

                // --- 7. Live addiction + relationship ---
                float addiction = 0f;
                try { addiction = __instance.CurrentAddiction; } catch { }
                var npc = __instance.NPC;
                float normalizedRel = 0f;
                try { normalizedRel = npc.RelationData.NormalizedRelationDelta; } catch { }

                // --- 8. Cache addiction ---
                profile.LastKnownAddiction = addiction;

                // --- 9. Seeded scaled quantity ---
                int seed = ScalingEngine.HashToSeed(guid, currentDay);
                int scaled = ScalingEngine.CalculateScaledQuantity(
                    baseQuantity, addiction, normalizedRel, profile.Tolerance,
                    ConfigManager.Config.Scaling, seed);

                // --- 10. Region + event reduction ---
                string region = "";
                try { region = npc.Region.ToString(); } catch { }
                float reduction = EventManager.GetOrderReduction(drugType, region);

                // --- 11. Apply event reduction ---
                int preEventScaled = scaled;
                scaled = Math.Max(1, (int)(scaled * reduction));

                // --- 12. Wholesale multiplier ---
                if (CustomerProfileManager.MeetsWholesaleRequirements(profile) &&
                    normalizedRel >= ConfigManager.Config.Wholesale.MinRelationship)
                {
                    scaled = (int)(scaled * ConfigManager.Config.Wholesale.BulkOrderMultiplier);
                    if (!profile.IsWholesale)
                    {
                        profile.IsWholesale = true;
                        DebugLog.Msg(tag, "WHOLESALE first-time activation");
                    }
                }

                // --- 13. MUTATE product entries proportionally ---
                float ratio = baseQuantity > 0 ? (float)scaled / baseQuantity : 1f;
                if (Math.Abs(ratio - 1f) > 1e-5 && entries != null)
                {
                    for (int i = 0; i < entries.Count; i++)
                    {
                        var entry = entries[i];
                        if (entry == null) continue;
                        int orig = entry.Quantity;
                        entry.Quantity = Math.Max(1, (int)Math.Round(orig * ratio));
                    }
                }

                // --- 14. MUTATE payment (scale by ratio) ---
                info.Payment = (float)Math.Round(info.Payment * ratio, 2);

                // --- 15. Run pricing engine ---
                float basePay = info.Payment;
                float finalPrice = basePay;
                try
                {
                    finalPrice = PricingEngine.CalculateCustomerPrice(
                        basePay,
                        addiction,
                        profile.SuccessfulDeals,
                        ConfigManager.Config.Pricing,
                        SaveManager.Data.ActiveEvents,
                        drugType,
                        ConfigManager.Config.Events.ShortagePriceIncrease);
                    finalPrice = (float)Math.Round(finalPrice, 2);
                    info.Payment = finalPrice;
                }
                catch (Exception ex)
                {
                    DebugLog.Warn(tag, $"pricing engine failed (using base*ratio): {ex.Message}");
                }

                // --- 16. Breakdown log ---
                DebugLog.Msg(tag,
                    $"OfferContract product={drugType} base_qty={baseQuantity} " +
                    $"addiction={addiction:F2} rel={normalizedRel:F2} tol={profile.Tolerance:F2} " +
                    $"seed={seed} pre_event={preEventScaled} event_reduction={reduction:F2} " +
                    $"-> scaled={scaled} payment=${finalPrice:F2} (basePay=${basePay:F2})");

                // --- 16b. Record that we scaled (anti-double-scale guard) ---
                profile.LastScaledDay = currentDay;
                profile.LastScaledBaseQty = baseQuantity;

                // --- 17. Dead drop interception ---
                try
                {
                    TryDeadDropInterception(__instance, info, profile, guid, currentDay, normalizedRel, drugType);
                }
                catch (Exception ex)
                {
                    DebugLog.Warn(tag, $"dead drop interception failed: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] OfferContractPatch error: {ex.Message}");
            }
        }

        // ------------------------------------------------------------
        // Dead drop interception. May mutate info.DeliveryLocationGUID
        // and info.Payment, and creates a new DeadDropDeal record.
        // ------------------------------------------------------------
        private static void TryDeadDropInterception(
            Customer __instance,
            ContractInfo info,
            CustomerProfile profile,
            string guid,
            int currentDay,
            float normalizedRel,
            string drugType)
        {
            string tag = "cust=" + DebugLog.Short(guid);

            var ddConfig = ConfigManager.Config.DeadDrop;

            // --- Skip: disabled ---
            if (!ddConfig.Enabled)
            {
                DebugLog.Msg(tag, "deaddrop skip: disabled");
                return;
            }

            // --- Skip: not wholesale-tier ---
            if (!CustomerProfileManager.MeetsWholesaleRequirements(profile))
            {
                DebugLog.Msg(tag, "deaddrop skip: not wholesale-tier");
                return;
            }

            // --- Skip: relationship too low ---
            if (normalizedRel < ConfigManager.Config.Wholesale.MinRelationship)
            {
                DebugLog.Msg(tag, $"deaddrop skip: rel {normalizedRel:F2} < min {ConfigManager.Config.Wholesale.MinRelationship:F2}");
                return;
            }

            // --- Skip: no discovered drops ---
            bool hasDiscovered = false;
            try
            {
                var states = SaveManager.Data.DeadDropStates;
                if (states != null)
                {
                    foreach (var kvp in states)
                    {
                        if (kvp.Value != null && kvp.Value.IsDiscovered)
                        {
                            hasDiscovered = true;
                            break;
                        }
                    }
                }
            }
            catch { }
            if (!hasDiscovered)
            {
                DebugLog.Msg(tag, "deaddrop skip: no discovered drops");
                return;
            }

            // --- Skip: existing unresolved deal for this customer ---
            var activeDeals = SaveManager.Data.ActiveDeadDropDeals;
            if (activeDeals != null)
            {
                for (int i = 0; i < activeDeals.Count; i++)
                {
                    var d = activeDeals[i];
                    if (d != null && !d.IsResolved && d.CustomerGuid == profile.CustomerGuid)
                    {
                        DebugLog.Msg(tag, $"deaddrop skip: existing deal {d.DealId} pending");
                        return;
                    }
                }
            }

            // --- Skip: cooldown active ---
            if (profile.LastDeadDropFailDay > 0 &&
                currentDay - profile.LastDeadDropFailDay < ddConfig.TheftCooldownDays)
            {
                DebugLog.Msg(tag, $"deaddrop skip: cooldown ({currentDay - profile.LastDeadDropFailDay}/{ddConfig.TheftCooldownDays}d)");
                return;
            }

            // --- 30% chance to redirect ---
            if (UnityEngine.Random.value > 0.30f)
            {
                DebugLog.Msg(tag, "deaddrop skip: 30% roll missed");
                return;
            }

            // --- Select drop ---
            string selectedDrop = DeadDropManager.SelectDropForAsync();
            if (string.IsNullOrEmpty(selectedDrop))
            {
                DebugLog.Warn(tag, "deaddrop skip: SelectDropForAsync returned null");
                return;
            }

            // --- Extract expected product/quality/quantity from entries[0] ---
            string expectedProductID = drugType ?? "";
            int expectedQuality = 0;
            int expectedQuantity = 1;
            try
            {
                var entries = info.Products?.entries;
                if (entries != null && entries.Count > 0)
                {
                    var e0 = entries[0];
                    if (e0 != null)
                    {
                        expectedProductID = e0.ProductID ?? expectedProductID;
                        expectedQuality = (int)e0.Quality;
                    }
                    expectedQuantity = info.Products.GetTotalQuantity();
                    if (expectedQuantity <= 0) expectedQuantity = 1;
                }
            }
            catch { }

            // --- Prepaid roll ---
            bool isPrepaid = UnityEngine.Random.value < ddConfig.PrepaidChance;

            // --- Payment: capture base, apply premium if async ---
            float basePayment = info.Payment;
            if (!isPrepaid)
            {
                float premium = ddConfig.AsyncPremiumMin +
                    (ddConfig.AsyncPremiumMax - ddConfig.AsyncPremiumMin) * UnityEngine.Random.value;
                info.Payment = (float)Math.Round(basePayment * (1f + premium), 2);
                DebugLog.Msg(tag, $"deaddrop async premium: +{premium * 100f:F1}% -> ${info.Payment:F2}");
            }

            // --- MUTATE delivery location ---
            info.DeliveryLocationGUID = selectedDrop;

            // --- Create deal record ---
            var deal = new DeadDropDeal
            {
                DealId = $"dd_{guid}_{currentDay}_{UnityEngine.Random.Range(1000, 9999)}",
                CustomerGuid = profile.CustomerGuid,
                DropGuid = selectedDrop,
                ExpectedProductID = expectedProductID,
                DrugType = drugType,
                ExpectedQuality = expectedQuality,
                ExpectedQuantity = expectedQuantity,
                Payment = info.Payment,
                IsPrepaid = isPrepaid,
                CreatedDay = currentDay,
                WindowDay = currentDay + 1,
                IsResolved = false,
                Result = "pending"
            };
            if (activeDeals != null) activeDeals.Add(deal);

            // --- Update profile ---
            profile.ActiveDeadDropGuid = selectedDrop;
            profile.ActiveDeadDropIsPrepaid = isPrepaid;
            profile.ActiveDeadDropPendingCompletion = false;

            // --- Prepaid: deposit cash + notify ---
            if (isPrepaid)
            {
                try
                {
                    var mm = MoneyManager.Instance;
                    if (mm != null)
                        mm.ChangeCashBalance(basePayment, true, true);
                }
                catch (Exception ex)
                {
                    DebugLog.Warn(tag, $"prepaid deposit failed: {ex.Message}");
                }
                NotificationHelper.Send("Dead Drop Order (Prepaid)",
                    $"Wholesale customer paid ${basePayment:F2} upfront. Deliver to the dead drop.",
                    10f);
                DebugLog.Msg(tag,
                    $"DEAD DROP PREPAID deal={deal.DealId} drop={DebugLog.Short(selectedDrop)} " +
                    $"${basePayment:F2} qty={expectedQuantity} product={expectedProductID}");
            }
            else
            {
                NotificationHelper.Send("Dead Drop Order (Async)",
                    $"Wholesale customer wants ${info.Payment:F2} of product delivered to a dead drop.",
                    10f);
                DebugLog.Msg(tag,
                    $"DEAD DROP ASYNC deal={deal.DealId} drop={DebugLog.Short(selectedDrop)} " +
                    $"${info.Payment:F2} qty={expectedQuantity} product={expectedProductID}");
            }

            // --- Persist ---
            try { SaveManager.Save(); } catch { }
        }
    }

    // ============================================================
    // PATCH 2: Customer.ProcessHandover POSTFIX
    // Tolerance growth + overdose roll using REAL delivered item data.
    // ============================================================
    [HarmonyPatch(typeof(Customer), "ProcessHandover")]
    public static class ProcessHandoverPatch
    {
        public static void Postfix(
            Customer __instance,
            HandoverScreen.EHandoverOutcome outcome,
            Contract contract,
            List<ItemInstance> items,
            bool handoverByPlayer,
            bool giveBonuses)
        {
            try
            {
                // --- 1. Identity ---
                string guid = null;
                try { guid = __instance?.NPC?.GUID.ToString(); } catch { }
                string tag = "cust=" + DebugLog.Short(guid);

                // --- 2. Guards ---
                if (DynamicEconomyCore.Instance == null || !DynamicEconomyCore.Instance.ScalingEnabled)
                {
                    DebugLog.Msg(tag, "ProcessHandover skip: scaling disabled");
                    return;
                }
                if (__instance == null)
                {
                    DebugLog.Msg(tag, "ProcessHandover skip: instance null");
                    return;
                }
                if (outcome != HandoverScreen.EHandoverOutcome.Finalize)
                {
                    DebugLog.Msg(tag, $"ProcessHandover skip: outcome={outcome} (not Finalize)");
                    return;
                }
                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null)
                {
                    DebugLog.Warn(tag, "ProcessHandover skip: profile null");
                    return;
                }
                int currentDay = 0;
                try { currentDay = TimeManager.Instance.ElapsedDays; } catch { }
                if (profile.IsHospitalized)
                {
                    DebugLog.Msg(tag, "ProcessHandover skip: hospitalized");
                    return;
                }

                // --- 3. Cache addiction ---
                try { profile.LastKnownAddiction = __instance.CurrentAddiction; } catch { }

                // --- 4. Flush pending relationship hit ---
                try { CustomerProfileManager.ApplyPendingRelationshipHit(profile, __instance.NPC); }
                catch (Exception ex) { DebugLog.Warn(tag, $"pending rel hit failed: {ex.Message}"); }

                if (contract == null || items == null)
                {
                    DebugLog.Msg(tag, "ProcessHandover skip: null contract or items");
                    return;
                }

                // --- 5. Expected product + quality from contract ---
                string expectedProductID = "";
                int expectedQuality = 0;
                try
                {
                    var plEntries = contract.ProductList?.entries;
                    if (plEntries != null && plEntries.Count > 0)
                    {
                        var e0 = plEntries[0];
                        if (e0 != null)
                        {
                            expectedProductID = e0.ProductID ?? "";
                            expectedQuality = (int)e0.Quality;
                        }
                    }
                }
                catch (Exception ex)
                {
                    DebugLog.Warn(tag, $"expected product read failed: {ex.Message}");
                }

                // --- 6. Iterate items: matched count + potency ---
                // Snapshot count first — Il2Cpp list may be modified by the game's
                // consumption logic that runs during/after ProcessHandover.
                int matchedProductCount = 0;
                float highestAddiction = 0f;
                int itemCount = 0;
                try { itemCount = items.Count; } catch { }
                for (int i = 0; i < itemCount; i++)
                {
                    ItemInstance item = null;
                    try { item = items[i]; } catch { break; } // list modified, stop iterating
                    if (item == null) continue;

                    string productID = "";
                    int itemQty = 0;
                    try
                    {
                        var data = item.GetItemData();
                        if (data != null)
                        {
                            productID = data.ID ?? "";
                            itemQty = data.Quantity;
                        }
                    }
                    catch { }

                    if (productID == expectedProductID)
                    {
                        if (itemQty <= 0) itemQty = 1;
                        matchedProductCount += itemQty;
                    }

                    try
                    {
                        var prodItem = item as ProductItemInstance;
                        if (prodItem != null)
                        {
                            float amt = prodItem.Amount;
                            if (amt > highestAddiction) highestAddiction = amt;
                        }
                    }
                    catch { }
                }

                // --- 7. Hybrid potency fallback ---
                float potency = highestAddiction;
                if (potency <= 0f)
                {
                    try { potency = __instance.CurrentAddiction; } catch { }
                }

                // --- 8. Quality difference ---
                int qualityDifference = 0;
                for (int i = 0; i < itemCount; i++)
                {
                    ItemInstance qItem = null;
                    try { qItem = items[i]; } catch { break; }
                    if (qItem == null) continue;
                    try
                    {
                        var qi = qItem as QualityItemInstance;
                        if (qi != null)
                        {
                            int diff = (int)qi.Quality - expectedQuality;
                            if (diff > qualityDifference) qualityDifference = diff;
                        }
                    }
                    catch { }
                }

                // --- 9. Payment + orderable quantity ---
                float payment = 0f;
                try { payment = contract.Payment; } catch { }
                int orderableQuantity = 0;
                try { orderableQuantity = contract.ProductList?.GetTotalQuantity() ?? 0; } catch { }
                if (orderableQuantity <= 0) orderableQuantity = profile.LastRequestedQuantity;
                if (orderableQuantity <= 0) orderableQuantity = 1;

                // --- 10. DebugLog ---
                DebugLog.Msg(tag,
                    $"ProcessHandover matched={matchedProductCount}/{orderableQuantity} " +
                    $"payment=${payment:F2} qualityDiff={qualityDifference} potency={potency:F2}");

                // --- 11. Record purchase ---
                profile.RecordPurchase(
                    currentDay,
                    profile.LastRequestedDrugType ?? "",
                    matchedProductCount > 0 ? matchedProductCount : 1,
                    payment);

                // --- 12. Record success ---
                profile.RecordSuccess();

                // --- 13. Tolerance growth ---
                CustomerProfileManager.ApplyToleranceGrowth(
                    profile, matchedProductCount, orderableQuantity, __instance.CurrentAddiction);

                // --- 14. Overdose roll ---
                try
                {
                    bool shouldRoll = matchedProductCount > 0;
                    if (shouldRoll && profile.OverdoseGraceUntilDay > 0 && currentDay < profile.OverdoseGraceUntilDay)
                    {
                        DebugLog.Msg(tag, $"overdose skip: grace until day {profile.OverdoseGraceUntilDay}");
                        shouldRoll = false;
                    }
                    if (shouldRoll)
                    {
                        float quantityFactor = orderableQuantity > 0
                            ? (float)matchedProductCount / orderableQuantity
                            : 1f;
                        float liveAddiction = 0f;
                        try { liveAddiction = __instance.CurrentAddiction; } catch { }

                        float chance = EventManager.CalculateOverdoseChance(
                            profile,
                            (float)qualityDifference,
                            highestAddiction,
                            liveAddiction,
                            quantityFactor);

                        float roll = UnityEngine.Random.value;

                        if (chance <= 0f)
                        {
                            DebugLog.Msg(tag, $"overdose skip: chance={chance:F4} (zero)");
                        }
                        else if (roll < chance)
                        {
                            DebugLog.Msg(tag,
                                $"OVERDOSE YES: chance={chance:F4} roll={roll:F4} " +
                                $"(qtyFactor={quantityFactor:F2} potency={highestAddiction:F2} " +
                                $"qualityDiff={qualityDifference})");
                            bool overdosed = EventManager.ResolveOverdose(profile, currentDay);
                            if (overdosed && profile.OverdoseCount >= 2)
                            {
                                try
                                {
                                    __instance.NPC?.RelationData?.ChangeRelationship(
                                        -ConfigManager.Config.Overdose.SecondOverdoseRelationshipHit);
                                }
                                catch (Exception ex)
                                {
                                    DebugLog.Warn(tag, $"2nd+ overdose rel hit failed: {ex.Message}");
                                }
                            }
                            try { SaveManager.Save(); } catch { }
                        }
                        else
                        {
                            DebugLog.Msg(tag, $"overdose NO: chance={chance:F4} roll={roll:F4}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    DebugLog.Warn(tag, $"overdose roll error: {ex.Message}");
                }

                try { SaveManager.Save(); } catch { }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] ProcessHandoverPatch error: {ex.Message}");
            }
        }
    }

    // ============================================================
    // PATCH 3: Contract.Complete POSTFIX
    // Observability: log contract completion with final terms.
    // ============================================================
    [HarmonyPatch(typeof(Contract), "Complete")]
    public static class ContractCompletePatch
    {
        // Deduplicate: Contract.Complete fires 2-4 times per contract (network true/false,
        // and possibly on both base Quest.Complete + Contract.Complete override).
        // Track the last logged contract instance to avoid duplicate log spam.
        private static WeakReference<Contract> _lastLogged = new WeakReference<Contract>(null);

        public static void Postfix(Contract __instance, bool network)
        {
            try
            {
                // --- 1. Guards ---
                if (DynamicEconomyCore.Instance == null || !DynamicEconomyCore.Instance.ScalingEnabled) return;
                if (__instance == null) return;

                // --- 1b. Deduplicate — skip if we already logged this exact contract instance ---
                Contract alreadyLogged;
                if (_lastLogged.TryGetTarget(out alreadyLogged) && ReferenceEquals(alreadyLogged, __instance))
                    return;
                _lastLogged.SetTarget(__instance);

                // --- 2. Resolve customer (NetworkObject -> Customer) ---
                Customer customer = null;
                try
                {
                    var netObj = __instance.Customer;
                    if (netObj != null)
                        customer = netObj.GetComponent<Customer>();
                }
                catch (Exception ex)
                {
                    DebugLog.Warn("cust=?", $"Contract.Complete customer resolve failed: {ex.Message}");
                }

                // --- 3. Null check ---
                if (customer == null) return;

                // --- 4. Identity ---
                string guid = null;
                try { guid = customer.NPC?.GUID.ToString(); } catch { }
                string tag = "cust=" + DebugLog.Short(guid);

                // --- 5. Payment + quantity ---
                float payment = 0f;
                int qty = 0;
                try { payment = __instance.Payment; } catch { }
                try { qty = __instance.ProductList?.GetTotalQuantity() ?? 0; } catch { }

                // --- 6. Log ---
                DebugLog.Msg(tag,
                    $"Contract.Complete payment=${payment:F2} qty={qty} network={network}");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] ContractCompletePatch error: {ex.Message}");
            }
        }
    }

    // ============================================================
    // PATCH 4: Customer.RpcLogic___ChangeAddiction_431000436 PREFIX
    // Tolerance-modified addiction delta via ref parameter.
    // ============================================================
    [HarmonyPatch(typeof(Customer), "RpcLogic___ChangeAddiction_431000436")]
    public static class ChangeAddictionPatch
    {
        public static void Prefix(Customer __instance, ref float change)
        {
            try
            {
                // --- 1. Identity ---
                string guid = null;
                try { guid = __instance?.NPC?.GUID.ToString(); } catch { }
                string tag = "cust=" + DebugLog.Short(guid);

                // --- 2. Guards ---
                if (DynamicEconomyCore.Instance == null || !DynamicEconomyCore.Instance.ScalingEnabled)
                {
                    return;
                }
                if (__instance == null) return;
                if (change <= 0f)
                {
                    DebugLog.Msg(tag, $"ChangeAddiction skip: change={change:F4} (<=0)");
                    return;
                }

                // --- 3. Profile ---
                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null)
                {
                    DebugLog.Warn(tag, "ChangeAddiction skip: profile null");
                    return;
                }

                // --- 4-6. Modify delta ---
                float original = change;
                float modified = CustomerProfileManager.ModifyAddictionDelta(profile, change);
                if (Math.Abs(modified - change) > 1e-6f)
                {
                    change = modified;
                }

                // --- 7. Tolerance modifier (for logging) ---
                float modifier = 1f - profile.Tolerance * 0.5f;

                // --- 8. Breakdown log ---
                DebugLog.Msg(tag,
                    $"ChangeAddiction original={original:F4} modified={change:F4} " +
                    $"modifier={modifier:F3} tolerance={profile.Tolerance:F3}");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] ChangeAddictionPatch error: {ex.Message}");
            }
        }
    }
}
