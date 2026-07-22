using System;
using System.Linq;
using MelonLoader;
using HarmonyLib;
using UnityEngine.Events;
using Il2CppInterop.Runtime;

namespace DynamicOrdersMod.Core
{
    public class ModEntry : MelonMod
    {
        public static ModEntry Instance { get; private set; }
        private bool _timeHookSubscribed;
        private int _hookPollCounter;
        private Il2CppSystem.Action _sleepEndDelegate;
        private Il2CppSystem.Action<Il2CppScheduleOne.Economy.Customer> _customerUnlockedDelegate;

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

            // DIAGNOSTIC: log which patches actually bound to real methods.
            LogPatchBindingStatus(HarmonyInstance);
        }

        /// <summary>
        /// For each intended target method, query Harmony to see if any patches are bound.
        /// Methods that didn't bind show zero patches — meaning the attribute didn't match
        /// a real method on the Il2Cpp type.
        /// </summary>
        private void LogPatchBindingStatus(HarmonyLib.Harmony harmony)
        {
            try
            {
                var targets = new[]
                {
                    // Old targets (for continued verification)
                    ("Customer.OfferContract", typeof(Il2CppScheduleOne.Economy.Customer), "OfferContract"),
                    ("Customer.ProcessHandover", typeof(Il2CppScheduleOne.Economy.Customer), "ProcessHandover"),
                    ("Contract.Complete", typeof(Il2CppScheduleOne.Quests.Contract), "Complete"),
                    ("SaveManager.Save()", typeof(Il2CppScheduleOne.Persistence.SaveManager), "Save"),
                    // New probe targets
                    ("PROBE: Contract.InitializeContract", typeof(Il2CppScheduleOne.Quests.Contract), "InitializeContract"),
                    ("PROBE: Dealer.ContractedOffered", typeof(Il2CppScheduleOne.Economy.Dealer), "ContractedOffered"),
                };
                foreach (var (label, type, methodName) in targets)
                {
                    try
                    {
                        var method = HarmonyLib.AccessTools.Method(type, methodName);
                        if (method != null)
                        {
                            var info = HarmonyLib.PatchProcessor.GetPatchInfo(method);
                            int pre = info?.Prefixes?.Count ?? 0;
                            int post = info?.Postfixes?.Count ?? 0;
                            MelonLogger.Msg($"[Diagnostic] {label}: BOUND (prefixes={pre}, postfixes={post})");
                        }
                        else
                        {
                            MelonLogger.Msg($"[Diagnostic] {label}: METHOD NOT FOUND via AccessTools");
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MelonLogger.Msg($"[Diagnostic] {label}: ERROR {ex.Message}");
                    }
                }
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[Diagnostic] Status log failed: {ex.Message}");
            }
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

                // FALLBACK: subscribe to Customer.onCustomerUnlocked (static Action) so we can
                // hook each customer's UnityEvents as they unlock. This bypasses Harmony entirely
                // and uses Unity's event system — more reliable for methods that may not bind.
                try
                {
                    if (_customerUnlockedDelegate == null)
                        _customerUnlockedDelegate = DelegateSupport.ConvertDelegate<Il2CppSystem.Action<Il2CppScheduleOne.Economy.Customer>>(
                            new Action<Il2CppScheduleOne.Economy.Customer>(OnCustomerUnlocked));
                    Il2CppScheduleOne.Economy.Customer.onCustomerUnlocked += _customerUnlockedDelegate;
                    MelonLogger.Msg("[DynamicOrdersMod v3] Subscribed to Customer.onCustomerUnlocked.");

                    // Also subscribe to any customers already unlocked before we hooked the event
                    var already = Il2CppScheduleOne.Economy.Customer.UnlockedCustomers;
                    if (already != null)
                    {
                        for (int i = 0; i < already.Count; i++)
                        {
                            try { OnCustomerUnlocked(already[i]); } catch { }
                        }
                        MelonLogger.Msg($"[DynamicOrdersMod v3] Retro-subscribed {already.Count} already-unlocked customers.");
                    }
                }
                catch (System.Exception ex)
                {
                    MelonLogger.Error($"[DynamicOrdersMod v3] Customer event subscription failed: {ex.Message}");
                }
            }
            catch { /* TimeManager not ready yet — keep polling */ }
        }

