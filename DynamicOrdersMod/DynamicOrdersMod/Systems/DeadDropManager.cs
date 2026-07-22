using System;
using System.Collections.Generic;
using MelonLoader;
using DynamicOrdersMod.Models;
using DynamicOrdersMod.Persistence;
using Il2CppScheduleOne.Quests;

namespace DynamicOrdersMod.Systems
{
    public static class DeadDropManager
    {
        private static bool _initialized;

        public static void InitializeDeadDropStates()
        {
            if (_initialized) return;
            _initialized = true;
            try
            {
                // Scan game's DeadDrop.DeadDrops list, register any not in save data
                var drops = Il2CppScheduleOne.Deaddrop.DeadDrop.DeadDrops;
                if (drops == null) return;
                for (int i = 0; i < drops.Count; i++)
                {
                    var drop = drops[i];
                    if (drop == null) continue;
                    string guid = drop.GUID.ToString();
                    if (SaveManager.Data.DeadDropStates.ContainsKey(guid)) continue;

                    SaveManager.Data.DeadDropStates[guid] = new DeadDropState
                    {
                        DropGuid = guid,
                        DropName = drop.DeadDropName ?? (drop.name ?? "Unknown Drop"),
                        Region = drop.Region.ToString(),
                        Heat = 0f,
                        IsDiscovered = false,
                        IsOccupied = false
                    };
                }
                if (ConfigManager.Config.General.DebugLogging)
                    MelonLogger.Msg($"[DynamicOrdersMod] DeadDrop states initialized: {SaveManager.Data.DeadDropStates.Count} drops.");
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[DynamicOrdersMod] DeadDrop init failed (non-fatal): {ex.Message}");
            }
        }

        /// <summary>
        /// Returns list of discovered, unoccupied drop GUIDs.
        /// </summary>
        public static List<string> GetAvailableDrops()
        {
            var result = new List<string>();
            var states = SaveManager.Data?.DeadDropStates;
            if (states == null) return result;
            foreach (var kvp in states)
            {
                if (kvp.Value.IsDiscovered && !kvp.Value.IsOccupied)
                    result.Add(kvp.Key);
            }
            return result;
        }

        /// <summary>
        /// Selects the discovered drop with lowest heat for async orders.
        /// Returns GUID or null.
        /// </summary>
        public static string SelectDropForAsync()
        {
            string best = null;
            float bestHeat = float.MaxValue;
            var states = SaveManager.Data?.DeadDropStates;
            if (states == null) return null;
            foreach (var kvp in states)
            {
                if (!kvp.Value.IsDiscovered || kvp.Value.IsOccupied) continue;
                if (kvp.Value.Heat < bestHeat)
                {
                    bestHeat = kvp.Value.Heat;
                    best = kvp.Key;
                }
            }
            if (best != null)
            {
                states[best].IsOccupied = true;
                states[best].Heat = Clamp01(states[best].Heat + 0.05f); // small heat for use
            }
            return best;
        }

        /// <summary>
        /// Resolves a dead drop after the deal window closes.
        /// Returns: "success", "theft", "nonpayment", "police", or "expired"
        /// </summary>
        public static string ResolveDeadDrop(string dropGuid, bool isPrepaid, bool wasDelivered, CustomerProfile profile)
        {
            var config = ConfigManager.Config.DeadDrop;
            var state = GetState(dropGuid);
            if (state == null) return "expired";

            state.IsOccupied = false;

            if (!wasDelivered)
            {
                // Missed window — handled by caller for relationship
                SaveManager.Data.Statistics.TotalDeadDropsFailed++;
                if (profile != null) profile.RecordFailure();
                return "expired";
            }

            // Event rolls
            // Police intercept: base chance * (1 + heat) * crackdown multiplier
            float crackdownMult = 1f;
            try
            {
                if (EventManager.IsCrackdownActive(state.Region))
                    crackdownMult = ConfigManager.Config.Events.CrackdownDeadDropRiskMultiplier;
            }
            catch { }
            float policeChance = config.PoliceInterceptBaseChance * (1f + state.Heat) * crackdownMult;
            if (RngNext() < policeChance)
            {
                state.Heat = Clamp01(state.Heat + 0.5f);
                SaveManager.Data.Statistics.TotalDeadDropsFailed++;
                if (profile != null) profile.RecordFailure();
                return "police";
            }

            // Theft: 3%
            if (RngNext() < config.TheftChance)
            {
                state.Heat = Clamp01(state.Heat + 0.3f);
                SaveManager.Data.Statistics.TotalDeadDropsFailed++;
                if (profile != null) profile.RecordFailure();
                return "theft";
            }

            // Non-payment: 8% async only
            if (!isPrepaid && RngNext() < config.NonPaymentChance)
            {
                SaveManager.Data.Statistics.TotalDeadDropsFailed++;
                if (profile != null) profile.RecordFailure();
                return "nonpayment";
            }

            // Success
            state.Heat = Clamp01(state.Heat - 0.1f);
            return "success";
        }

