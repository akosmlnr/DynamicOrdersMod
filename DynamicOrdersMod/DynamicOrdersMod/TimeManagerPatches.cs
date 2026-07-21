using HarmonyLib;
using Il2CppScheduleOne.GameTime;

namespace DynamicOrdersMod
{
    [HarmonyPatch(typeof(TimeManager), "EndSleep")]
    public static class TimeManagerPatches
    {
        static void Postfix()
        {
            // At the end of each in-game day...
            BudgetManager.RefreshDailyTransactions();
        }
    }

}
