using System;
using System.Collections.Generic;
using MelonLoader;
using DynamicOrdersMod.Models;
using DynamicOrdersMod.Persistence;
using DynamicOrdersMod.UI;

namespace DynamicOrdersMod.Systems
{
    public static class EventManager
    {
        private static readonly Random _rng = new Random();

        /// <summary>
        /// Roll daily events. Called from OnDayEnd. Host only.
        /// </summary>
        public static void RollDailyEvents(int currentDay)
        {
            if (SaveManager.Data == null) return;
            var config = ConfigManager.Config.Events;

            // Remove expired events
            RemoveExpiredEvents(currentDay);

            // Roll for new events (weekly chance = daily chance / 7)
            float dailyCrackdown = config.PoliceCrackdownChancePerWeek / 7f;
            float dailyShortage = config.SupplyShortageChancePerWeek / 7f;

            if (RngNext() < dailyCrackdown)
            {
                int duration = RngRange(config.CrackdownDurationDays.Min, config.CrackdownDurationDays.Max);
                // Pick a random region — use empty string for "all regions"
                string[] regions = { "Downtown", "Uptown", "Suburbs", "Industrial", "" };
                string region = regions[_rng.Next(regions.Length)];

                SaveManager.Data.ActiveEvents.Add(new ActiveEvent
                {
                    Type = ActiveEventType.PoliceCrackdown,
                    StartDay = currentDay,
                    EndDay = currentDay + duration,
                    Region = region,
                    DrugType = null
                });

                NotificationHelper.Send("Police Crackdown",
                    $"Police activity increased{(region.Length > 0 ? " in " + region : "")}! Dead drop risk is higher.",
                    8f);
            }

            if (RngNext() < dailyShortage)
            {
                int duration = RngRange(config.ShortageDurationDays.Min, config.ShortageDurationDays.Max);
                // Pick a random drug type — use empty string for "all drugs"
                string[] drugTypes = { "Weed", "Cocaine", "Meth", "Heroin", "" };
                string drugType = drugTypes[_rng.Next(drugTypes.Length)];

                SaveManager.Data.ActiveEvents.Add(new ActiveEvent
                {
                    Type = ActiveEventType.SupplyShortage,
                    StartDay = currentDay,
                    EndDay = currentDay + duration,
                    Region = null,
                    DrugType = drugType
                });

                NotificationHelper.Send("Supply Shortage",
                    $"Supply shortage{(drugType.Length > 0 ? " of " + drugType : "")}! Prices may increase.",
                    8f);
            }
        }

        /// <summary>
        /// Check if a police crackdown is active in a region.
        /// </summary>
        public static bool IsCrackdownActive(string region)
        {
            if (SaveManager.Data?.ActiveEvents == null) return false;
            for (int i = 0; i < SaveManager.Data.ActiveEvents.Count; i++)
            {
                var evt = SaveManager.Data.ActiveEvents[i];
                if (evt.Type != ActiveEventType.PoliceCrackdown) continue;
                // Empty region means all regions
                if (string.IsNullOrEmpty(evt.Region) || evt.Region == region) return true;
            }
            return false;
        }

        /// <summary>
        /// Check if a supply shortage is active for a drug type.
        /// </summary>
        public static bool IsShortageActive(string drugType)
        {
            if (SaveManager.Data?.ActiveEvents == null) return false;
            for (int i = 0; i < SaveManager.Data.ActiveEvents.Count; i++)
            {
                var evt = SaveManager.Data.ActiveEvents[i];
                if (evt.Type != ActiveEventType.SupplyShortage) continue;
                if (string.IsNullOrEmpty(evt.DrugType) || evt.DrugType == drugType) return true;
            }
            return false;
        }

        /// <summary>
        /// Returns a 0.0-1.0 multiplier for order reduction due to active events.
        /// 1.0 = no reduction, 0.5 = 50% reduction.
        /// </summary>
        public static float GetOrderReduction(string drugType, string region)
        {
            float reduction = 0f;
            var config = ConfigManager.Config.Events;

            if (IsCrackdownActive(region))
                reduction += config.CrackdownOrderReduction;

            if (IsShortageActive(drugType))
                reduction += config.ShortageOrderReduction;

            return 1f - Math.Min(reduction, 0.9f); // cap at 90% reduction
        }

        /// <summary>
        /// Calculate overdose chance for a delivery.
        /// </summary>
        public static float CalculateOverdoseChance(
            CustomerProfile profile, float qualityDiff, float mixIntensity,
            float addiction, float dependenceMultiplier)
        {
            if (profile == null) return 0f;
            var config = ConfigManager.Config.Overdose;

            // Base chance scaled by addiction and tolerance
            float chance = config.BaseChance * addiction;

            // Quality matters: negative qualityDiff (low quality) increases risk
            if (qualityDiff < 0f)
                chance += Math.Abs(qualityDiff) * 0.01f;

            // Mix intensity (1.0 = pure, higher = more cut) — lower mix = less risk
            chance *= mixIntensity;

            // Tolerance reduces risk
            chance *= (1f - profile.Tolerance * 0.5f);

            // Overdose history increases risk
            chance *= (1f + profile.OverdoseCount * 0.3f);

            // Clamp to max
            if (chance > config.MaxChance) chance = config.MaxChance;

            return chance;
        }

        /// <summary>
        /// Resolve an overdose. Returns true if overdose occurred.
        /// </summary>
        public static bool ResolveOverdose(CustomerProfile profile, int currentDay)
        {
            if (profile == null) return false;
            var config = ConfigManager.Config.Overdose;

            profile.OverdoseCount++;
            SaveManager.Data.Statistics.TotalOverdoses++;

            // Hospitalization
            profile.IsHospitalized = true;
            int hospDays = RngRange(config.HospitalizationDays.Min, config.HospitalizationDays.Max);
            profile.HospitalReleaseDay = currentDay + hospDays;

            // Relationship consequences on release (applied at release time in CustomerProfileManager)
            // Track for severity-based hits
            if (profile.OverdoseCount == 1)
            {
                // First overdose: mild
                NotificationHelper.Send("Customer Hospitalized",
                    "A customer has been hospitalized after an overdose. They'll be back in a few days.",
                    10f);
            }
            else if (profile.OverdoseCount == 2)
            {
                // Second overdose: customer refuses to buy for a while
                profile.LastOverdoseRefusalDay = currentDay + config.SecondOverdoseRefusalDays;
                NotificationHelper.Send("Customer Hospitalized",
                    "A customer has been hospitalized again. They may be hesitant to return.",
                    10f);
            }
            else if (config.ThirdOverdosePermanentRefusal)
            {
                // Third+ overdose: permanent refusal
                profile.LastOverdoseRefusalDay = int.MaxValue;
                NotificationHelper.Send("Customer Lost",
                    "A customer has been hospitalized for a third time and won't be returning.",
                    15f);
            }

            return true;
        }

        // --- Helpers ---

        private static void RemoveExpiredEvents(int currentDay)
        {
            if (SaveManager.Data?.ActiveEvents == null) return;
            SaveManager.Data.ActiveEvents.RemoveAll(e => currentDay > e.EndDay);
        }

        private static float RngNext()
        {
            return (float)_rng.NextDouble();
        }

        private static int RngRange(int min, int max)
        {
            return _rng.Next(min, max + 1);
        }
    }
}