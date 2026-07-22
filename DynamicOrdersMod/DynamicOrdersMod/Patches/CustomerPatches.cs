using System;
using System.Collections.Generic;
using HarmonyLib;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Quests;
using MelonLoader;
using DynamicOrdersMod.Core;
using DynamicOrdersMod.Models;
using DynamicOrdersMod.Persistence;
using DynamicOrdersMod.Systems;
using DynamicOrdersMod.UI;

namespace DynamicOrdersMod.Patches
{
    public static class CustomerPatches
    {
        [HarmonyPatch(typeof(Customer), "GetWeightedRandomProduct")]
        [HarmonyPostfix]
        static void GetWeightedRandomProductPostfix(
            Customer __instance,
            Il2CppScheduleOne.Product.ProductDefinition __result,
            ref float appeal,
            ref int orderableQuantity)
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
                if (__instance == null) return;
                if (orderableQuantity <= 1)
                {
                    DebugLog.Msg(tag, $"skipped: orderableQuantity<=1 (qty={orderableQuantity})");
                    return;
                }

                if (!DynamicEconomyCore.IsHost())
                {
                    DebugLog.Msg(tag, "skipped: not host");
                    return;
                }

                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null)
                {
                    DebugLog.Msg(tag, "skipped: profile null");
                    return;
                }

                // Cache drug type and base quantity for EvaluateDelivery postfix
                // (which uses them for proper tolerance growth and overdose quantity scaling)
                string drugType = "";
                if (__result != null)
                {
                    try { drugType = __result.DrugType.ToString(); profile.LastRequestedDrugType = drugType; }
                    catch { }
                }
                int baseQuantity = orderableQuantity;
                profile.LastRequestedQuantity = baseQuantity;

                // Skip scaling for hospitalized or refusing customers
                int currentDay = 0;
                try { currentDay = TimeManager.Instance.ElapsedDays; }
                catch { }
                if (currentDay > 0 && !CustomerProfileManager.IsCustomerAvailable(profile, currentDay))
                {
                    string reason = profile.IsHospitalized ? "hospitalized" : "in refusal window";
                    DebugLog.Msg(tag, $"skipped: {reason} (release_day={profile.HospitalReleaseDay})");
                    return;
                }

                float addiction = __instance.CurrentAddiction;
                float normalizedRel = 0f;
                try { normalizedRel = __instance.NPC?.RelationData?.NormalizedRelationDelta ?? 0f; }
                catch { }

                // Deterministic seed: same customer + same day = same scaled quantity on all clients
                int seed = ScalingEngine.HashToSeed(__instance.NPC?.GUID.ToString() ?? "", currentDay);

                int scaled = ScalingEngine.CalculateScaledQuantity(
                    orderableQuantity, addiction, normalizedRel, profile.Tolerance,
                    ConfigManager.Config.Scaling, seed);

                // Apply event order reduction (crackdown/shortage) using cached drug type
                string region = "";
                try { region = __instance.NPC?.Region.ToString() ?? ""; } catch { }
                float reduction = EventManager.GetOrderReduction(drugType ?? "", region);
                int preEventScaled = scaled;
                scaled = Math.Max(1, (int)(scaled * reduction));

