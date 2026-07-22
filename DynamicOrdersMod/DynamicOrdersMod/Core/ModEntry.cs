using System;
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

            var harmony = new HarmonyLib.Harmony("com.akosmlnr.dynamicordersmod.v3");
            harmony.PatchAll();
            LoggerInstance.Msg("[DynamicOrdersMod v3] Patches applied. All systems ready.");
        }

        /// <summary>
        /// Poll for TimeManager.Instance availability and subscribe to onSleepEnd once ready.
        /// TimeManager is a NetworkBehaviour singleton that spawns on scene load, so it is NOT
        /// available during OnInitializeMelon. We poll OnUpdate (cheap — early return once subscribed)
        /// until the singleton exists, then attach our day-end handler.
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
                // Il2Cpp interop exposes the game's System.Action fields as Il2CppSystem.Action.
                // DelegateSupport.ConvertDelegate wraps our managed method into the il2cpp delegate type.
                if (_sleepEndDelegate == null)
                    _sleepEndDelegate = DelegateSupport.ConvertDelegate<Il2CppSystem.Action>(
                        new Action(DynamicEconomyCore.Instance.OnTimeSleepEnd));

                // Subscribe to onSleepEnd — fires AFTER the sleep coroutine completes and the
                // day has rolled over (unlike StartSleep which fires when sleep begins).
                // This is the correct semantic moment for OnDayEnd processing.
                tm.onSleepEnd += _sleepEndDelegate;
                _timeHookSubscribed = true;
                MelonLogger.Msg("[DynamicOrdersMod v3] Subscribed to TimeManager.onSleepEnd.");
            }
            catch { /* TimeManager not ready yet — keep polling */ }
        }

        public override void OnApplicationQuit()
        {
            // Defensive cleanup — unsubscribe if we managed to subscribe
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
