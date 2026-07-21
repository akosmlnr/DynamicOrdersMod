using System;
using HarmonyLib;
using Il2CppScheduleOne.Economy;
using MelonLoader;
using DynamicOrdersMod.Core;
using DynamicOrdersMod.Systems;
using DynamicOrdersMod.Models;

namespace DynamicOrdersMod.Patches
{
    public static class CustomerPatches
    {
        [HarmonyPatch(typeof(Customer), "GetWeightedRandomProduct")]
        [HarmonyPostfix]
        static void GetWeightedRandomProductPostfix(
            Customer __instance,
            ref float appeal,
            ref int orderableQuantity)
        {
            try
            {
                if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true) return;
                if (__instance == null || orderableQuantity <= 1) return;

                var profile = CustomerProfileManager.GetOrCreateProfile(
                    __instance.NPC?.GUID.ToString());
                if (profile == null) return;

                float addiction = __instance.CurrentAddiction;
                float normalizedRel = 0f;
                try { normalizedRel = __instance.NPC?.RelationData?.NormalizedRelationDelta ?? 0f; }
                catch { }

                int scaled = ScalingEngine.CalculateScaledQuantity(
                    orderableQuantity, addiction, normalizedRel, profile.Tolerance,
                    ConfigManager.Config.Scaling);

                // Wholesale multiplier: bulk orders from wholesale-eligible customers
                if (CustomerProfileManager.MeetsWholesaleRequirements(profile) &&
                    normalizedRel >= ConfigManager.Config.Wholesale.MinRelationship)
                {
                    scaled = (int)(scaled * ConfigManager.Config.Wholesale.BulkOrderMultiplier);
                    if (!profile.IsWholesale)
                    {
                        profile.IsWholesale = true;
                        profile.WholesaleWeeksActive = 0;
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
        static void EvaluateDeliveryPostfix(Customer __instance, float satisfaction)
        {
            try
            {
                if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true) return;
                if (__instance == null) return;

                string guid = __instance.NPC?.GUID.ToString();
                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null) return;

                // Record the purchase
                profile.RecordPurchase();

                // Tolerance growth (simplified — no access to exact quantity here,
                // but satisfaction correlates with deal size)
                float toleranceGain = (1f - satisfaction) * ConfigManager.Config.Tolerance.GainPerDelivery * 2f;
                profile.Tolerance = CustomerProfileManager.Clamp(profile.Tolerance + toleranceGain);

                // Roll overdose
                float overdoseChance = EventManager.CalculateOverdoseChance(
                    profile, 0f, 1f, __instance.CurrentAddiction, 1f);
                if (overdoseChance > 0f && (float)UnityEngine.Random.value < overdoseChance)
                {
                    int currentDay = 0;
                    try { currentDay = Il2CppScheduleOne.GameTime.TimeManager.Instance.ElapsedDays; } catch { }
                    EventManager.ResolveOverdose(profile, currentDay);
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] EvaluateDelivery error: {ex.Message}");
            }
        }

        [HarmonyPatch(typeof(Customer), "TryGenerateContract")]
        [HarmonyPrefix]
        static bool TryGenerateContractPrefix(Customer __instance, ref bool __result)
        {
            try
            {
                if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true) return true; // let original run
                if (!ConfigManager.Config.DeadDrop.Enabled) return true;
                if (__instance == null) return true;

                // Get customer data
                var npc = __instance.NPC;
                if (npc == null) return true;

                string guid = npc.GUID.ToString();
                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null) return true;

                // Get relationship (normalized 0-1)
                float normalizedRel = 0f;
                try { normalizedRel = npc.RelationData?.NormalizedRelationDelta ?? 0f; }
                catch { }
                if (normalizedRel < ConfigManager.Config.DeadDrop.MinRelationship) return true;

                // Get quantity to check threshold
                // We can't easily get "normal quantity" here without calling the original,
                // so we use a simplified check: if the customer has high tolerance + high relationship,
                // they become eligible. The actual quantity check happens when the deal is created.
                if (profile.Tolerance < 0.3f) return true;
                if (profile.LifetimeDeals < 5) return true;

                // Check cooldown
                int currentDay = 0;
                try { currentDay = Il2CppScheduleOne.GameTime.TimeManager.Instance.ElapsedDays; }
                catch { }
                if (profile.LastDeadDropFailDay > 0 &&
                    currentDay - profile.LastDeadDropFailDay < ConfigManager.Config.DeadDrop.TheftCooldownDays)
                    return true;

                // Customer is eligible for dead drop. We don't block the original contract
                // generation here — instead, we flag this customer so the contract system
                // can use dead drop delivery. The actual dead drop assignment happens
                // when the contract is accepted.
                //
                // For now, we let the original method run normally.
                // Dead drop conversion will be handled by a ContractManager patch in a future task.
                return true;
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] TryGenerateContract error: {ex.Message}");
                return true; // never block original on error
            }
        }
    }
}