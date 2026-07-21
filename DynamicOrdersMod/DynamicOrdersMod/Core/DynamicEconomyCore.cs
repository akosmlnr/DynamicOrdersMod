using MelonLoader;
using DynamicOrdersMod.Persistence;
using DynamicOrdersMod.Systems;

namespace DynamicOrdersMod.Core
{
    public class DynamicEconomyCore
    {
        public static DynamicEconomyCore Instance { get; private set; }
        public bool IsInitialized { get; private set; }
        public bool ScalingEnabled => ConfigManager.Config?.General.Enabled ?? false;

        public static void Initialize()
        {
            if (Instance != null) return;
            Instance = new DynamicEconomyCore();

            ConfigManager.Load();
            SaveManager.Load();
            Instance.IsInitialized = true;
            MelonLogger.Msg("[DynamicOrdersMod] Core initialized.");
        }

        public void OnDayEnd(int currentDay)
        {
            if (!IsInitialized || !ScalingEnabled) return;
            if (!IsHost()) return;
            try
            {
                ConfigManager.Reload();
                DeadDropManager.InitializeDeadDropStates();
                CustomerProfileManager.ApplyDailyDecay(currentDay);
                DeadDropManager.UpdateHeat();
                DeadDropManager.UpdateMapLabels();
                EventManager.RollDailyEvents(currentDay);
                ProcessWeeklyWholesale(currentDay);
                SaveManager.Save();
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] OnDayEnd error: {ex.Message}");
            }
        }

        public void ProcessWeeklyWholesale(int currentDay)
        {
            if (!IsInitialized || !ScalingEnabled) return;
            if (currentDay % 7 != 0) return;
            if (!IsHost()) return;

            var config = ConfigManager.Config.Wholesale;
            if (!config.Enabled) return;

            try
            {
                float totalRevenue = 0f;
                foreach (var profile in SaveManager.Data.CustomerProfiles.Values)
                {
                    if (!profile.IsWholesale) continue;
                    if (!CustomerProfileManager.IsCustomerAvailable(profile, currentDay)) continue;

                    // Base weekly revenue estimate: $50-200 per wholesale customer
                    // This is a simplified model — real implementation would
                    // track actual sales through the MoneyManager patch.
                    float baseRevenue = 100f * profile.Tolerance;
                    float cut = baseRevenue * config.WeeklyRevenueCut;
                    totalRevenue += cut;
                }

                if (totalRevenue > 0f)
                {
                    try
                    {
                        var moneyManager = Il2CppScheduleOne.Money.MoneyManager.Instance;
                        if (moneyManager != null)
                            moneyManager.ChangeCashBalance(totalRevenue, false, false);
                    }
                    catch (System.Exception ex)
                    {
                        MelonLogger.Warning($"[DynamicOrdersMod] Wholesale revenue deposit failed: {ex.Message}");
                    }

                    if (ConfigManager.Config.General.DebugLogging)
                        MelonLogger.Msg($"[DynamicOrdersMod] Weekly wholesale revenue: ${totalRevenue:F2}");
                }
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] ProcessWeeklyWholesale error: {ex.Message}");
            }
        }

        private static bool IsHost()
        {
            try
            {
                var lobby = Il2CppScheduleOne.Networking.Lobby.Instance;
                return lobby != null && lobby.IsHost;
            }
            catch { return true; }
        }
    }
}
