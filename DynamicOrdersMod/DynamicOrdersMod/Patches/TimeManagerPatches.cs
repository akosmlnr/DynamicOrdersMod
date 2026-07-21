using System;
using HarmonyLib;
using Il2CppScheduleOne.GameTime;
using MelonLoader;
using DynamicOrdersMod.Core;

namespace DynamicOrdersMod.Patches
{
    [HarmonyPatch(typeof(TimeManager), "EndSleep")]
    public static class TimeManagerPatches
    {
        static void Postfix(TimeManager __instance)
        {
            try
            {
                if (DynamicEconomyCore.Instance == null) return;
                int currentDay = 0;
                try { currentDay = __instance.ElapsedDays; } catch { }
                DynamicEconomyCore.Instance.OnDayEnd(currentDay);
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] EndSleep error: {ex.Message}");
            }
        }
    }
}