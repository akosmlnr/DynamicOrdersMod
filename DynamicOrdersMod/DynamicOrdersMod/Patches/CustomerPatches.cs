using System;
using System.Collections.Generic;
using HarmonyLib;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Quests;
using MelonLoader;
using DynamicOrdersMod.Core;
using DynamicOrdersMod.Persistence;
using DynamicOrdersMod.Systems;

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

                int scaled = ScalingEngine.CalculateScaledQuantity(
                    orderableQuantity, addiction, normalizedRel, profile.Tolerance,
                    ConfigManager.Config.Scaling);

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
        static void ChangeAddictionPostfix(Customer __instance, ref float amount)
        {
            try
            {
                if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true) return;
                if (__instance == null || amount <= 0f) return;

                var profile = CustomerProfileManager.GetOrCreateProfile(
                    __instance.NPC?.GUID.ToString());
                if (profile == null) return;

                float modified = CustomerProfileManager.ModifyAddictionDelta(profile, amount);
                if (modified != amount) amount = modified;
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

                // Task 3 continuation: Handle dead drop completion relationship bonus
                if (profile.ActiveDeadDropPendingCompletion)
                {
                    profile.ActiveDeadDropPendingCompletion = false;
                    var ddConfig = ConfigManager.Config.DeadDrop;
                    if (ddConfig.SuccessRelationshipBonus > 0f)
                    {
                        try
                        {
                            __instance.NPC.RelationData.ChangeRelationship(ddConfig.SuccessRelationshipBonus);
                        }
                        catch { }
                    }
                    SaveManager.Data.Statistics.TotalDeadDropsCompleted++;
                    try { SaveManager.Save(); }
                    catch { }
                }
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

                var npc = __instance.NPC;
                if (npc == null) return;

                string guid = npc.GUID.ToString();
                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null) return;

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

                // Decide prepaid vs async
                bool isPrepaid = (float)UnityEngine.Random.value < ddConfig.PrepaidChance;

                // Store assignment on profile for later resolution
                profile.ActiveDeadDropGuid = selectedDrop;
                profile.ActiveDeadDropIsPrepaid = isPrepaid;
                profile.ActiveDeadDropPendingCompletion = true;

                // Swap delivery location to dead drop
                __result.DeliveryLocationGUID = selectedDrop;

                // Apply async price premium
                if (!isPrepaid)
                {
                    float premium = ddConfig.AsyncPremiumMin +
                        (ddConfig.AsyncPremiumMax - ddConfig.AsyncPremiumMin) * (float)UnityEngine.Random.value;
                    __result.Payment *= (1f + premium);
                }

                // Wire PricingEngine: apply loyalty discount, addiction premium, market fluctuation, events
                try
                {
                    string drugName = "";
                    try
                    {
                        if (__result.Products?.entries != null && __result.Products.entries.Count > 0)
                            drugName = __result.Products.entries[0].ProductID ?? "";
                    }
                    catch { }

                    __result.Payment = PricingEngine.CalculateCustomerPrice(
                        __result.Payment,
                        __instance.CurrentAddiction,
                        profile.SuccessfulDeals,
                        ConfigManager.Config.Pricing,
                        SaveManager.Data.ActiveEvents,
                        drugName,
                        ConfigManager.Events.ShortagePriceIncrease);
                }
                catch (Exception ex)
                {
                    if (ConfigManager.Config.General.DebugLogging)
                        MelonLogger.Warning($"[DynamicOrdersMod] Pricing engine error: {ex.Message}");
                }

                // Task 8: Discovery quests on first dead drop eligibility
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
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] TryGenerateContract error: {ex.Message}");
            }
        }
    }
}