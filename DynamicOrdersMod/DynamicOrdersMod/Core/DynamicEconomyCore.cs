using System;
using System.Collections.Generic;
using MelonLoader;
using DynamicOrdersMod.Models;
using DynamicOrdersMod.Persistence;
using DynamicOrdersMod.Systems;
using DynamicOrdersMod.UI;

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
                DebugLog.Msg("day=" + currentDay, "OnDayEnd fired");
                ConfigManager.Reload();
                DeadDropManager.InitializeDeadDropStates();
                CustomerProfileManager.ApplyDailyDecay(currentDay);
                DeadDropManager.UpdateHeat();
                DeadDropManager.UpdateMapLabels();
                EventManager.RollDailyEvents(currentDay);
                ResolveDeadDropDeals(currentDay);
                ProcessWeeklyWholesale(currentDay);
                SaveManager.Save();
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] OnDayEnd error: {ex.Message}");
            }
        }

        /// <summary>
        /// Delegate target for TimeManager.onSleepEnd subscription.
        /// Called by ModEntry.OnUpdate's subscriber after the sleep coroutine completes.
        /// Reads the CURRENT (post-rollover) ElapsedDays and forwards to OnDayEnd.
        ///
        /// Why this exists: StartSleep fires when sleep BEGINS (before day increments),
        /// so processing day-end there runs against stale state. onSleepEnd fires AFTER
        /// the day rolls over, giving us the correct current day for decay/events/deals.
        /// </summary>
        public void OnTimeSleepEnd()
        {
            try
            {
                int currentDay = 0;
                try { currentDay = Il2CppScheduleOne.GameTime.TimeManager.Instance.ElapsedDays; }
                catch { }
                OnDayEnd(currentDay);
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] OnTimeSleepEnd error: {ex.Message}");
            }
        }

        /// <summary>
        /// Called from Customer.onDealCompleted UnityEvent (subscribed by ModEntry).
        /// This is a FALLBACK for when the Harmony patch on Contract.Complete doesn't bind.
        /// </summary>
        public void OnCustomerDealCompleted(Il2CppScheduleOne.Economy.Customer customer)
        {
            try
            {
                if (!IsInitialized || !ScalingEnabled) return;
                if (!IsHost()) return;
                if (customer == null) return;

                string guid = null;
                try { guid = customer.NPC?.GUID.ToString(); } catch { }
                string tag = "cust=" + DebugLog.Short(guid);
                DebugLog.Msg(tag, "OnCustomerDealCompleted (UnityEvent fallback)");

                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null) return;

                int currentDay = 0;
                try { currentDay = Il2CppScheduleOne.GameTime.TimeManager.Instance.ElapsedDays; }
                catch { }

                // Without item details, record a basic success. The Harmony patches
                // will have already handled the detailed tracking if they bound.
                float payment = 0f;
                int qty = 1;
                try
                {
                    var contract = customer.CurrentContract;
                    if (contract != null)
                    {
                        payment = contract.Payment;
                        qty = contract.ProductList?.GetTotalQuantity() ?? 1;
                    }
                }
                catch { }

                profile.RecordPurchase(currentDay, profile.LastRequestedDrugType ?? "", qty, payment);
                profile.RecordSuccess();
                DebugLog.Msg(tag, $"FALLBACK recorded purchase qty={qty} payment=${payment:F2} lifetime={profile.LifetimeDeals}");
                SaveManager.Save();
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] OnCustomerDealCompleted error: {ex.Message}");
            }
        }

        /// <summary>
        /// Called from Customer.onContractAssigned UnityEvent (subscribed by ModEntry).
        /// This is a FALLBACK for when the Harmony patch on OfferContract doesn't bind.
        /// </summary>
        public void OnCustomerContractAssigned(
            Il2CppScheduleOne.Economy.Customer customer,
            Il2CppScheduleOne.Quests.Contract contract)
        {
            try
            {
                if (!IsInitialized || !ScalingEnabled) return;
                if (!IsHost()) return;
                if (customer == null || contract == null) return;

                string guid = null;
                try { guid = customer.NPC?.GUID.ToString(); } catch { }
                string tag = "cust=" + DebugLog.Short(guid);
                DebugLog.Msg(tag, "OnCustomerContractAssigned (UnityEvent fallback)");

                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null) return;

                // Cache basic contract info on the profile for later patches
                try
                {
                    var qty = contract.ProductList?.GetTotalQuantity() ?? 0;
                    if (qty > 0) profile.LastRequestedQuantity = qty;
                    var entry = contract.ProductList?.entries;
                    if (entry != null && entry.Count > 0)
                        profile.LastRequestedDrugType = entry[0].ProductID ?? "";
                }
                catch { }

                DebugLog.Msg(tag,
                    $"FALLBACK contract assigned payment=${contract.Payment:F2} " +
                    $"qty={profile.LastRequestedQuantity}");
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] OnCustomerContractAssigned error: {ex.Message}");
            }
        }

        /// <summary>
        /// Called from SaveManagerPatches when the game writes its own save file.
        /// Mirrors the same write to the mod's saveData.json so the two never drift.
        /// Host-only: clients receive their state from the host, so they skip the write.
        /// </summary>
        public void OnGameSave()
        {
            if (!IsInitialized) return;
            if (!IsHost()) return;
            try { SaveManager.Save(); }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] OnGameSave error: {ex.Message}");
            }
        }

        /// <summary>
        /// Resolves all dead drop deals whose window has passed.
        /// Reads actual storage contents, computes proportional payment with quality bargain,
        /// applies relationship changes, and handles all edge cases.
        /// Host-authoritative.
        /// </summary>
        public void ResolveDeadDropDeals(int currentDay)
        {
            var deals = SaveManager.Data?.ActiveDeadDropDeals;
            if (deals == null || deals.Count == 0) return;

            DebugLog.Msg("day=" + currentDay, $"resolving dead drop deals: total={deals.Count}");
            var ddConfig = ConfigManager.Config.DeadDrop;
            var toRemove = new List<DeadDropDeal>();

            for (int i = 0; i < deals.Count; i++)
            {
                var deal = deals[i];
                if (deal == null || deal.IsResolved) continue;
                if (currentDay < deal.WindowDay)
                {
                    DebugLog.Msg("deal=" + deal.DealId,
                        $"skipped: window not yet (window_day={deal.WindowDay}, today={currentDay})");
                    continue;
                }

                try
                {
                    ResolveSingleDeal(deal, currentDay, ddConfig);
                }
                catch (System.Exception ex)
                {
                    MelonLogger.Error($"[DynamicOrdersMod] Deal {deal.DealId} resolution error: {ex.Message}");
                    deal.IsResolved = true;
                    deal.Result = "error";
                }

                // Keep resolved deals for 7 days for history, then remove
                if (deal.IsResolved && currentDay - deal.ResolvedDay > 7)
                    toRemove.Add(deal);
            }

            // Clean up old resolved deals
            if (toRemove.Count > 0)
            {
                foreach (var d in toRemove) deals.Remove(d);
            }
        }

        private void ResolveSingleDeal(DeadDropDeal deal, int currentDay, DeadDropConfig ddConfig)
        {
            deal.ResolvedDay = currentDay;
            var profile = CustomerProfileManager.GetOrCreateProfile(deal.CustomerGuid);

            // Evaluate what was actually delivered
            var delivery = DeadDropManager.EvaluateDelivery(
                deal.DropGuid, deal.ExpectedProductID, deal.ExpectedQuality,
                deal.ExpectedQuantity, deal.Payment);

            // Get drop state for heat/crackdown calculations
            var dropState = DeadDropManager.GetDropHeat(deal.DropGuid);
            string region = "";
            try
            {
                var states = SaveManager.Data.DeadDropStates;
                if (states != null && states.ContainsKey(deal.DropGuid))
                    region = states[deal.DropGuid].Region;
            }
            catch { }

            float actualPayment = 0f;
            float relationshipChange = 0f;
            string resultOutcome;

            // Determine outcome based on delivery evaluation
            if (delivery.Outcome == "no_delivery" || delivery.Outcome == "wrong_product")
            {
                // Nothing delivered or wrong product
                resultOutcome = delivery.Outcome;
                actualPayment = 0f;

                if (deal.IsPrepaid)
                {
                    // Prepaid: customer already paid, player skipped delivery.
                    // Penalty: relationship hit + cooldown (future dead drops less likely).
                    relationshipChange = -0.15f;
                    if (profile != null) profile.LastDeadDropFailDay = currentDay;
                    NotificationHelper.Send("Dead Drop Missed",
                        $"You didn't deliver to the dead drop. Customer is unhappy.", 8f);
                }
                else
                {
                    // Async: customer didn't get goods, no payment. Mild relationship hit.
                    relationshipChange = -0.1f;
                    if (profile != null) profile.LastDeadDropFailDay = currentDay;
                    NotificationHelper.Send("Dead Drop Expired",
                        $"Deal expired without delivery. No payment received.", 8f);
                }

                SaveManager.Data.Statistics.TotalDeadDropsFailed++;
                if (profile != null) profile.RecordFailure();
            }
            else
            {
                // Something was delivered (success or partial) — now roll for events
                // Police intercept: base * (1 + heat) * crackdown multiplier
                float crackdownMult = 1f;
                try
                {
                    if (EventManager.IsCrackdownActive(region))
                        crackdownMult = ConfigManager.Config.Events.CrackdownDeadDropRiskMultiplier;
                }
                catch { }

                float policeChance = ddConfig.PoliceInterceptBaseChance * (1f + dropState) * crackdownMult;
                bool policeIntercept = UnityEngine.Random.value < policeChance;

                bool theft = false;
                bool nonPayment = false;

                if (!policeIntercept)
                {
                    theft = UnityEngine.Random.value < ddConfig.TheftChance;
                    if (!theft && !deal.IsPrepaid)
                        nonPayment = UnityEngine.Random.value < ddConfig.NonPaymentChance;
                }

                if (policeIntercept)
                {
                    resultOutcome = "police";
                    actualPayment = 0f;
                    relationshipChange = -0.2f;
                    DeadDropManager.AddHeat(deal.DropGuid, 0.5f);
                    SaveManager.Data.Statistics.TotalDeadDropsFailed++;
                    if (profile != null) profile.RecordFailure();
                    NotificationHelper.Send("Police Intercept!",
                        $"Police intercepted the dead drop delivery. Product and payment lost.", 10f);
                }
                else if (theft)
                {
                    resultOutcome = "theft";
                    actualPayment = 0f;
                    relationshipChange = -0.1f;
                    DeadDropManager.AddHeat(deal.DropGuid, 0.3f);
                    SaveManager.Data.Statistics.TotalDeadDropsFailed++;
                    if (profile != null) profile.RecordFailure();
                    NotificationHelper.Send("Dead Drop Robbed",
                        $"Someone stole the product from the dead drop. Payment lost.", 10f);
                }
                else if (nonPayment)
                {
                    // Async only: customer refuses to pay
                    resultOutcome = "nonpayment";
                    actualPayment = 0f;
                    relationshipChange = -0.15f;
                    SaveManager.Data.Statistics.TotalDeadDropsFailed++;
                    if (profile != null) profile.RecordFailure();
                    if (profile != null) profile.LastDeadDropFailDay = currentDay;
                    NotificationHelper.Send("Customer Skipped Town",
                        $"Customer didn't show up to pay for the dead drop delivery.", 10f);
                }
                else
                {
                    // Success or partial delivery
                    resultOutcome = delivery.Outcome;
                    actualPayment = deal.Payment * delivery.PaymentMultiplier;
                    actualPayment = (float)Math.Round(actualPayment, 2);

                    if (delivery.Outcome == "success")
                    {
                        relationshipChange = ddConfig.SuccessRelationshipBonus;
                        DeadDropManager.AddHeat(deal.DropGuid, -0.1f);
                        SaveManager.Data.Statistics.TotalDeadDropsCompleted++;
                        if (profile != null) profile.RecordSuccess();
                    }
                    else // partial
                    {
                        // Customer got less than expected — small relationship hit
                        relationshipChange = -0.05f;
                        DeadDropManager.AddHeat(deal.DropGuid, -0.05f);
                        SaveManager.Data.Statistics.TotalDeadDropsCompleted++;
                        if (profile != null) profile.RecordSuccess();
                        NotificationHelper.Send("Dead Drop Partial",
                            $"Partial delivery: ${actualPayment:F2} paid for {delivery.ActualQuantity}/{deal.ExpectedQuantity} units.", 8f);
                    }

                    // For prepaid: payment already deposited at creation.
                    // For async: deposit payment now (minus what customer already committed).
                    if (!deal.IsPrepaid && actualPayment > 0f)
                    {
                        try
                        {
                            var mm = Il2CppScheduleOne.Money.MoneyManager.Instance;
                            if (mm != null)
                                mm.ChangeCashBalance(actualPayment, true, true);
                        }
                        catch (Exception ex)
                        {
                            MelonLogger.Warning($"[DynamicOrdersMod] Payment deposit failed: {ex.Message}");
                        }
                    }
                    // For prepaid with partial: no additional payment (already got full upfront)
                    // The relationshipChange already reflects the customer's dissatisfaction
                }
            }

            // Clear the dead drop storage (items consumed either way)
            DeadDropManager.ClearDropStorage(deal.DropGuid);

            // Apply relationship change
            if (relationshipChange != 0f && profile != null)
            {
                try
                {
                    // Find the NPC and apply relationship change
                    var customers = Il2CppScheduleOne.Economy.Customer.UnlockedCustomers;
                    if (customers != null)
                    {
                        for (int i = 0; i < customers.Count; i++)
                        {
                            var cust = customers[i];
                            if (cust == null) continue;
                            string guid = null;
                            try { guid = cust.NPC?.GUID.ToString(); } catch { }
                            if (guid == deal.CustomerGuid)
                            {
                                cust.NPC.RelationData.ChangeRelationship(relationshipChange);
                                break;
                            }
                        }
                    }
                }
                catch { }
            }

            // Free up the drop for reuse
            DeadDropManager.ReleaseDrop(deal.DropGuid);

            // Mark deal resolved
            deal.IsResolved = true;
            deal.Result = resultOutcome;
            deal.ActualPayment = actualPayment;

            // Clear profile's active dead drop pointer if it matches
            if (profile != null && profile.ActiveDeadDropGuid == deal.DropGuid)
            {
                profile.ActiveDeadDropGuid = null;
                profile.ActiveDeadDropPendingCompletion = false;
            }

            DebugLog.Msg("deal=" + deal.DealId,
                $"resolved outcome={resultOutcome} payment=${actualPayment:F2} " +
                $"rel_delta={relationshipChange:F3} prepaid={deal.IsPrepaid} " +
                $"customer={DebugLog.Short(deal.CustomerGuid)}");
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
                int processed = 0;
                foreach (var profile in SaveManager.Data.CustomerProfiles.Values)
                {
                    if (!profile.IsWholesale) continue;
                    if (!CustomerProfileManager.IsCustomerAvailable(profile, currentDay))
                    {
                        DebugLog.Msg("week=" + (currentDay / 7),
                            $"wholesale skipped {DebugLog.Short(profile.CustomerGuid)}: not available");
                        continue;
                    }

                    profile.WholesaleWeeksActive++;

                    float baseRevenue = 100f * profile.Tolerance;
                    float cut = baseRevenue * config.WeeklyRevenueCut;
                    totalRevenue += cut;
                    processed++;

                    DebugLog.Msg("cust=" + DebugLog.Short(profile.CustomerGuid),
                        $"wholesale week={profile.WholesaleWeeksActive} " +
                        $"base=${baseRevenue:F2} cut=${cut:F2} (tolerance={profile.Tolerance:F2})");

                    SaveManager.Data.WholesaleRecords.Add(new WholesaleRecord
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
                            moneyManager.ChangeCashBalance((float)Math.Round(totalRevenue, 2), false, false);
                    }
                    catch (System.Exception ex)
                    {
                        MelonLogger.Warning($"[DynamicOrdersMod] Wholesale revenue deposit failed: {ex.Message}");
                    }

                    SaveManager.Data.Statistics.TotalWholesaleRevenue += totalRevenue;

                    DebugLog.Msg("week=" + (currentDay / 7),
                        $"wholesale processed={processed} total_revenue=${totalRevenue:F2} " +
                        $"cumulative=${SaveManager.Data.Statistics.TotalWholesaleRevenue:F2}");
                }
                else
                {
                    DebugLog.Msg("week=" + (currentDay / 7),
                        $"wholesale processed=0 total_revenue=$0.00 (no wholesale customers)");
                }

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
