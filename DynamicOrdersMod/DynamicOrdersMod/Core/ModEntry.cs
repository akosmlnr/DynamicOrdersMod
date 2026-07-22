using System;
using System.Linq;
using MelonLoader;
using HarmonyLib;
using Il2CppInterop.Runtime;
using DynamicOrdersMod.Systems;
using DynamicOrdersMod.Persistence;

namespace DynamicOrdersMod.Core
{
    public class ModEntry : MelonMod
    {
        public static ModEntry Instance { get; private set; }
        private bool _timeHookSubscribed;
        private bool _saveFolderResolved;
        private int _hookPollCounter;
        private Il2CppSystem.Action _sleepEndDelegate;

        public override void OnInitializeMelon()
        {
            Instance = this;
            LoggerInstance.Msg("[DynamicOrdersMod v3] Initializing...");

            DynamicEconomyCore.Initialize();

            try
            {
                HarmonyInstance.PatchAll(System.Reflection.Assembly.GetExecutingAssembly());
                LoggerInstance.Msg("[DynamicOrdersMod v3] Patches applied. All systems ready.");

                var patchedMethods = HarmonyInstance
                    .GetPatchedMethods()
                    .Select(p => $"{p.DeclaringType?.FullName}.{p.Name}");
                LoggerInstance.Msg($"[DynamicOrdersMod v3] Harmony patched methods: {string.Join(", ", patchedMethods)}");
            }
            catch (System.Exception ex)
            {
                LoggerInstance.Error($"[DynamicOrdersMod v3] Failed to apply Harmony patches: {ex.Message}");
                LoggerInstance.Error(ex);
            }
        }

        /// <summary>
        /// Poll for game singletons (TimeManager, SaveManager) on scene load.
        /// These are NetworkBehaviour singletons that spawn when the game loads a save.
        /// Once available, we:
        /// 1. Resolve the per-save folder (for proper save isolation between game saves)
        /// 2. Subscribe to TimeManager.onSleepEnd (day-end processing)
        /// 3. Initialize dead drop states
        /// </summary>
        public override void OnUpdate()
        {
            if (_timeHookSubscribed && _saveFolderResolved) return;

            if ((_hookPollCounter++ % 30) != 0) return;

            // Step 1: Resolve the per-save folder BEFORE anything else.
            // This ensures mod data loads from the correct save folder.
            if (!_saveFolderResolved)
            {
                try
                {
                    SaveManager.ResolveSaveFolder();
                    if (SaveManager.Data != null && Constants.ActiveSaveFolder != null)
                    {
                        _saveFolderResolved = true;
                        MelonLogger.Msg($"[DynamicOrdersMod v3] Save folder resolved: {Constants.ActiveSaveFolder}");
                    }
                }
                catch { }
            }

            // Step 2: Subscribe to TimeManager and init dead drops.
            // Only after save folder is resolved so we don't create profiles in the wrong location.
            if (_saveFolderResolved && !_timeHookSubscribed)
            {
                try
                {
                    var tm = Il2CppScheduleOne.GameTime.TimeManager.Instance;
                    if (tm == null) return;

                    if (_sleepEndDelegate == null)
                        _sleepEndDelegate = DelegateSupport.ConvertDelegate<Il2CppSystem.Action>(
                            new Action(DynamicEconomyCore.Instance.OnTimeSleepEnd));

                    tm.onSleepEnd += _sleepEndDelegate;
                    _timeHookSubscribed = true;
                    MelonLogger.Msg("[DynamicOrdersMod v3] Subscribed to TimeManager.onSleepEnd.");

                    // Initialize dead drop states (scene loaded, DeadDrop.DeadDrops populated).
                    // In debug mode, drops are NOT auto-discovered — discovery quests spawn naturally.
                    try
                    {
                        DeadDropManager.InitializeDeadDropStates();
                    }
                    catch (System.Exception ex)
                    {
                        MelonLogger.Warning($"[DynamicOrdersMod v3] DeadDrop init failed: {ex.Message}");
                    }
                }
                catch { }
            }
        }

        public override void OnApplicationQuit()
        {
            if (!_timeHookSubscribed) return;
            try
            {
                var tm = Il2CppScheduleOne.GameTime.TimeManager.Instance;
                if (tm != null && _sleepEndDelegate != null)
                    tm.onSleepEnd -= _sleepEndDelegate;
            }
            catch { }
            _timeHookSubscribed = false;
        }
    }
}
