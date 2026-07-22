using System;
using System.Linq;
using MelonLoader;
using HarmonyLib;
using Il2CppInterop.Runtime;

namespace DynamicOrdersMod.Core
{
    public class ModEntry : MelonMod
    {
        public static ModEntry Instance { get; private set; }
        private bool _timeHookSubscribed;
        private int _hookPollCounter;
        private Il2CppSystem.Action _sleepEndDelegate;

        public override void OnInitializeMelon()
        {
            Instance = this;
            LoggerInstance.Msg("[DynamicOrdersMod v3] Initializing...");

            DynamicEconomyCore.Initialize();

            // Use HarmonyInstance.PatchAll(Assembly) — matches the pattern used by working
            // Schedule I mods (HonestMainMenu, Deal-Optimizer-Mod). The HarmonyInstance static
            // accessor goes through MelonLoader's preferred patch processor path, and passing
            // the assembly explicitly is more reliable than the parameterless overload.
            try
            {
                HarmonyInstance.PatchAll(System.Reflection.Assembly.GetExecutingAssembly());
                LoggerInstance.Msg("[DynamicOrdersMod v3] Patches applied. All systems ready.");

                // Log which methods actually got patched for diagnostic confirmation
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
        /// Poll for TimeManager.Instance availability and subscribe to onSleepEnd once ready.
        /// TimeManager is a NetworkBehaviour singleton that spawns on scene load, so it is NOT
        /// available during OnInitializeMelon. We poll OnUpdate (cheap — early return once subscribed)
        /// until the singleton exists, then attach our day-end handler.
        ///
        /// This is the ONLY UnityEvent subscription remaining — day-end processing has no Harmony
        /// equivalent (TimeManager.StartSleep fires too early, and the onSleepEnd Action delegate
        /// is the only signal that fires AFTER the day rolls over).
        /// </summary>
        public override void OnUpdate()
        {
            if (_timeHookSubscribed) return;

            // Cheap throttling — only check every 30 frames (~0.5s)
            if ((_hookPollCounter++ % 30) != 0) return;

            try
            {
                var tm = Il2CppScheduleOne.GameTime.TimeManager.Instance;
                if (tm == null) return;

                // Cache the delegate so we can unsubscribe the exact same instance later.
                if (_sleepEndDelegate == null)
                    _sleepEndDelegate = DelegateSupport.ConvertDelegate<Il2CppSystem.Action>(
                        new Action(DynamicEconomyCore.Instance.OnTimeSleepEnd));

                // Subscribe to onSleepEnd — fires AFTER the sleep coroutine completes and the
                // day has rolled over. This is the correct semantic moment for OnDayEnd processing.
                tm.onSleepEnd += _sleepEndDelegate;
                _timeHookSubscribed = true;
                MelonLogger.Msg("[DynamicOrdersMod v3] Subscribed to TimeManager.onSleepEnd.");
            }
            catch { /* TimeManager not ready yet — keep polling */ }
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
