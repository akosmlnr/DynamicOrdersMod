using System;
using HarmonyLib;
using Il2CppScheduleOne.GameTime;
using MelonLoader;
using DynamicOrdersMod.Core;

namespace DynamicOrdersMod.Patches
{
    /// <summary>
    /// Schedule I has no EndSleep method. Sleep flow is:
    ///   StartSleep() -> SkipForwardToTime() -> ElapsedDays increments
    /// We hook StartSleep (an ObserversRpc that fires on all clients when sleep begins).
    /// Postfix runs with ElapsedDays still at the day that's about to end, which is
    /// the correct semantic for "OnDayEnd" processing (decay, events, deal resolution).
    /// </summary>
    [HarmonyPatch(typeof(TimeManager), "StartSleep")]
    public static class TimeManagerPatches
    {
        static void Postfix(TimeManager __instance)
        {
            try
            {
                if (DynamicEconomyCore.Instance == null) return;
                int currentDay = 0;
                try { currentDay = __instance.ElapsedDays; } catch { }
                DynamicOrdersMod.Core.DebugLog.Msg("sleep",
                    $"StartSleep fired, day={currentDay}, OnDayEnd will run");
                DynamicEconomyCore.Instance.OnDayEnd(currentDay);
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] StartSleep postfix error: {ex.Message}");
            }
        }
    }
}