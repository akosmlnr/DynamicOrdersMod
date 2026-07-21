using System;
using HarmonyLib;
using Il2CppScheduleOne.Economy;
using MelonLoader;
using DynamicOrdersMod.Core;
using DynamicOrdersMod.Systems;
using DynamicOrdersMod.Persistence;

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
    }
}