        /// <summary>
        /// Daily heat decay. Called from OnDayEnd.
        /// </summary>
        public static void UpdateHeat()
        {
            var config = ConfigManager.Config.DeadDrop;
            var states = SaveManager.Data?.DeadDropStates;
            if (states == null) return;
            foreach (var state in states.Values)
            {
                if (!state.IsOccupied && state.Heat > 0f)
                {
                    state.Heat = Math.Max(0f, state.Heat - config.HeatDecayPerDay);
                }
            }
        }

        /// <summary>
        /// Updates map POI labels with heat info. Called from OnDayEnd if config enabled.
        /// </summary>
        public static void UpdateMapLabels()
        {
            if (!ConfigManager.Config.DeadDrop.ShowHeatOnMap) return;
            if (!ConfigManager.Config.DeadDrop.Enabled) return;
            try
            {
                var drops = Il2CppScheduleOne.Deaddrop.DeadDrop.DeadDrops;
                if (drops == null) return;
                for (int i = 0; i < drops.Count; i++)
                {
                    var drop = drops[i];
                    if (drop == null) continue;
                    string guid = drop.GUID.ToString();
                    var state = GetState(guid);
                    if (state == null || !state.IsDiscovered) continue;

                    string heatLabel = GetHeatLabel(state.Heat);
                    string label = $"{state.DropName} [Risk: {heatLabel}]";

                    // Update POI if available
                    try
                    {
                        if (drop.PoI != null)
                            drop.PoI.SetMainText(label);
                    }
                    catch { }
                }
            }
            catch (Exception ex)
            {
                if (ConfigManager.Config.General.DebugLogging)
                    MelonLogger.Warning($"[DynamicOrdersMod] Map label update failed: {ex.Message}");
            }
        }

        public static void MarkDropDiscovered(string dropGuid)
        {
            var state = GetState(dropGuid);
            if (state != null) state.IsDiscovered = true;
        }

        public static bool IsDropDiscovered(string dropGuid)
        {
            var state = GetState(dropGuid);
            return state != null && state.IsDiscovered;
        }

        /// <summary>
        /// Checks if a customer is eligible for dead drop orders.
        /// </summary>
        public static bool IsCustomerEligible(CustomerProfile profile, int quantity, int normalQuantity, int currentDay)
        {
            if (profile == null) return false;
            if (!ConfigManager.Config.DeadDrop.Enabled) return false;

            // Must have enough relationship (will be checked with live data by caller)
            // Quantity must exceed threshold * normal
            if (normalQuantity <= 0) return false;
            if ((float)quantity / normalQuantity < ConfigManager.Config.DeadDrop.QuantityThreshold) return false;

            // Cooldown after failure
            if (profile.LastDeadDropFailDay > 0 &&
                currentDay - profile.LastDeadDropFailDay < ConfigManager.Config.DeadDrop.TheftCooldownDays)
                return false;

            return true;
        }

        public static float GetDropHeat(string dropGuid)
        {
            var state = GetState(dropGuid);
            return state?.Heat ?? 0f;
        }

        /// <summary>
        /// Attempt to spawn discovery quests for undiscovered dead drops.
        /// Called when a customer first becomes dead-drop eligible.
        /// </summary>
        public static void TrySpawnDiscoveryQuests(int count, CustomerProfile profile)
        {
            if (SaveManager.Data?.DeadDropStates == null) return;
            if (profile == null) return;

            var undiscovered = new List<string>();
            foreach (var kvp in SaveManager.Data.DeadDropStates)
            {
                if (!kvp.Value.IsDiscovered)
                    undiscovered.Add(kvp.Key);
            }

            if (undiscovered.Count == 0) return;

            // Shuffle and take up to count
            for (int i = undiscovered.Count - 1; i > 0; i--)
            {
                int j = _rng.Next(i + 1);
                string tmp = undiscovered[i];
                undiscovered[i] = undiscovered[j];
                undiscovered[j] = tmp;
            }

            int toDiscover = Math.Min(count, undiscovered.Count);
            try
            {
                var questManager = Il2CppScheduleOne.Quests.QuestManager.Instance;
                if (questManager == null) return;

                for (int i = 0; i < toDiscover; i++)
                {
                    string dropGuid = undiscovered[i];
                    var quest = questManager.CreateDeaddropCollectionQuest(dropGuid);
                    if (quest != null)
                    {
                        quest.Begin();
                        var state = GetState(dropGuid);
                        if (state != null) state.IsDiscovered = true;
                        profile.DiscoveredDeadDrops.Add(dropGuid);
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[DynamicOrdersMod] Discovery quest spawn failed: {ex.Message}");
            }
        }

        // --- Helpers ---

        private static DeadDropState GetState(string guid)
        {
            DeadDropState state;
            if (SaveManager.Data?.DeadDropStates != null &&
                SaveManager.Data.DeadDropStates.TryGetValue(guid, out state))
                return state;
            return null;
        }

        private static string GetHeatLabel(float heat)
        {
            if (heat < 0.2f) return "Low";
            if (heat < 0.5f) return "Medium";
            if (heat < 0.8f) return "High";
            return "Critical";
        }

        private static float Clamp01(float v)
        {
            if (v < 0f) return 0f;
            return v > 1f ? 1f : v;
        }

        // Simple RNG for event rolls (not hot path, no ThreadStatic needed)
        private static readonly Random _rng = new Random();
        private static float RngNext()
        {
            return (float)_rng.NextDouble();
        }
    }
}