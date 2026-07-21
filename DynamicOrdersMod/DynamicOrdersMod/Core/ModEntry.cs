using MelonLoader;
using HarmonyLib;

namespace DynamicOrdersMod.Core
{
    public class ModEntry : MelonMod
    {
        public static ModEntry Instance { get; private set; }

        public override void OnInitializeMelon()
        {
            Instance = this;
            LoggerInstance.Msg("[DynamicOrdersMod v3] Initializing...");

            DynamicEconomyCore.Initialize();

            var harmony = new Harmony("com.akosmlnr.dynamicordersmod.v3");
            harmony.PatchAll();
            LoggerInstance.Msg("[DynamicOrdersMod v3] Patches applied. All systems ready.");
        }
    }
}