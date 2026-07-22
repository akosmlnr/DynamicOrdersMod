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
            try
            {
                if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true) return;
                if (__instance == null || orderableQuantity <= 1) return;

                // Host-only: scaling modifies game state, must be authoritative
                if (!DynamicEconomyCore.IsHost()) return;

                var profile = CustomerProfileManager.GetOrCreateProfile(
                    __instance.NPC?.GUID.ToString());
                if (profile == null) return;

                // Cache drug type and base quantity for EvaluateDelivery postfix
                // (which uses them for proper tolerance growth and overdose quantity scaling)
                if (__result != null)
                {
                    try { profile.LastRequestedDrugType = __result.DrugType.ToString(); }
                    catch { }
                }
                int baseQuantity = orderableQuantity;
                profile.LastRequestedQuantity = baseQuantity;

                // Skip scaling for hospitalized or refusing customers
                int currentDay = 0;
                try { currentDay = TimeManager.Instance.ElapsedDays; }
                catch { }
                if (currentDay > 0 && !CustomerProfileManager.IsCustomerAvailable(profile, currentDay))
                    return;

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
                string drugType = profile.LastRequestedDrugType ?? "";
                string region = "";
                try { region = __instance.NPC?.Region.ToString() ?? ""; } catch { }
                float reduction = EventManager.GetOrderReduction(drugType, region);
                scaled = Math.Max(1, (int)(scaled * reduction));

                // Wholesale multiplier: bulk orders from wholesale-eligible customers
                if (CustomerProfileManager.MeetsWholesaleRequirements(profile) &&
                    normalizedRel >= ConfigManager.Config.Wholesale.MinRelationship)
                {
                    scaled = (int)(scaled * ConfigManager.Config.Wholesale.BulkOrderMultiplier);
                    if (!profile.IsWholesale)
                    {
                        profile.IsWholesale = true;
                        profile.WholesaleWeeksActive = 0;
                        try { SaveManager.Save(); }
                        catch { }
                    }
                }

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
            try
            {
                if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true) return;
                if (__instance == null || change <= 0f) return;

                var profile = CustomerProfileManager.GetOrCreateProfile(
                    __instance.NPC?.GUID.ToString());
                if (profile == null) return;

                float modified = CustomerProfileManager.ModifyAddictionDelta(profile, change);
                if (modified != change) change = modified;
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
            try
            {
                if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true) return;
                if (__instance == null) return;

                string guid = __instance.NPC?.GUID.ToString();
                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null) return;

                int currentDay = 0;
                try { currentDay = TimeManager.Instance.ElapsedDays; }
                catch { }
                if (currentDay <= 0) return;

                // EDGE CASE: don't process delivery for hospitalized customers
                // (shouldn't normally happen — game prevents interaction — but guard anyway)
                if (profile.IsHospitalized) return;

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
                    satisfaction *= (1f - penalty);
                    if (satisfaction < 0f) satisfaction = 0f;
                    __result = satisfaction;
                }

                // Record the purchase with real deal data
                float payment = 0f;
                int orderableQuantity = 1;
                try { payment = contract?.Payment ?? 0f; } catch { }
                try { orderableQuantity = contract?.ProductList?.GetTotalQuantity() ?? 1; } catch { }
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
                    shouldRollOverdose = false;

                if (shouldRollOverdose)
                {
                    // quantityFactor: how much was consumed relative to a "normal" single deal
                    float quantityFactor = profile.LastRequestedQuantity > 0
                        ? (float)matchedProductCount / Math.Max(1, profile.LastRequestedQuantity)
                        : 1f;

                    float overdoseChance = EventManager.CalculateOverdoseChance(
                        profile, qualityDifference, highestAddiction,
                        __instance.CurrentAddiction, quantityFactor);
                    if (overdoseChance > 0f && (float)UnityEngine.Random.value < overdoseChance)
                    {
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
            try
            {
                if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true) return;
                if (!ConfigManager.Config.DeadDrop.Enabled) return;
                if (__instance == null || __result == null) return;
                if (!DynamicEconomyCore.IsHost()) return;

                var npc = __instance.NPC;
                if (npc == null) return;

                string guid = npc.GUID.ToString();
                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null) return;

                // EDGE CASE: one active dead drop deal per customer (prevent stacking)
                for (int i = 0; i < SaveManager.Data.ActiveDeadDropDeals.Count; i++)
                {
                    var existing = SaveManager.Data.ActiveDeadDropDeals[i];
                    if (existing.CustomerGuid == guid && !existing.IsResolved) return;
                }

                // Check relationship
                float normalizedRel = 0f;
                try { normalizedRel = npc.RelationData?.NormalizedRelationDelta ?? 0f; }
                catch { }
                if (normalizedRel < ConfigManager.Config.DeadDrop.MinRelationship) return;

                // Check tolerance and deal count thresholds
                if (profile.Tolerance < 0.3f) return;
                if (profile.LifetimeDeals < 5) return;

                // Check cooldown
                int currentDay = 0;
                try { currentDay = TimeManager.Instance.ElapsedDays; }
                catch { }
                if (profile.LastDeadDropFailDay > 0 &&
                    currentDay - profile.LastDeadDropFailDay < ConfigManager.Config.DeadDrop.TheftCooldownDays)
                    return;

                // Customer is eligible — select a dead drop
                string selectedDrop = DeadDropManager.SelectDropForAsync();
                if (selectedDrop == null) return;

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
                    if (ConfigManager.Config.General.DebugLogging)
                        MelonLogger.Warning($"[DynamicOrdersMod] Pricing engine error: {ex.Message}");
                }

                // Round payment to 2 decimals to avoid float precision drift
                basePayment = (float)Math.Round(basePayment, 2);

                // Update the contract so the player sees the right delivery location and payment
                __result.DeliveryLocationGUID = selectedDrop;
                __result.Payment = basePayment;

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