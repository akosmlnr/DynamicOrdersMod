using System;
using MelonLoader;
using DynamicOrdersMod.Models;
using DynamicOrdersMod.Persistence;

namespace DynamicOrdersMod.Systems
{
    public static class CustomerProfileManager
    {
        public static CustomerProfile GetOrCreateProfile(string customerGuid)
        {
            if (SaveManager.Data == null) return null;
            if (string.IsNullOrEmpty(customerGuid)) return null;

            CustomerProfile profile;
            if (SaveManager.Data.CustomerProfiles.TryGetValue(customerGuid, out profile))
                return profile;

            profile = new CustomerProfile
            {
                CustomerGuid = customerGuid,
                Tolerance = 0f, ScalingMultiplier = 1f,
                LifetimeDeals = 0, SuccessfulDeals = 0, FailedDeals = 0,
                IsWholesale = false, WholesaleWeeksActive = 0,
                OverdoseCount = 0, LastOverdoseDay = -1,
                IsHospitalized = false, HospitalReleaseDay = -1,
                LastOverdoseRefusalDay = -1, LastDeadDropFailDay = -1
            };
            SaveManager.Data.CustomerProfiles[customerGuid] = profile;
            return profile;
        }

        public static void ApplyToleranceGrowth(
            CustomerProfile profile, int quantity, int baseQuantity, float dependenceMultiplier)
        {
            if (profile == null || baseQuantity <= 0) return;
            float configGain = ConfigManager.Config.Tolerance.GainPerDelivery;
            float ratio = (float)quantity / baseQuantity;
            if (ratio <= 1f) return;
            float gain = (ratio - 1f) * configGain * dependenceMultiplier;
            profile.Tolerance = Clamp(profile.Tolerance + gain);
        }

        public static float ModifyAddictionDelta(CustomerProfile profile, float originalDelta)
        {
            if (profile == null || originalDelta <= 0f) return originalDelta;
            float modifier = 1f - profile.Tolerance * 0.5f;
            return originalDelta * modifier;
        }

        public static void ApplyDailyDecay(int currentDay)
        {
            if (SaveManager.Data == null) return;
            float decayBase = ConfigManager.Config.Tolerance.DailyDecayBase;

            foreach (var profile in SaveManager.Data.CustomerProfiles.Values)
            {
                float decay = decayBase;
                if (decay > 0f && profile.Tolerance > 0f)
                    profile.Tolerance = Clamp(profile.Tolerance - decay);
                UpdateHospitalization(profile, currentDay);
            }
        }

        private static void UpdateHospitalization(CustomerProfile profile, int currentDay)
        {
            if (profile.IsHospitalized && currentDay >= profile.HospitalReleaseDay)
            {
                profile.IsHospitalized = false;

                // Task 4: Apply relationship consequences on hospital release
                var config = ConfigManager.Config.Overdose;
                try
                {
                    var customers = Il2CppScheduleOne.Economy.Customer.UnlockedCustomers;
                    if (customers != null)
                    {
                        for (int i = 0; i < customers.Count; i++)
                        {
                            var cust = customers[i];
                            if (cust == null) continue;
                            string guid = null;
                            try { guid = cust.NPC?.GUID.ToString(); } catch { }
                            if (guid == profile.CustomerGuid)
                            {
                                float hit = config.HospitalRelationshipDecay + config.ReleaseRelationshipHit;
                                if (hit > 0f)
                                    cust.NPC.RelationData.ChangeRelationship(-hit);
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MelonLogger.Warning($"[DynamicOrdersMod] Hospital release relationship error: {ex.Message}");
                }

                if (ConfigManager.Config.General.DebugLogging)
                    MelonLogger.Msg($"[DynamicOrdersMod] {profile.CustomerGuid} released from hospital.");
            }
        }

        public static bool IsCustomerAvailable(CustomerProfile profile, int currentDay)
        {
            if (profile == null) return false;
            if (profile.IsHospitalized) return false;
            if (profile.LastOverdoseRefusalDay > 0 && currentDay < profile.LastOverdoseRefusalDay) return false;
            return true;
        }

        /// <summary>
        /// Checks if a customer meets wholesale criteria (excluding live relationship).
        /// Caller should check relationship separately.
        /// </summary>
        public static bool MeetsWholesaleRequirements(CustomerProfile profile)
        {
            if (profile == null) return false;
            var config = ConfigManager.Config.Wholesale;
            if (!config.Enabled) return false;
            if (profile.LifetimeDeals < config.MinCompletedDeals) return false;
            if (profile.Tolerance < config.MinTolerance) return false;
            return true;
        }

        internal static float Clamp(float v)
        {
            if (v < 0f) return 0f;
            return v > 1f ? 1f : v;
        }
    }
}