        /// <summary>
        /// Called when a customer unlocks. Subscribes to that customer's UnityEvents
        /// (onDealCompleted, onContractAssigned) as a fallback for when Harmony patches
        /// don't bind. UnityEvents fire regardless of caller language (native or managed).
        /// </summary>
        private static void OnCustomerUnlocked(Il2CppScheduleOne.Economy.Customer customer)
        {
            if (customer == null) return;
            try
            {
                string guid = "?";
                try { guid = customer.NPC?.GUID.ToString() ?? "?"; } catch { }
                MelonLogger.Msg($"[DOM] [cust={DebugLog.Short(guid)}] CUSTOMER UNLOCKED — subscribing to UnityEvents");

                // Subscribe to onDealCompleted — fires when the customer completes any deal.
                // Il2Cpp interop's UnityAction can't take a managed lambda directly (CS1660),
                // so we wrap via DelegateSupport.ConvertDelegate like we do for Action fields.
                if (customer.onDealCompleted != null)
                {
                    var managedAction = new Action(() =>
                    {
                        try
                        {
                            MelonLogger.Msg($"[DOM] [cust={DebugLog.Short(guid)}] onDealCompleted (UnityEvent) FIRED");
                            DynamicEconomyCore.Instance.OnCustomerDealCompleted(customer);
                        }
                        catch (System.Exception ex)
                        {
                            MelonLogger.Error($"[DOM] onDealCompleted handler error: {ex.Message}");
                        }
                    });
                    var il2cppAction = DelegateSupport.ConvertDelegate<UnityAction>(managedAction);
                    customer.onDealCompleted.AddListener(il2cppAction);
                }

                // Subscribe to onContractAssigned — fires with the Contract when assigned
                if (customer.onContractAssigned != null)
                {
                    var managedAction = new Action<Il2CppScheduleOne.Quests.Contract>(contract =>
                    {
                        try
                        {
                            MelonLogger.Msg($"[DOM] [cust={DebugLog.Short(guid)}] onContractAssigned (UnityEvent) FIRED contract={contract}");
                            DynamicEconomyCore.Instance.OnCustomerContractAssigned(customer, contract);

                            // Also subscribe to THIS contract's onComplete/onQuestEnd events
                            // so we capture per-contract completion with item-level data.
                            if (contract != null)
                            {
                                try { SubscribeToContractEvents(contract, guid); } catch { }
                            }
                        }
                        catch (System.Exception ex)
                        {
                            MelonLogger.Error($"[DOM] onContractAssigned handler error: {ex.Message}");
                        }
                    });
                    var il2cppAction = DelegateSupport.ConvertDelegate<UnityAction<Il2CppScheduleOne.Quests.Contract>>(managedAction);
                    customer.onContractAssigned.AddListener(il2cppAction);
                }
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DOM] OnCustomerUnlocked error: {ex.Message}");
            }
        }

        /// <summary>
        /// Subscribe to a Contract's onComplete and onQuestEnd UnityEvents.
        /// These fire from native code when the contract completes/fails/expires,
        /// giving us reliable per-contract completion signals.
        /// </summary>
        private static void SubscribeToContractEvents(Il2CppScheduleOne.Quests.Contract contract, string guid)
        {
            if (contract == null) return;

            // onComplete — fires on successful contract completion
            if (contract.onComplete != null)
            {
                var managedAction = new Action(() =>
                {
                    try
                    {
                        MelonLogger.Msg($"[DOM] [cust={DebugLog.Short(guid)}] contract.onComplete (UnityEvent) FIRED");
                        DynamicEconomyCore.Instance.OnContractComplete(contract, guid);
                    }
                    catch (System.Exception ex)
                    {
                        MelonLogger.Error($"[DOM] contract.onComplete handler error: {ex.Message}");
                    }
                });
                var il2cppAction = DelegateSupport.ConvertDelegate<UnityAction>(managedAction);
                contract.onComplete.AddListener(il2cppAction);
            }

            // onQuestEnd — fires with the final EQuestState (Success/Failed/Expired/Cancelled)
            if (contract.onQuestEnd != null)
            {
                var managedAction = new Action<Il2CppScheduleOne.Quests.EQuestState>(state =>
                {
                    try
                    {
                        MelonLogger.Msg($"[DOM] [cust={DebugLog.Short(guid)}] contract.onQuestEnd (UnityEvent) FIRED state={state}");
                        DynamicEconomyCore.Instance.OnContractEnded(contract, guid, state);
                    }
                    catch (System.Exception ex)
                    {
                        MelonLogger.Error($"[DOM] contract.onQuestEnd handler error: {ex.Message}");
                    }
                });
                var il2cppAction = DelegateSupport.ConvertDelegate<UnityAction<Il2CppScheduleOne.Quests.EQuestState>>(managedAction);
                contract.onQuestEnd.AddListener(il2cppAction);
            }
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
