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

                    profile.WholesaleWeeksActive++;

                    float baseRevenue = 100f * profile.Tolerance;
                    float cut = baseRevenue * config.WeeklyRevenueCut;
                    totalRevenue += cut;

                    // Track actual revenue via WholesaleRecord
                    SaveManager.Data.WholesaleRecords.Add(new Models.WholesaleRecord
                    {
                        Week = currentDay / 7,
                        CustomerGuid = profile.CustomerGuid,
                        Amount = cut
                    });
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

                // Trim old wholesale records (keep last 52 weeks)
                try
                {
                    if (SaveManager.Data.WholesaleRecords.Count > 520)
                    {
                        int minWeek = (currentDay / 7) - 52;
                        SaveManager.Data.WholesaleRecords.RemoveAll(r => r.Week < minWeek);
                    }
                }
                catch { }
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] ProcessWeeklyWholesale error: {ex.Message}");
            }
        }

        public static bool IsHost()
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
