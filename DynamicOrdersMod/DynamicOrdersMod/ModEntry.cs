using MelonLoader;
using DynamicOrdersMod;

namespace DynamicOrdersEconomyMod
{
    public class DynamicOrdersEconomy : MelonMod
    {
        public override void OnInitializeMelon()
        {
            DataManager.Load();
            var harmony = new HarmonyLib.Harmony("com.akosmlnr.dynamicorders&economy");
            harmony.PatchAll();
        }
    }
}