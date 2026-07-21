using System;
using HarmonyLib;
using Il2CppScheduleOne.Money;
using MelonLoader;
using DynamicOrdersMod.Core;
using DynamicOrdersMod.Persistence;

namespace DynamicOrdersMod.Patches
{
    [HarmonyPatch(typeof(MoneyManager), "ChangeCashBalance")]
    public static class MoneyManagerPatches
    {
        static void Postfix(MoneyManager __instance, float change, bool visualizeChange, bool playCashSound)
        {
            try
            {
                if (DynamicEconomyCore.Instance == null || !DynamicEconomyCore.Instance.ScalingEnabled) return;
                if (change <= 0f) return;

                // Track wholesale-related revenue
                // Positive cash changes are attributed proportionally to wholesale
                // when any wholesale customers are active
                if (SaveManager.Data == null) return;

                bool hasWholesale = false;
                foreach (var profile in SaveManager.Data.CustomerProfiles.Values)
                {
                    if (profile.IsWholesale) { hasWholesale = true; break; }
                }

                if (hasWholesale)
                    SaveManager.Data.Statistics.TotalWholesaleRevenue += change;
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] MoneyManager tracking error: {ex.Message}");
            }
        }
    }
}