                // Wholesale multiplier: bulk orders from wholesale-eligible customers
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
                        try { SaveManager.Save(); }
                        catch { }
                    }
                }

                // Full breakdown for debugging scaling math
                DebugLog.Msg(tag,
                    $"order product={drugType} base_qty={orderableQuantity} " +
                    $"addiction={addiction:F2} rel={normalizedRel:F2} tol={profile.Tolerance:F2} " +
                    $"seed={seed} -> pre_event={preEventScaled} " +
                    $"event_reduction={reduction:F2} wholesale={(wholesaleApplied ? "YES" : "NO")} " +
                    $"-> scaled={scaled}");

                if (scaled != orderableQuantity) orderableQuantity = scaled;
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] GetWeightedRandomProduct error: {ex.Message}");
            }
        }

        [HarmonyPatch(typeof(Customer), "ChangeAddiction")]
        [HarmonyPostfix]
        static void ChangeAddictionPostfix(Customer __instance, ref float change)
        {
            string guid = null;
            try { guid = __instance?.NPC?.GUID.ToString(); }
            catch { }
            string tag = "cust=" + DebugLog.Short(guid);

            try
            {
                if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true) return;
                if (__instance == null || change <= 0f)
                {
                    DebugLog.Msg(tag, $"ChangeAddiction skipped: change<=0 (change={change})");
                    return;
                }

                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null) return;

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
                MelonLogger.Error($"[DynamicOrdersMod] ChangeAddiction error: {ex.Message}");
            }
        }

        [HarmonyPatch(typeof(Customer), "EvaluateDelivery")]
        [HarmonyPostfix]
        static void EvaluateDeliveryPostfix(
            Customer __instance,
            Contract contract,
            List<ItemInstance> providedItems,
            ref float highestAddiction,
            ref EDrugType mainTypeType,
            ref int matchedProductCount,
            ref float qualityDifference,
            ref float __result)
        {
            string guid = null;
            try { guid = __instance?.NPC?.GUID.ToString(); }
            catch { }
            string tag = "cust=" + DebugLog.Short(guid);

            try
            {
                if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true) return;
                if (__instance == null) return;

                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null) return;

                int currentDay = 0;
                try { currentDay = TimeManager.Instance.ElapsedDays; }
                catch { }
                if (currentDay <= 0)
                {
                    DebugLog.Msg(tag, "delivery skipped: currentDay<=0");
                    return;
                }

                // EDGE CASE: don't process delivery for hospitalized customers
                // (shouldn't normally happen — game prevents interaction — but guard anyway)
                if (profile.IsHospitalized)
                {
                    DebugLog.Msg(tag, "delivery skipped: hospitalized");
                    return;
                }

                // Cache current addiction for tolerance decay formula (Step 6)
                profile.LastKnownAddiction = __instance.CurrentAddiction;

                // Apply any deferred hospital-release relationship hit now that customer is interacting
                CustomerProfileManager.ApplyPendingRelationshipHit(profile, __instance.NPC);

                float satisfaction = __result;
                string drugType = mainTypeType.ToString();

                // Quality expectation shift: high-tolerance customers are less satisfied
                // with the same quality. Negative qualityDifference = quality below customer expectation.
                var toleranceConfig = ConfigManager.Config.Tolerance;
                if (toleranceConfig.QualityExpectationShift && profile.Tolerance > 0f && qualityDifference < 0f)
                {
                    float penalty = toleranceConfig.SatisfactionPenaltyScale * profile.Tolerance;
                    float preShift = satisfaction;
                    satisfaction *= (1f - penalty);
                    if (satisfaction < 0f) satisfaction = 0f;
                    __result = satisfaction;
                    DebugLog.Msg(tag,
                        $"satisfaction shifted by tolerance: {preShift:F2} -> {satisfaction:F2} (penalty={penalty:F2})");
                }

                // Record the purchase with real deal data
                float payment = 0f;
                int orderableQuantity = 1;
                try { payment = contract?.Payment ?? 0f; } catch { }
                try { orderableQuantity = contract?.ProductList?.GetTotalQuantity() ?? 1; } catch { }

                DebugLog.Msg(tag,
                    $"delivery matched={matchedProductCount}/{orderableQuantity} payment=${payment:F2} " +
                    $"satisfaction={satisfaction:F2} qualityDiff={qualityDifference:F2} " +
                    $"highestAddiction={highestAddiction:F2} drug={drugType}");

                profile.RecordPurchase(currentDay, drugType, matchedProductCount, payment);
                profile.RecordSuccess();

                // Tolerance growth using actual quantity ratio
                CustomerProfileManager.ApplyToleranceGrowth(
                    profile, matchedProductCount, orderableQuantity, __instance.CurrentAddiction);

                // Overdose roll using real quality, potency, and quantity data
                // Skip if nothing was actually consumed (matchedProductCount == 0)
                bool shouldRollOverdose = matchedProductCount > 0;
                // Skip if in grace period after hospital release
                if (shouldRollOverdose && profile.OverdoseGraceUntilDay > 0 && currentDay < profile.OverdoseGraceUntilDay)
                {
                    DebugLog.Msg(tag,
                        $"overdose roll skipped: grace period (until day {profile.OverdoseGraceUntilDay})");
                    shouldRollOverdose = false;
                }
                if (matchedProductCount == 0)
                    DebugLog.Msg(tag, "overdose roll skipped: matchedProductCount=0");

                if (shouldRollOverdose)
                {
                    // quantityFactor: how much was consumed relative to a "normal" single deal
                    float quantityFactor = profile.LastRequestedQuantity > 0
                        ? (float)matchedProductCount / Math.Max(1, profile.LastRequestedQuantity)
                        : 1f;

                    float overdoseChance = EventManager.CalculateOverdoseChance(
                        profile, qualityDifference, highestAddiction,
                        __instance.CurrentAddiction, quantityFactor);
                    float roll = (float)UnityEngine.Random.value;
                    if (overdoseChance <= 0f)
                    {
                        DebugLog.Msg(tag, $"overdose roll: chance=0 (no potency/addiction)");
                    }
                    else if (roll < overdoseChance)
                    {
                        DebugLog.Msg(tag,
                            $"OVERDOSE ROLL: chance={overdoseChance:F4} roll={roll:F4} -> YES " +
                            $"(qtyFactor={quantityFactor:F2} potency={highestAddiction:F2} " +
                            $"addiction={__instance.CurrentAddiction:F2})");
                        bool overdosed = EventManager.ResolveOverdose(profile, currentDay);
                        if (overdosed)
                        {
                            // Apply relationship consequences for 2nd+ overdose
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

                            try { SaveManager.Save(); }
                            catch { }
                        }
                    }
                    else
                    {
                        DebugLog.Msg(tag,
                            $"overdose roll: chance={overdoseChance:F4} roll={roll:F4} -> NO");
                    }
                }

                // Dead drop completion is now handled by DynamicEconomyCore.ResolveDeadDropDeals
                // which reads the dead drop's storage contents at the deal window and pays proportionally.
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] EvaluateDelivery error: {ex.Message}");
            }
        }

        [HarmonyPatch(typeof(Customer), "TryGenerateContract")]
        [HarmonyPostfix]
        static void TryGenerateContractPostfix(Customer __instance, Dealer dealer, ref ContractInfo __result)
        {
            string guid = null;
            try { guid = __instance?.NPC?.GUID.ToString(); }
            catch { }
            string tag = "cust=" + DebugLog.Short(guid);

            try
            {
                if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true) return;
                if (!ConfigManager.Config.DeadDrop.Enabled)
                {
                    DebugLog.Msg(tag, "contract skipped: DeadDrop disabled in config");
                    return;
                }
                if (__instance == null || __result == null) return;
                if (!DynamicEconomyCore.IsHost())
                {
                    DebugLog.Msg(tag, "contract skipped: not host");
                    return;
                }

                var npc = __instance.NPC;
                if (npc == null) return;

                guid = npc.GUID.ToString();
                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null) return;

                // EDGE CASE: one active dead drop deal per customer (prevent stacking)
                for (int i = 0; i < SaveManager.Data.ActiveDeadDropDeals.Count; i++)
                {
                    var existing = SaveManager.Data.ActiveDeadDropDeals[i];
                    if (existing.CustomerGuid == guid && !existing.IsResolved)
                    {
                        DebugLog.Msg(tag, "contract skipped: existing unresolved deal");
                        return;
                    }
                }

                // Check relationship
                float normalizedRel = 0f;
                try { normalizedRel = npc.RelationData?.NormalizedRelationDelta ?? 0f; }
                catch { }
                if (normalizedRel < ConfigManager.Config.DeadDrop.MinRelationship)
                {
                    DebugLog.Msg(tag,
                        $"contract skipped: rel {normalizedRel:F2} < min {ConfigManager.Config.DeadDrop.MinRelationship:F2}");
                    return;
                }

                // Check tolerance and deal count thresholds
                if (profile.Tolerance < 0.3f)
                {
                    DebugLog.Msg(tag, $"contract skipped: tolerance {profile.Tolerance:F2} < 0.3");
                    return;
                }
                if (profile.LifetimeDeals < 5)
                {
                    DebugLog.Msg(tag, $"contract skipped: lifetime deals {profile.LifetimeDeals} < 5");
                    return;
                }

                // Check cooldown
                int currentDay = 0;
                try { currentDay = TimeManager.Instance.ElapsedDays; }
                catch { }
                if (profile.LastDeadDropFailDay > 0 &&
                    currentDay - profile.LastDeadDropFailDay < ConfigManager.Config.DeadDrop.TheftCooldownDays)
                {
                    DebugLog.Msg(tag,
                        $"contract skipped: cooldown ({currentDay - profile.LastDeadDropFailDay}d since fail, " +
                        $"need {ConfigManager.Config.DeadDrop.TheftCooldownDays}d)");
                    return;
                }

                DebugLog.Msg(tag,
                    $"contract ELIGIBLE: rel={normalizedRel:F2} tol={profile.Tolerance:F2} " +
                    $"lifetime={profile.LifetimeDeals} deals");

                // Customer is eligible — select a dead drop
                string selectedDrop = DeadDropManager.SelectDropForAsync();
                if (selectedDrop == null)
                {
                    DebugLog.Msg(tag, "contract aborted: no available drop");
                    return;
                }

                var ddConfig = ConfigManager.Config.DeadDrop;

                // Extract expected product details from the contract for later storage verification
                string expectedProductID = "";
                int expectedQuality = 2; // EQuality.Standard default
                int expectedQuantity = 1;
                try
                {
                    if (__result.Products?.entries != null && __result.Products.entries.Count > 0)
                    {
                        var entry = __result.Products.entries[0];
                        expectedProductID = entry.ProductID ?? "";
                        expectedQuality = (int)entry.Quality;
                        expectedQuantity = entry.Quantity;
                    }
                }
                catch { }

                // Decide prepaid vs async
                bool isPrepaid = (float)UnityEngine.Random.value < ddConfig.PrepaidChance;

                // Base payment from contract
                float basePayment = __result.Payment;

                // Apply async price premium (customer pays more for the convenience/risk)
                if (!isPrepaid)
                {
                    float premium = ddConfig.AsyncPremiumMin +
                        (ddConfig.AsyncPremiumMax - ddConfig.AsyncPremiumMin) * (float)UnityEngine.Random.value;
                    basePayment *= (1f + premium);
                }

                // Wire PricingEngine: loyalty discount, addiction premium, market fluctuation, events
                try
                {
                    basePayment = PricingEngine.CalculateCustomerPrice(
                        basePayment,
                        __instance.CurrentAddiction,
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

                // Round payment to 2 decimals to avoid float precision drift
                basePayment = (float)Math.Round(basePayment, 2);

                // Update the contract so the player sees the right delivery location and payment
                __result.DeliveryLocationGUID = selectedDrop;
                __result.Payment = basePayment;

                DebugLog.Msg(tag,
                    $"contract CREATED deal: prepaid={(isPrepaid ? "YES" : "NO")} " +
                    $"payment=${basePayment:F2} product={expectedProductID} " +
                    $"qty={expectedQuantity} quality={expectedQuality} " +
                    $"drop={DebugLog.Short(selectedDrop)} day={currentDay}");

                // Create the DeadDropDeal record for tracking and resolution
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
                    WindowDay = currentDay + 1, // deliver by next day
                    IsResolved = false,
                    Result = "pending"
                };
                SaveManager.Data.ActiveDeadDropDeals.Add(deal);

                // Store assignment on profile (backward compat with existing fields)
                profile.ActiveDeadDropGuid = selectedDrop;
                profile.ActiveDeadDropIsPrepaid = isPrepaid;
                profile.ActiveDeadDropPendingCompletion = false; // resolved via DeadDropDeal now

                // Prepaid: customer pays full amount upfront.
                // The tradeoff: player gets guaranteed money, but skipping delivery
                // incurs relationship/cooldown penalties (handled at resolution).
                if (isPrepaid && basePayment > 0f)
                {
                    try
                    {
                        var moneyManager = Il2CppScheduleOne.Money.MoneyManager.Instance;
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

                // Discovery quests on first dead drop eligibility
                if (ddConfig.DiscoveryQuestEnabled && profile.DiscoveredDeadDrops.Count == 0)
                {
                    try
                    {
                        DeadDropManager.TrySpawnDiscoveryQuests(
                            ddConfig.DiscoveryLocationsCount, profile);
                    }
                    catch (Exception ex)
                    {
                        MelonLogger.Warning($"[DynamicOrdersMod] Discovery quest error: {ex.Message}");
                    }
                }

                try { SaveManager.Save(); }
                catch { }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] TryGenerateContract error: {ex.Message}");
            }
        }
    }
}