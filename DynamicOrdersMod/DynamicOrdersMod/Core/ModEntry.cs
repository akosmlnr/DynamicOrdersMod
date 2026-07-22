using MelonLoader;
using HarmonyLib;

namespace DynamicOrdersMod.Core
{
    public class ModEntry : MelonMod
    {
        public static ModEntry Instance { get; private set; }
        private bool _timeHookSubscribed;
        private int _hookPollCounter;

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

                // Subscribe to onSleepEnd — fires AFTER the sleep coroutine completes and the
                /// day has rolled over (unlike StartSleep which fires when sleep begins).
                /// This is the correct semantic moment for OnDayEnd processing.
                tm.onSleepEnd += DynamicEconomyCore.Instance.OnTimeSleepEnd;
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
                if (tm != null)
                    tm.onSleepEnd -= DynamicEconomyCore.Instance.OnTimeSleepEnd;
            }
            catch { }
            _timeHookSubscribed = false;
        }
    }
}
