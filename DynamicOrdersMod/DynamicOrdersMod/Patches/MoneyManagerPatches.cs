using HarmonyLib;
using Il2CppScheduleOne.Money;

namespace DynamicOrdersMod.Patches
{
    [HarmonyPatch(typeof(MoneyManager), "ChangeCashBalance")]
    public static class MoneyManagerPatches
    {
        static void Postfix(MoneyManager __instance, float change, bool visualizeChange, bool playCashSound)
        {
            // Phase 3: wholesale revenue tracking
        }
    }
}