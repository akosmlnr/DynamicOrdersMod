using System;
using System.Collections.Generic;
using MelonLoader;
using DynamicOrdersMod.Models;
using DynamicOrdersMod.Persistence;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.Storage;

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
        /// Reads the actual contents of a dead drop's storage and computes the delivery result
        /// against the expected contract terms. Handles all edge cases:
        /// - Wrong product delivered → failure
        /// - Partial quantity → proportional payment + relationship hit
        /// - Higher quality than expected → payment bonus
        /// - Lower quality than expected → customer bargains down (pays less)
        /// - Nothing delivered → no payment, relationship hit, cooldown
        /// </summary>
        /// <returns>DeliveryResult with actual quantities, quality, and computed payment multiplier</returns>
        public static DeliveryResult EvaluateDelivery(string dropGuid, string expectedProductID, int expectedQuality, int expectedQuantity, float contractPayment)
        {
            var result = new DeliveryResult { ActualQuantity = 0, HighestQuality = -1, PaymentMultiplier = 0f, Outcome = "no_delivery" };

            if (string.IsNullOrEmpty(expectedProductID) || expectedQuantity <= 0) return result;

            // Find the DeadDrop object by GUID
            Il2CppScheduleOne.Deaddrop.DeadDrop drop = null;
            try
            {
                var drops = Il2CppScheduleOne.Deaddrop.DeadDrop.DeadDrops;
                if (drops != null)
                {
                    for (int i = 0; i < drops.Count; i++)
                    {
                        var d = drops[i];
                        if (d == null) continue;
                        if (d.GUID.ToString() == dropGuid) { drop = d; break; }
                    }
                }
            }
            catch { }
            if (drop == null) return result;

            // Read storage contents
            List<ItemInstance> allItems = null;
            try
            {
                if (drop.Storage != null)
                    allItems = drop.Storage.GetAllItems();
            }
            catch { }
            if (allItems == null || allItems.Count == 0) return result;

            // Sum quantities of matching product, track highest quality
            int actualQty = 0;
            int highestQuality = -1;
            bool foundCorrectProduct = false;
            bool foundWrongProduct = false;

            for (int i = 0; i < allItems.Count; i++)
            {
                var item = allItems[i];
                if (item == null) continue;

                // Try to get product ID and quality
                string productID = "";
                int quality = -1;
                int quantity = 0;
                try
                {
                    var def = item.Definition;
                    if (def != null) productID = def.ID;
                }
                catch { }
                try
                {
                    var qualityItem = item as Il2CppScheduleOne.ItemFramework.QualityItemInstance;
                    if (qualityItem != null) quality = (int)qualityItem.Quality;
                }
                catch { }
                try { quantity = item.GetTotalAmount(); }
                catch { try { quantity = 1; } catch { } }

                if (string.IsNullOrEmpty(productID)) continue;

                if (productID == expectedProductID)
                {
                    foundCorrectProduct = true;
                    actualQty += quantity;
                    if (quality > highestQuality) highestQuality = quality;
                }
                else
                {
                    foundWrongProduct = true;
                }
            }

            result.ActualQuantity = actualQty;
            result.HighestQuality = highestQuality;

            // Compute outcome and payment multiplier
            if (actualQty == 0)
            {
                // Nothing matching delivered
                result.Outcome = foundWrongProduct ? "wrong_product" : "no_delivery";
                result.PaymentMultiplier = 0f;
                return result;
            }

            // Quantity ratio (capped at 1.0 — over-delivery doesn't pay extra beyond contract)
            float quantityRatio = Math.Min(1f, (float)actualQty / expectedQuantity);

            // Quality multiplier: bargain system
            float qualityMult = 1.0f;
            if (highestQuality >= 0 && expectedQuality >= 0)
            {
                int qualityDiff = highestQuality - expectedQuality;
                if (qualityDiff > 0)
                {
                    // Higher quality than expected → bonus (10% per quality tier above)
                    qualityMult = 1f + (qualityDiff * 0.1f);
                }
                else if (qualityDiff < 0)
                {
                    // Lower quality → customer bargains down (20% per tier below, min 0.5x)
                    qualityMult = Math.Max(0.5f, 1f + (qualityDiff * 0.2f));
                }
            }

            result.PaymentMultiplier = quantityRatio * qualityMult;

            if (actualQty < expectedQuantity)
                result.Outcome = "partial";
            else
                result.Outcome = "success";

            return result;
        }

        /// <summary>
        /// Clears the contents of a dead drop's storage after resolution (items consumed).
        /// </summary>
        public static void ClearDropStorage(string dropGuid)
        {
            try
            {
                var drops = Il2CppScheduleOne.Deaddrop.DeadDrop.DeadDrops;
                if (drops == null) return;
                for (int i = 0; i < drops.Count; i++)
                {
                    var d = drops[i];
                    if (d == null) continue;
                    if (d.GUID.ToString() == dropGuid)
                    {
                        if (d.Storage != null)
                            d.Storage.ClearContents();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                if (ConfigManager.Config.General.DebugLogging)
                    MelonLogger.Warning($"[DynamicOrdersMod] ClearDropStorage failed: {ex.Message}");
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
        /// Adjust heat on a drop. Positive = increase, negative = decrease. Clamped 0-1.
        /// </summary>
        public static void AddHeat(string dropGuid, float delta)
        {
            var state = GetState(dropGuid);
            if (state == null) return;
            state.Heat = Clamp01(state.Heat + delta);
        }

        /// <summary>
        /// Marks a drop as no longer occupied (free for reuse).
        /// </summary>
        public static void ReleaseDrop(string dropGuid)
        {
            var state = GetState(dropGuid);
            if (state != null) state.IsOccupied = false;
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

    /// <summary>
    /// Result of evaluating a dead drop delivery against contract terms.
    /// </summary>
    public class DeliveryResult
    {
        public int ActualQuantity;
        public int HighestQuality;     // -1 if no matching product found
        public float PaymentMultiplier; // 0.0 = no pay, 1.0 = full pay, >1.0 = bonus
        public string Outcome;         // "success"/"partial"/"no_delivery"/"wrong_product"
    }
}