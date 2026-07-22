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
        /// Called from Contract.onComplete UnityEvent (subscribed by ModEntry.SubscribeToContractEvents).
        /// Fires when an individual contract completes successfully. The contract reference is still
        /// alive at this point so we can read its final payment, product list, and customer.
        /// </summary>
        public void OnContractComplete(Il2CppScheduleOne.Quests.Contract contract, string customerGuid)
        {
            try
            {
                if (!IsInitialized || !ScalingEnabled) return;
                if (!IsHost()) return;
                if (contract == null) return;

                string tag = "cust=" + DebugLog.Short(customerGuid);
                float payment = 0f;
                int qty = 0;
                try { payment = contract.Payment; } catch { }
                try { qty = contract.ProductList?.GetTotalQuantity() ?? 0; } catch { }

                DebugLog.Msg(tag,
                    $"contract.onComplete payment=${payment:F2} qty={qty}");

                // The Customer.onDealCompleted handler will record the purchase;
                // this handler is mainly observability + cross-check.
                // If Customer.onDealCompleted doesn't fire (edge case), record here as backup.
                var profile = CustomerProfileManager.GetOrCreateProfile(customerGuid);
                if (profile != null && profile.LifetimeDeals == 0)
                {
                    // Backup: no prior recording happened
                    int currentDay = 0;
                    try { currentDay = Il2CppScheduleOne.GameTime.TimeManager.Instance.ElapsedDays; }
                    catch { }
                    profile.RecordPurchase(currentDay, profile.LastRequestedDrugType ?? "", qty, payment);
                    profile.RecordSuccess();
                    DebugLog.Msg(tag, $"BACKUP recording (Customer.onDealCompleted didn't fire)");
                    SaveManager.Save();
                }
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] OnContractComplete error: {ex.Message}");
            }
        }

        /// <summary>
        /// Called from Contract.onQuestEnd UnityEvent with the final state.
        /// Captures failures and expirations for relationship tracking + dead drop cleanup.
        /// </summary>
        public void OnContractEnded(Il2CppScheduleOne.Quests.Contract contract, string customerGuid,
            Il2CppScheduleOne.Quests.EQuestState state)
        {
            try
            {
                if (!IsInitialized || !ScalingEnabled) return;
                if (!IsHost()) return;

                string tag = "cust=" + DebugLog.Short(customerGuid);
                DebugLog.Msg(tag, $"contract ended state={state}");

                // Only act on failure paths — success is handled by onComplete / onDealCompleted
                if (state == Il2CppScheduleOne.Quests.EQuestState.Completed) return;

                var profile = CustomerProfileManager.GetOrCreateProfile(customerGuid);
                if (profile == null) return;

                int currentDay = 0;
                try { currentDay = Il2CppScheduleOne.GameTime.TimeManager.Instance.ElapsedDays; }
                catch { }

                // Check if this contract was tied to an active dead drop deal.
                // Contract exposes DeliveryLocation (a MonoBehaviour) — read its GUID.
                // If the contract is a dead drop, the DeliveryLocation will be the DeadDrop's storage.
                string deliveryGuid = null;
                try { deliveryGuid = contract?.DeliveryLocation?.GUID.ToString(); } catch { }

                var deals = SaveManager.Data?.ActiveDeadDropDeals;
                if (deals != null && !string.IsNullOrEmpty(deliveryGuid))
                {
                    for (int i = 0; i < deals.Count; i++)
                    {
                        var deal = deals[i];
                        if (deal == null || deal.IsResolved) continue;
                        if (deal.CustomerGuid != customerGuid) continue;
                        if (deal.DropGuid != deliveryGuid) continue;

                        // Mark the dead drop deal as failed
                        deal.IsResolved = true;
                        deal.Result = state == Il2CppScheduleOne.Quests.EQuestState.Expired ? "expired" : "failed";
                        deal.ResolvedDay = currentDay;
                        profile.LastDeadDropFailDay = currentDay;
                        DeadDropManager.ReleaseDrop(deal.DropGuid);
                        DebugLog.Msg(tag,
                            $"dead drop deal {deal.DealId} marked {deal.Result} via contract.onQuestEnd");
                        SaveManager.Save();
                        break;
                    }
                }
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] OnContractEnded error: {ex.Message}");
            }
        }

        /// <summary>
        /// Called from Customer.onDealCompleted UnityEvent (subscribed by ModEntry).
        ///
        /// PRIMARY completion hook. The contract may already be cleaned up by this point,
        /// so we use the cached LastRequestedQuantity/LastRequestedDrugType on the profile
        /// (populated by OnCustomerContractAssigned) for the deal record.
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
                DebugLog.Msg(tag, "OnCustomerDealCompleted (UnityEvent)");

                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null) return;

                int currentDay = 0;
                try { currentDay = Il2CppScheduleOne.GameTime.TimeManager.Instance.ElapsedDays; }
                catch { }

                // Try to read live contract data first (may still be available)
                float payment = 0f;
                int qty = profile.LastRequestedQuantity > 0 ? profile.LastRequestedQuantity : 1;
                try
                {
                    var contract = customer.CurrentContract;
                    if (contract != null)
                    {
                        payment = contract.Payment;
                        var pl = contract.ProductList;
                        if (pl != null)
                        {
                            int liveQty = pl.GetTotalQuantity();
                            if (liveQty > 0) qty = liveQty;
                        }
                    }
                }
                catch { }

                // Cache addiction for decay formula
                try { profile.LastKnownAddiction = customer.CurrentAddiction; } catch { }

                // Apply pending hospital-release relationship hit if any
                try { CustomerProfileManager.ApplyPendingRelationshipHit(profile, customer.NPC); }
                catch { }

                // Record the deal
                profile.RecordPurchase(currentDay, profile.LastRequestedDrugType ?? "", qty, payment);
                profile.RecordSuccess();

                // Tolerance growth (using cached expected quantity)
                try
                {
                    CustomerProfileManager.ApplyToleranceGrowth(
                        profile, qty, qty, customer.CurrentAddiction);
                }
                catch { }

                // Overdose roll (conservative — without item-level potency data, use addiction as proxy)
                try
                {
                    bool shouldRoll = qty > 0;
                    if (shouldRoll && profile.OverdoseGraceUntilDay > 0 && currentDay < profile.OverdoseGraceUntilDay)
                    {
                        DebugLog.Msg(tag, $"overdose roll skipped: grace period (until day {profile.OverdoseGraceUntilDay})");
                        shouldRoll = false;
                    }
                    if (shouldRoll)
                    {
                        float quantityFactor = profile.LastRequestedQuantity > 0
                            ? (float)qty / System.Math.Max(1, profile.LastRequestedQuantity)
                            : 1f;
                        // Use the customer's current addiction as potency proxy (no item data available here)
                        float potencyProxy = customer.CurrentAddiction;
                        float chance = EventManager.CalculateOverdoseChance(
                            profile, 0f, potencyProxy, customer.CurrentAddiction, quantityFactor);
                        float roll = UnityEngine.Random.value;
                        if (chance > 0f && roll < chance)
                        {
                            DebugLog.Msg(tag,
                                $"OVERDOSE ROLL: chance={chance:F4} roll={roll:F4} -> YES " +
                                $"(qtyFactor={quantityFactor:F2} potency_proxy={potencyProxy:F2})");
                            bool overdosed = EventManager.ResolveOverdose(profile, currentDay);
                            if (overdosed && profile.OverdoseCount >= 2)
                            {
                                try
                                {
                                    customer.NPC.RelationData.ChangeRelationship(
                                        -ConfigManager.Config.Overdose.SecondOverdoseRelationshipHit);
                                }
                                catch { }
                            }
                        }
                        else if (chance > 0f)
                        {
                            DebugLog.Msg(tag, $"overdose roll: chance={chance:F4} roll={roll:F4} -> NO");
                        }
                    }
                }
                catch { }

                DebugLog.Msg(tag,
                    $"deal completed qty={qty} payment=${payment:F2} " +
                    $"lifetime={profile.LifetimeDeals} successful={profile.SuccessfulDeals} " +
                    $"tolerance={profile.Tolerance:F3}");
                SaveManager.Save();
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] OnCustomerDealCompleted error: {ex.Message}");
            }
        }

        /// <summary>
        /// Called from Customer.onContractAssigned UnityEvent (subscribed by ModEntry).
        ///
        /// This is the PRIMARY hook now — Harmony patches on Customer methods don't bind reliably
        /// in this Il2Cpp environment (diagnostic showed prefixes=0 postfixes=0 for all of them).
        /// The UnityEvent fires from native code and bypasses Harmony entirely.
        ///
        /// Responsibilities (replaces the broken OfferContract PREFIX):
        /// 1. Cache customer GUID, drug type, base quantity on profile
        /// 2. Scale quantity: mutate contract.ProductList.entries[i].Quantity in-place
        /// 3. Scale payment: mutate contract.Payment via PricingEngine
        /// 4. Apply event order reduction
        /// 5. Dead drop interception: mutate contract.DeliveryLocation when eligible
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
                DebugLog.Msg(tag, "OnCustomerContractAssigned (UnityEvent)");

                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null) return;

                // Skip scaling for hospitalized/refusing customers
                int currentDay = 0;
                try { currentDay = Il2CppScheduleOne.GameTime.TimeManager.Instance.ElapsedDays; }
                catch { }
                if (currentDay > 0 && !CustomerProfileManager.IsCustomerAvailable(profile, currentDay))
                {
                    string reason = profile.IsHospitalized ? "hospitalized" : "in refusal window";
                    DebugLog.Msg(tag, $"skipped: {reason} (release_day={profile.HospitalReleaseDay})");
                    return;
                }

                // Extract base quantity and drug type from the contract
                int baseQuantity = 1;
                string drugType = "";
                try
                {
                    if (contract.ProductList?.entries != null && contract.ProductList.entries.Count > 0)
                    {
                        baseQuantity = contract.ProductList.GetTotalQuantity();
                        if (baseQuantity <= 0) baseQuantity = 1;
                        drugType = contract.ProductList.entries[0].ProductID ?? "";
                        profile.LastRequestedDrugType = drugType;
                        profile.LastRequestedQuantity = baseQuantity;
                    }
                }
                catch { }

                // Cache addiction for tolerance decay formula
                try { profile.LastKnownAddiction = customer.CurrentAddiction; } catch { }

                float addiction = 0f;
                try { addiction = customer.CurrentAddiction; } catch { }
                float normalizedRel = 0f;
                try { normalizedRel = customer.NPC?.RelationData?.NormalizedRelationDelta ?? 0f; } catch { }

                // Compute scaled quantity
                int seed = ScalingEngine.HashToSeed(guid ?? "", currentDay);
                int scaled = ScalingEngine.CalculateScaledQuantity(
                    baseQuantity, addiction, normalizedRel, profile.Tolerance,
                    ConfigManager.Config.Scaling, seed);

                // Apply event order reduction
                string region = "";
                try { region = customer.NPC?.Region.ToString() ?? ""; } catch { }
                float reduction = EventManager.GetOrderReduction(drugType, region);
                int preEventScaled = scaled;
                scaled = System.Math.Max(1, (int)(scaled * reduction));

                // Wholesale multiplier
                bool wholesaleApplied = false;
                if (CustomerProfileManager.MeetsWholesaleRequirements(profile) &&
                    normalizedRel >= ConfigManager.Config.Wholesale.MinRelationship)
                {
                    scaled = (int)(scaled * ConfigManager.Config.Wholesale.BulkOrderMultiplier);
                    wholesaleApplied = true;
                    if (!profile.IsWholesale)
                    {
                        profile.IsWholesale = true;
                        profile.WholesaleWeeksActive = 0;
                        DebugLog.Msg(tag, "WHOLESALE first-time activation");
                        try { SaveManager.Save(); } catch { }
                    }
                }

                // MUTATE the contract's ProductList in-place (scale each entry proportionally)
                if (scaled != baseQuantity && contract.ProductList?.entries != null)
                {
                    try
                    {
                        float ratio = (float)scaled / baseQuantity;
                        for (int i = 0; i < contract.ProductList.entries.Count; i++)
                        {
                            var entry = contract.ProductList.entries[i];
                            if (entry == null) continue;
                            int orig = entry.Quantity;
                            int newQty = System.Math.Max(1, (int)System.Math.Round(orig * ratio));
                            entry.Quantity = newQty;
                        }
                    }
                    catch (System.Exception ex)
                    {
                        DebugLog.Warn(tag, $"ProductList mutation failed: {ex.Message}");
                    }
                }

                // Scale the payment via PricingEngine
                float basePayment = contract.Payment;
                float finalPayment = basePayment;
                try
                {
                    finalPayment = PricingEngine.CalculateCustomerPrice(
                        basePayment,
                        addiction,
                        profile.SuccessfulDeals,
                        ConfigManager.Config.Pricing,
                        SaveManager.Data.ActiveEvents,
                        drugType,
                        ConfigManager.Config.Events.ShortagePriceIncrease);
                    finalPayment = (float)System.Math.Round(finalPayment, 2);
                    contract.Payment = finalPayment;
                }
                catch (System.Exception ex)
                {
                    DebugLog.Warn(tag, $"pricing failed: {ex.Message}");
                    finalPayment = basePayment;
                }

                // Full breakdown log
                DebugLog.Msg(tag,
                    $"contract scaled product={drugType} base_qty={baseQuantity} " +
                    $"addiction={addiction:F2} rel={normalizedRel:F2} tol={profile.Tolerance:F2} " +
                    $"seed={seed} pre_event={preEventScaled} event_reduction={reduction:F2} " +
                    $"wholesale={(wholesaleApplied ? "YES" : "NO")} -> scaled={scaled} " +
                    $"payment=${finalPayment:F2} (base=${basePayment:F2})");

                // Save the profile state
                try { SaveManager.Save(); } catch { }
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
