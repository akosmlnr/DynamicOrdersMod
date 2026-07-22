using System;
using System.Collections.Generic;
using HarmonyLib;
using MelonLoader;
using UnityEngine;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
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
    public static class CustomerPatches
    {
        // ============================================================
        // Patch 1: Customer.OfferContract PREFIX
        // Scales order quantity and intercepts for dead drop deals.
        // ============================================================
        [HarmonyPatch(typeof(Customer), "OfferContract")]
        [HarmonyPrefix]
        static void OfferContractPrefix(Customer __instance, ContractInfo info)
        {
            string guid = null;
            try { guid = __instance?.NPC?.GUID.ToString(); }
            catch { }
            string tag = "cust=" + DebugLog.Short(guid);

            try
            {
                if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true)
                {
                    DebugLog.Msg(tag, "skipped: scaling disabled");
                    return;
                }
                if (__instance == null) { DebugLog.Msg(tag, "skipped: instance null"); return; }
                if (info == null) { DebugLog.Msg(tag, "skipped: info null"); return; }
                if (!DynamicEconomyCore.IsHost())
                {
                    DebugLog.Msg(tag, "skipped: not host");
                    return;
                }
                if (__instance.NPC == null) { DebugLog.Msg(tag, "skipped: NPC null"); return; }
                if (info.Products == null) { DebugLog.Msg(tag, "skipped: Products null"); return; }
                if (info.Products.entries == null || info.Products.entries.Count == 0)
                {
                    DebugLog.Msg(tag, "skipped: entries null/empty");
                    return;
                }

                guid = __instance.NPC.GUID.ToString();
                tag = "cust=" + DebugLog.Short(guid);

                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null) { DebugLog.Msg(tag, "skipped: profile null"); return; }

                int baseQuantity = 1;
                try { baseQuantity = info.Products.GetTotalQuantity(); } catch { }
                profile.LastRequestedQuantity = baseQuantity;

                string drugType = "";
                try { drugType = info.Products.entries[0].ProductID ?? ""; } catch { }
                profile.LastRequestedDrugType = drugType;

                int currentDay = 0;
                try { currentDay = TimeManager.Instance.ElapsedDays; } catch { }

                if (currentDay > 0 && !CustomerProfileManager.IsCustomerAvailable(profile, currentDay))
                {
                    string reason = profile.IsHospitalized ? "hospitalized" : "in refusal window";
                    DebugLog.Msg(tag, $"skipped: {reason} (release_day={profile.HospitalReleaseDay})");
                    return;
                }

                float addiction = __instance.CurrentAddiction;
                float normalizedRel = 0f;
                try { normalizedRel = __instance.NPC.RelationData.NormalizedRelationDelta; }
                catch { }

                int seed = ScalingEngine.HashToSeed(guid, currentDay);

                int scaled = ScalingEngine.CalculateScaledQuantity(
                    baseQuantity, addiction, normalizedRel, profile.Tolerance,
                    ConfigManager.Config.Scaling, seed);

                string region = "";
                try { region = __instance.NPC.Region.ToString(); } catch { }
                float reduction = EventManager.GetOrderReduction(drugType ?? "", region);
                int preEventScaled = scaled;
                scaled = Math.Max(1, (int)(scaled * reduction));

                bool wholesaleApplied = false;
                if (CustomerProfileManager.MeetsWholesaleRequirements(profile) &&
                    normalizedRel >= ConfigManager.Config.Wholesale.MinRelationship)
                {
                    scaled = (int)(scaled * ConfigManager.Config.Wholesale.BulkOrderMultiplier);
                    wholesaleApplied = true;
                    if (!profile.IsWholesale)
                    {
                        profile.IsWholesale = true;
                        profile.WholesaleWeeksActive = 0;
                        DebugLog.Msg(tag, "WHOLESALE first-time activation");
                        try { SaveManager.Save(); } catch { }
                    }
                }

                // Mutate the ContractInfo so the game sees the scaled quantities
                if (scaled != baseQuantity)
                {
                    float ratio = (float)scaled / baseQuantity;
                    for (int i = 0; i < info.Products.entries.Count; i++)
                    {
                        try
                        {
                            var entry = info.Products.entries[i];
                            entry.Quantity = Math.Max(1, (int)Math.Round(entry.Quantity * ratio));
                        }
                        catch { }
                    }
                }

                DebugLog.Msg(tag,
                    $"order product={drugType} base_qty={baseQuantity} " +
                    $"addiction={addiction:F2} rel={normalizedRel:F2} tol={profile.Tolerance:F2} " +
                    $"seed={seed} -> pre_event={preEventScaled} " +
                    $"event_reduction={reduction:F2} wholesale={(wholesaleApplied ? "YES" : "NO")} " +
                    $"-> scaled={scaled}");

                // ----- DEAD DROP INTERCEPTION -----
                if (!ConfigManager.Config.DeadDrop.Enabled)
                {
                    DebugLog.Msg(tag, "dead drop skipped: disabled in config");
                    return;
                }

                // One active deal per customer
                for (int i = 0; i < SaveManager.Data.ActiveDeadDropDeals.Count; i++)
                {
                    var existing = SaveManager.Data.ActiveDeadDropDeals[i];
                    if (existing.CustomerGuid == guid && !existing.IsResolved)
                    {
                        DebugLog.Msg(tag, "dead drop skipped: existing unresolved deal");
                        return;
                    }
                }

                if (normalizedRel < ConfigManager.Config.DeadDrop.MinRelationship)
                {
                    DebugLog.Msg(tag,
                        $"dead drop skipped: rel {normalizedRel:F2} < min {ConfigManager.Config.DeadDrop.MinRelationship:F2}");
                    return;
                }
                if (profile.Tolerance < 0.3f)
                {
                    DebugLog.Msg(tag, $"dead drop skipped: tolerance {profile.Tolerance:F2} < 0.3");
                    return;
                }
                if (profile.LifetimeDeals < 5)
                {
                    DebugLog.Msg(tag, $"dead drop skipped: lifetime deals {profile.LifetimeDeals} < 5");
                    return;
                }
                if (profile.LastDeadDropFailDay > 0 &&
                    currentDay - profile.LastDeadDropFailDay < ConfigManager.Config.DeadDrop.TheftCooldownDays)
                {
                    DebugLog.Msg(tag,
                        $"dead drop skipped: cooldown ({currentDay - profile.LastDeadDropFailDay}d since fail, " +
                        $"need {ConfigManager.Config.DeadDrop.TheftCooldownDays}d)");
                    return;
                }

                DebugLog.Msg(tag,
                    $"dead drop ELIGIBLE: rel={normalizedRel:F2} tol={profile.Tolerance:F2} " +
                    $"lifetime={profile.LifetimeDeals} deals");

                string selectedDrop = DeadDropManager.SelectDropForAsync();
                if (string.IsNullOrEmpty(selectedDrop))
                {
                    DebugLog.Msg(tag, "dead drop aborted: no available drop");
                    return;
                }

                var ddConfig = ConfigManager.Config.DeadDrop;

                string expectedProductID = "";
                int expectedQuality = 2;
                int expectedQuantity = 1;
                try
                {
                    var entry = info.Products.entries[0];
                    expectedProductID = entry.ProductID ?? "";
                    expectedQuality = (int)entry.Quality;
                    expectedQuantity = entry.Quantity;
                }
                catch { }

                bool isPrepaid = UnityEngine.Random.value < ddConfig.PrepaidChance;

                float basePayment = info.Payment;
                if (!isPrepaid)
                {
                    float premium = ddConfig.AsyncPremiumMin +
                        (ddConfig.AsyncPremiumMax - ddConfig.AsyncPremiumMin) * UnityEngine.Random.value;
                    basePayment *= (1f + premium);
                }

                try
                {
                    basePayment = PricingEngine.CalculateCustomerPrice(
                        basePayment,
                        addiction,
                        profile.SuccessfulDeals,
                        ConfigManager.Config.Pricing,
                        SaveManager.Data.ActiveEvents,
                        profile.LastRequestedDrugType ?? "",
                        ConfigManager.Config.Events.ShortagePriceIncrease);
                }
                catch (Exception ex)
                {
                    DebugLog.Warn(tag, $"pricing engine error: {ex.Message}");
                }

                basePayment = (float)Math.Round(basePayment, 2);

                // Mutate the ContractInfo to redirect delivery and set payment
                info.DeliveryLocationGUID = selectedDrop;
                info.Payment = basePayment;

                string dealId = $"dd_{guid}_{currentDay}_{UnityEngine.Random.Range(1000, 9999)}";
                var deal = new DeadDropDeal
                {
                    DealId = dealId,
                    CustomerGuid = guid,
                    DropGuid = selectedDrop,
                    ExpectedProductID = expectedProductID,
                    DrugType = profile.LastRequestedDrugType ?? "",
                    ExpectedQuality = expectedQuality,
                    ExpectedQuantity = expectedQuantity > 0 ? expectedQuantity : 1,
                    Payment = basePayment,
                    IsPrepaid = isPrepaid,
                    CreatedDay = currentDay,
                    WindowDay = currentDay + 1,
                    IsResolved = false,
                    Result = "pending"
                };
                SaveManager.Data.ActiveDeadDropDeals.Add(deal);

                profile.ActiveDeadDropGuid = selectedDrop;
                profile.ActiveDeadDropIsPrepaid = isPrepaid;
                profile.ActiveDeadDropPendingCompletion = false;

                if (isPrepaid && basePayment > 0f)
                {
                    try
                    {
                        var moneyManager = MoneyManager.Instance;
                        if (moneyManager != null)
                            moneyManager.ChangeCashBalance(basePayment, true, true);
                    }
                    catch (Exception ex)
                    {
                        MelonLogger.Warning($"[DynamicOrdersMod] Prepaid deposit failed: {ex.Message}");
                    }

                    NotificationHelper.Send("Dead Drop Contract (Prepaid)",
                        $"Customer paid ${basePayment:F2} upfront. Deliver to the dead drop by tomorrow.",
                        8f);
                }
                else
                {
                    NotificationHelper.Send("Dead Drop Contract",
                        $"Customer wants {expectedQuantity}x {expectedProductID} at a dead drop. Payment on delivery: ${basePayment:F2}.",
                        8f);
                }

                if (ddConfig.DiscoveryQuestEnabled && profile.DiscoveredDeadDrops.Count == 0)
                {
                    try
                    {
                        DeadDropManager.TrySpawnDiscoveryQuests(ddConfig.DiscoveryLocationsCount, profile);
                    }
                    catch (Exception ex)
                    {
                        MelonLogger.Warning($"[DynamicOrdersMod] Discovery quest error: {ex.Message}");
                    }
                }

                try { SaveManager.Save(); } catch { }

                DebugLog.Msg(tag,
                    $"dead drop CREATED deal: prepaid={(isPrepaid ? "YES" : "NO")} " +
                    $"payment=${basePayment:F2} product={expectedProductID} " +
                    $"qty={expectedQuantity} quality={expectedQuality} " +
                    $"drop={DebugLog.Short(selectedDrop)} day={currentDay}");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] OfferContractPrefix error: {ex.Message}");
            }
        }

        // ============================================================
        // Patch 2: Customer.ContractAccepted POSTFIX
        // Read-only observation of accepted contracts.
        // ============================================================
        [HarmonyPatch(typeof(Customer), "ContractAccepted")]
        [HarmonyPostfix]
        static void ContractAcceptedPostfix(
            Customer __instance,
            EDealWindow window,
            bool trackContract,
            Dealer dealer,
            ref Contract __result)
        {
            string guid = null;
            try { guid = __instance?.NPC?.GUID.ToString(); }
            catch { }
            string tag = "cust=" + DebugLog.Short(guid);

            try
            {
                if (__result == null)
                {
                    DebugLog.Msg(tag, "no contract returned");
                    return;
                }

                int qty = 0;
                try { qty = __result.ProductList?.GetTotalQuantity() ?? 0; } catch { }
                float payment = 0f;
                try { payment = __result.Payment; } catch { }

                string dealerName = dealer?.name ?? "null";

                DebugLog.Msg(tag,
                    $"contract accepted window={window} track={trackContract} " +
                    $"dealer={dealerName} qty={qty} payment=${payment:F2}");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] ContractAcceptedPostfix error: {ex.Message}");
            }
        }

        // ============================================================
        // Patch 3: Customer.ProcessHandover POSTFIX
        // Records purchases, applies tolerance growth, rolls overdoses.
        // ============================================================
        [HarmonyPatch(typeof(Customer), "ProcessHandover")]
        [HarmonyPostfix]
        static void ProcessHandoverPostfix(
            Customer __instance,
            HandoverScreen.EHandoverOutcome outcome,
            Contract contract,
            List<ItemInstance> items,
            bool handoverByPlayer,
            bool giveBonuses)
        {
            string guid = null;
            try { guid = __instance?.NPC?.GUID.ToString(); }
            catch { }
            string tag = "cust=" + DebugLog.Short(guid);

            try
            {
                if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true)
                {
                    DebugLog.Msg(tag, "handover skipped: scaling disabled");
                    return;
                }
                if (__instance == null) { DebugLog.Msg(tag, "handover skipped: instance null"); return; }
                if (!DynamicEconomyCore.IsHost())
                {
                    DebugLog.Msg(tag, "handover skipped: not host");
                    return;
                }

                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null) { DebugLog.Msg(tag, "handover skipped: profile null"); return; }

                int currentDay = 0;
                try { currentDay = TimeManager.Instance.ElapsedDays; } catch { }
                if (currentDay <= 0)
                {
                    DebugLog.Msg(tag, "handover skipped: currentDay<=0");
                    return;
                }

                if (profile.IsHospitalized)
                {
                    DebugLog.Msg(tag, "handover skipped: hospitalized");
                    return;
                }

                profile.LastKnownAddiction = __instance.CurrentAddiction;
                CustomerProfileManager.ApplyPendingRelationshipHit(profile, __instance.NPC);

                if (outcome != HandoverScreen.EHandoverOutcome.Finalize)
                {
                    DebugLog.Msg(tag, $"handover skipped: outcome={outcome}");
                    return;
                }
                if (items == null || items.Count == 0)
                {
                    DebugLog.Msg(tag, "handover skipped: no items");
                    return;
                }
                if (contract == null)
                {
                    DebugLog.Msg(tag, "handover skipped: no contract");
                    return;
                }

                string expectedProductID = "";
                try { expectedProductID = contract.ProductList?.entries[0].ProductID ?? ""; } catch { }

                int expectedQuality = 2;
                try
                {
                    var qEntry = contract.ProductList?.entries[0];
                    if (qEntry != null) expectedQuality = (int)qEntry.Quality;
                }
                catch { }

                int matchedProductCount = 0;
                if (items != null)
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        var item = items[i];
                        if (item == null) continue;
                        try
                        {
                            var data = item.GetItemData();
                            if (data != null && data.ID == expectedProductID)
                            {
                                matchedProductCount += data.Quantity > 0 ? data.Quantity : 1;
                            }
                        }
                        catch { }
                    }
                }

                float highestAddiction = 0.5f; // proxy — effect addiction not easily extractable here

                float qualityDifference = 0f;
                try
                {
                    if (items != null && items.Count > 0)
                    {
                        var qualityItem = items[0] as QualityItemInstance;
                        if (qualityItem != null)
                        {
                            qualityDifference = (int)qualityItem.Quality - expectedQuality;
                        }
                    }
                }
                catch { }

                float payment = 0f;
                try { payment = contract.Payment; } catch { }
                int orderableQuantity = 1;
                try { orderableQuantity = contract.ProductList?.GetTotalQuantity() ?? 1; } catch { }

                var toleranceConfig = ConfigManager.Config.Tolerance;
                if (toleranceConfig.QualityExpectationShift && profile.Tolerance > 0f && qualityDifference < 0f)
                {
                    float penalty = toleranceConfig.SatisfactionPenaltyScale * profile.Tolerance;
                    DebugLog.Msg(tag,
                        $"tolerance quality shift: qualityDiff={qualityDifference:F2} tol={profile.Tolerance:F2} penalty={penalty:F2}");
                }

                string drugType = profile.LastRequestedDrugType ?? "";

                DebugLog.Msg(tag,
                    $"delivery matched={matchedProductCount}/{orderableQuantity} payment=${payment:F2} " +
                    $"qualityDiff={qualityDifference:F2} highestAddiction={highestAddiction:F2} drug={drugType}");

                profile.RecordPurchase(currentDay, drugType, matchedProductCount, payment);
                profile.RecordSuccess();
                CustomerProfileManager.ApplyToleranceGrowth(
                    profile, matchedProductCount, orderableQuantity, __instance.CurrentAddiction);

                // ----- Overdose roll -----
                bool shouldRoll = matchedProductCount > 0;
                if (shouldRoll && profile.OverdoseGraceUntilDay > 0 && currentDay < profile.OverdoseGraceUntilDay)
                {
                    DebugLog.Msg(tag,
                        $"overdose roll skipped: grace period (until day {profile.OverdoseGraceUntilDay})");
                    shouldRoll = false;
                }
                if (matchedProductCount == 0)
                {
                    DebugLog.Msg(tag, "overdose roll skipped: matchedProductCount=0");
                }

                if (shouldRoll)
                {
                    float quantityFactor = profile.LastRequestedQuantity > 0
                        ? (float)matchedProductCount / Math.Max(1, profile.LastRequestedQuantity)
                        : 1f;

                    float overdoseChance = EventManager.CalculateOverdoseChance(
                        profile, qualityDifference, highestAddiction,
                        __instance.CurrentAddiction, quantityFactor);
                    float roll = UnityEngine.Random.value;

                    if (overdoseChance <= 0f)
                    {
                        DebugLog.Msg(tag, "overdose roll: chance=0 (no potency/addiction)");
                    }
                    else if (roll < overdoseChance)
                    {
                        DebugLog.Msg(tag,
                            $"OVERDOSE ROLL YES: chance={overdoseChance:F4} roll={roll:F4} " +
                            $"(qtyFactor={quantityFactor:F2} potency={highestAddiction:F2} " +
                            $"addiction={__instance.CurrentAddiction:F2})");
                        bool overdosed = EventManager.ResolveOverdose(profile, currentDay);
                        if (overdosed)
                        {
                            var overdoseConfig = ConfigManager.Config.Overdose;
                            if (profile.OverdoseCount >= 2)
                            {
                                try
                                {
                                    __instance.NPC.RelationData.ChangeRelationship(
                                        -overdoseConfig.SecondOverdoseRelationshipHit);
                                }
                                catch { }
                            }
                            try { SaveManager.Save(); } catch { }
                        }
                    }
                    else
                    {
                        DebugLog.Msg(tag,
                            $"overdose roll NO: chance={overdoseChance:F4} roll={roll:F4}");
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] ProcessHandoverPostfix error: {ex.Message}");
            }
        }

        // ============================================================
        // Patch 4: Contract.Complete POSTFIX
        // Read-only confirmation that a contract fully completed.
        // ============================================================
        [HarmonyPatch(typeof(Contract), "Complete")]
        [HarmonyPostfix]
        static void ContractCompletePostfix(Contract __instance, bool network)
        {
            try
            {
                if (__instance == null) return;

                var customer = __instance.Customer?.GetComponent<Customer>();
                if (customer == null) return;

                string guid = null;
                try { guid = customer.NPC?.GUID.ToString(); } catch { }
                string tag = "cust=" + DebugLog.Short(guid);

                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null) { DebugLog.Msg(tag, "Contract.Complete skipped: profile null"); return; }

                float payment = 0f;
                try { payment = __instance.Payment; } catch { }
                int qty = 0;
                try { qty = __instance.ProductList?.GetTotalQuantity() ?? 0; } catch { }

                DebugLog.Msg(tag,
                    $"Contract.Complete payment=${payment:F2} qty={qty} network={network}");
                // No state mutation — ProcessHandover already handled it.
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] ContractCompletePostfix error: {ex.Message}");
            }
        }

        // ============================================================
        // Patch 5: Customer.CurrentContractEnded POSTFIX
        // Resolves (fails) any active dead drop deal when the contract ends badly.
        // ============================================================
        [HarmonyPatch(typeof(Customer), "CurrentContractEnded")]
        [HarmonyPostfix]
        static void CurrentContractEndedPostfix(Customer __instance, EQuestState outcome)
        {
            string guid = null;
            try { guid = __instance?.NPC?.GUID.ToString(); }
            catch { }
            string tag = "cust=" + DebugLog.Short(guid);

            try
            {
                DebugLog.Msg(tag, $"contract ended outcome={outcome}");

                if (outcome != EQuestState.Failed &&
                    outcome != EQuestState.Cancelled &&
                    outcome != EQuestState.Expired)
                {
                    return;
                }

                if (string.IsNullOrEmpty(guid)) return;

                int currentDay = 0;
                try { currentDay = TimeManager.Instance.ElapsedDays; } catch { }

                for (int i = 0; i < SaveManager.Data.ActiveDeadDropDeals.Count; i++)
                {
                    var deal = SaveManager.Data.ActiveDeadDropDeals[i];
                    if (deal.CustomerGuid == guid && !deal.IsResolved)
                    {
                        deal.IsResolved = true;
                        deal.Result = "expired";
                        deal.ResolvedDay = currentDay;

                        var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                        if (profile != null)
                        {
                            profile.LastDeadDropFailDay = currentDay;
                        }

                        try { DeadDropManager.ReleaseDrop(deal.DropGuid); } catch { }
                        try { SaveManager.Save(); } catch { }

                        DebugLog.Msg(tag,
                            $"dead drop expired: deal={deal.DealId} drop={DebugLog.Short(deal.DropGuid)} day={currentDay}");
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] CurrentContractEndedPostfix error: {ex.Message}");
            }
        }

        // ============================================================
        // Patch 6: Customer.RpcLogic___ChangeAddiction_431000436 PREFIX
        // Applies tolerance-based addiction delta modification.
        // ============================================================
        [HarmonyPatch(typeof(Customer), "RpcLogic___ChangeAddiction_431000436")]
        [HarmonyPrefix]
        static void ChangeAddictionRpcLogicPrefix(Customer __instance, ref float change)
        {
            string guid = null;
            try { guid = __instance?.NPC?.GUID.ToString(); }
            catch { }
            string tag = "cust=" + DebugLog.Short(guid);

            try
            {
                if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true)
                {
                    DebugLog.Msg(tag, "ChangeAddiction skipped: scaling disabled");
                    return;
                }
                if (__instance == null) { DebugLog.Msg(tag, "ChangeAddiction skipped: instance null"); return; }
                if (change <= 0f)
                {
                    DebugLog.Msg(tag, $"ChangeAddiction skipped: change<=0 (change={change})");
                    return;
                }

                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null) { DebugLog.Msg(tag, "ChangeAddiction skipped: profile null"); return; }

                float original = change;
                float modified = CustomerProfileManager.ModifyAddictionDelta(profile, change);
                if (modified != change) change = modified;

                float modifier = 1f - profile.Tolerance * 0.5f;
                DebugLog.Msg(tag,
                    $"ChangeAddiction original={original:F4} tolerance_modifier={modifier:F2} " +
                    $"tolerance={profile.Tolerance:F2} -> modified={modified:F4}");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] ChangeAddictionRpcLogicPrefix error: {ex.Message}");
            }
        }
    }
}
