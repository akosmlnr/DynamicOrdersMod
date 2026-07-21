using MelonLoader;
using DynamicOrdersMod.Persistence;

namespace DynamicOrdersMod.Core
{
    public class DynamicEconomyCore
    {
        public static DynamicEconomyCore Instance { get; private set; }

        public static void Initialize()
        {
            if (Instance != null) return;
            Instance = new DynamicEconomyCore();

            ConfigManager.Load();
            SaveManager.Load();

            MelonLogger.Msg("[DynamicOrdersMod] Core initialized.");
        }

        public void OnDayEnd(int currentDay)
        {
            // Will be expanded in later tasks
        }
    }
}