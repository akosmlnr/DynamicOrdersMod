using HarmonyLib;
using Il2CppScheduleOne.Economy;

namespace DynamicOrdersMod
{ 
    [HarmonyPatch(typeof(CustomerData))]
    [HarmonyPatch("get_Standards", MethodType.Getter)]
    static class CustomerDataPatches
    {
        static void Postfix(CustomerData __instance)
        {
            BudgetManager.AssignBaseBudgets(__instance);
        }
    }

}
