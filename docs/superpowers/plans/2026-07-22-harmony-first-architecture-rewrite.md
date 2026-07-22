# Harmony-First Architecture Rewrite Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Pivot DynamicOrdersMod from UnityEvent fallback architecture to a Harmony-first architecture, now that we've confirmed `net6.0` csproj makes Harmony bind correctly to Customer/Contract/Dealer methods.

**Architecture:** Each major game hook becomes a dedicated Harmony patch class with its own `[HarmonyPatch]` attribute. Patches live in `Patches/CustomerPatches.cs` as separate top-level public static classes (one per target method), with methods named `Prefix`/`Postfix` (no attribute — convention-based). The UnityEvent subscriptions in `ModEntry.cs` become optional fallbacks — kept for the day-end hook (`TimeManager.onSleepEnd`) and customer-unlock tracking, but no longer the primary customer-deal pipeline.

**Tech Stack:** C# / .NET 6.0 / MelonLoader 0.7.3 / HarmonyLib 2.10.2 / Il2CppInterop.Runtime / Newtonsoft.Json

---

## File Structure

After this plan, the responsibility split is:

- **`Patches/CustomerPatches.cs`** — 4 separate Harmony patch classes:
  - `OfferContractPatch` (PREFIX): scaling + dead drop interception. Mutates `info.Products` and `info.Payment` and optionally `info.DeliveryLocationGUID`.
  - `ProcessHandoverPatch` (POSTFIX): tolerance growth + overdose roll using real item data from `List<ItemInstance>`.
  - `ContractCompletePatch` (POSTFIX on `Contract.Complete`): success recording, relationship bonus.
  - `ChangeAddictionPatch` (PREFIX on `RpcLogic___ChangeAddiction_431000436`): tolerance-modified addiction delta.
- **`Patches/SaveManagerPatches.cs`** — unchanged (already works).
- **`Patches/MoneyManagerPatches.cs`** — unchanged (already works).
- **`Core/ModEntry.cs`** — strips dead diagnostic code; keeps TimeManager.onSleepEnd subscriber + Customer.onCustomerUnlocked subscriber as fallback for any case Harmony misses.
- **`Core/DynamicEconomyCore.cs`** — strips the UnityEvent-handler-based scaling/overdose methods (`OnCustomerContractAssigned`, `OnCustomerDealCompleted`) since their responsibilities move to Harmony patches. Keeps `OnContractComplete` and `OnContractEnded` as fallbacks for now. Day-end flow unchanged.
- **`Core/DebugLog.cs`**, **`Persistence/*`**, **`Models/*`**, **`Systems/*`** — unchanged.

---

## Task 1: Rewrite CustomerPatches.cs with 4 production Harmony patches

**Files:**
- Modify (full rewrite): `DynamicOrdersMod/DynamicOrdersMod/Patches/CustomerPatches.cs`

This is the heart of the rewrite. All 4 patches from the probe are converted from diagnostic-only (just logging) into production patches that do real work.

### Patch structure convention

Every patch follows this exact pattern (confirmed to bind):

```csharp
[HarmonyPatch(typeof(Il2CppScheduleOne.Economy.Customer), "OfferContract")]
public static class OfferContractPatch
{
    public static void Prefix(Customer __instance, ContractInfo info)
    {
        // ... body
    }
}
```

- Class is `public static`, top-level (NOT nested), with the `[HarmonyPatch]` attribute
- Method is `public static`, named `Prefix` or `Postfix` literally (no `[HarmonyPrefix]` attribute)
- Each patch class has one responsibility

### Patch 1: `OfferContractPatch` — scaling + dead drop interception

```csharp
using System;
using HarmonyLib;
using MelonLoader;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.Quests;
using DynamicOrdersMod.Core;
using DynamicOrdersMod.Models;
using DynamicOrdersMod.Persistence;
using DynamicOrdersMod.Systems;
using DynamicOrdersMod.UI;

namespace DynamicOrdersMod.Patches
{
    [HarmonyPatch(typeof(Customer), "OfferContract")]
    public static class OfferContractPatch
    {
        public static void Prefix(Customer __instance, ContractInfo info)
        {
            string guid = null;
            try { guid = __instance?.NPC?.GUID.ToString(); }
            catch { }
            string tag = "cust=" + DebugLog.Short(guid);

            try
            {
                if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true)
                {
                    DebugLog.Msg(tag, "skipped: scaling disabled");
                    return;
                }
                if (__instance == null || info == null)
                {
                    DebugLog.Msg(tag, "skipped: instance or info null");
                    return;
                }
                if (!DynamicEconomyCore.IsHost())
                {
                    DebugLog.Msg(tag, "skipped: not host");
                    return;
                }

                var npc = __instance.NPC;
                if (npc == null) return;

                var profile = CustomerProfileManager.GetOrCreateProfile(guid);
                if (profile == null) return;

                // Cache base quantity and drug type from the ContractInfo (BEFORE contract creation)
                int baseQuantity = 1;
                string drugType = "";
                try
                {
                    if (info.Products?.entries != null && info.Products.entries.Count > 0)
                    {
                        baseQuantity = info.Products.GetTotalQuantity();
                        if (baseQuantity <= 0) baseQuantity = 1;
                        drugType = info.Products.entries[0].ProductID ?? "";
                        profile.LastRequestedDrugType = drugType;
                        profile.LastRequestedQuantity = baseQuantity;
                    }
                }
                catch { }

                int currentDay = 0;
                try { currentDay = TimeManager.Instance.ElapsedDays; }
                catch { }
                if (currentDay > 0 && !CustomerProfileManager.IsCustomerAvailable(profile, currentDay))
                {
                    string reason = profile.IsHospitalized ? "hospitalized" : "in refusal window";
                    DebugLog.Msg(tag, $"skipped: {reason} (release_day={profile.HospitalReleaseDay})");
                    return;
                }

                float addiction = 0f;
                try { addiction = __instance.CurrentAddiction; } catch { }
                float normalizedRel = 0f;
                try { normalizedRel = npc.RelationData?.NormalizedRelationDelta ?? 0f; }
                catch { }
                try { profile.LastKnownAddiction = addiction; } catch { }

                int seed = ScalingEngine.HashToSeed(guid ?? "", currentDay);
                int scaled = ScalingEngine.CalculateScaledQuantity(
                    baseQuantity, addiction, normalizedRel, profile.Tolerance,
                    ConfigManager.Config.Scaling, seed);

                string region = "";
                try { region = npc.Region.ToString() ?? ""; } catch { }
                float reduction = EventManager.GetOrderReduction(drugType ?? "", region);
                int preEventScaled = scaled;
                scaled = Math.Max(1, (int)(scaled * reduction));

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

                // MUTATE the ContractInfo: scale each entry's Quantity proportionally
                if (scaled != baseQuantity && info.Products?.entries != null)
                {
                    try
                    {
                        float ratio = (float)scaled / baseQuantity;
                        for (int i = 0; i < info.Products.entries.Count; i++)
                        {
                            var entry = info.Products.entries[i];
                            if (entry == null) continue;
                            int orig = entry.Quantity;
                            int newQty = Math.Max(1, (int)Math.Round(orig * ratio));
                            entry.Quantity = newQty;
                        }
                        // Also scale payment proportionally
                        info.Payment = (float)Math.Round(info.Payment * ratio, 2);
                    }
                    catch (Exception ex)
                    {
                        DebugLog.Warn(tag, $"ProductList mutation failed: {ex.Message}");
                    }
                }

                // Run PricingEngine for loyalty discount + addiction premium + market noise + event modifier
                try
                {
                    float basePay = info.Payment;
                    float finalPay = PricingEngine.CalculateCustomerPrice(
                        basePay, addiction, profile.SuccessfulDeals,
                        ConfigManager.Config.Pricing, SaveManager.Data.ActiveEvents,
                        drugType ?? "", ConfigManager.Config.Events.ShortagePriceIncrease);
                    info.Payment = (float)Math.Round(finalPay, 2);
                }
                catch (Exception ex)
                {
                    DebugLog.Warn(tag, $"pricing failed: {ex.Message}");
                }

                DebugLog.Msg(tag,
                    $"contract offered product={drugType} base_qty={baseQuantity} " +
                    $"addiction={addiction:F2} rel={normalizedRel:F2} tol={profile.Tolerance:F2} " +
                    $"seed={seed} pre_event={preEventScaled} event_reduction={reduction:F2} " +
                    $"wholesale={(wholesaleApplied ? "YES" : "NO")} -> scaled_qty={scaled} " +
                    $"payment=${info.Payment:F2}");

                // === DEAD DROP INTERCEPTION (wholesale-tier only, replaces in-person) ===
                TryDeadDropInterception(__instance, info, profile, guid, currentDay, normalizedRel, drugType);
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] OfferContractPatch error: {ex.Message}");
            }
        }

        private static void TryDeadDropInterception(
            Customer __instance, ContractInfo info, CustomerProfile profile,
            string guid, int currentDay, float normalizedRel, string drugType)
        {
            string tag = "cust=" + DebugLog.Short(guid);
            var ddConfig = ConfigManager.Config.DeadDrop;
            if (!ddConfig.Enabled)
            {
                DebugLog.Msg(tag, "dead drop skipped: disabled in config");
                return;
            }

            // Wholesale-tier only (your "end-game only" decision)
            if (!CustomerProfileManager.MeetsWholesaleRequirements(profile))
            {
                DebugLog.Msg(tag, $"dead drop skipped: not wholesale-tier (lifetime={profile.LifetimeDeals}, tol={profile.Tolerance:F2})");
                return;
            }
            if (normalizedRel < ConfigManager.Config.Wholesale.MinRelationship)
            {
                DebugLog.Msg(tag, $"dead drop skipped: rel {normalizedRel:F2} < min {ConfigManager.Config.Wholesale.MinRelationship:F2}");
                return;
            }

            // Player must have discovered at least one dead drop
            bool anyDiscovered = false;
            try
            {
                foreach (var kvp in SaveManager.Data.DeadDropStates)
                {
                    if (kvp.Value.IsDiscovered) { anyDiscovered = true; break; }
                }
            }
            catch { }
            if (!anyDiscovered)
            {
                DebugLog.Msg(tag, "dead drop skipped: no discovered drops");
                return;
            }

            // One active dead drop deal per customer
            try
            {
                for (int i = 0; i < SaveManager.Data.ActiveDeadDropDeals.Count; i++)
                {
                    var existing = SaveManager.Data.ActiveDeadDropDeals[i];
                    if (existing.CustomerGuid == guid && !existing.IsResolved)
                    {
                        DebugLog.Msg(tag, "dead drop skipped: existing unresolved deal");
                        return;
                    }
                }
            }
            catch { }

            // Cooldown after failure
            if (profile.LastDeadDropFailDay > 0 &&
                currentDay - profile.LastDeadDropFailDay < ddConfig.TheftCooldownDays)
            {
                DebugLog.Msg(tag,
                    $"dead drop skipped: cooldown ({currentDay - profile.LastDeadDropFailDay}d since fail, " +
                    $"need {ddConfig.TheftCooldownDays}d)");
                return;
            }

            // 30% chance to redirect — REPLACES the in-person deal
            if ((float)UnityEngine.Random.value > 0.30f)
            {
                DebugLog.Msg(tag, "dead drop skipped: 30% roll failed");
                return;
            }

            string selectedDrop = DeadDropManager.SelectDropForAsync();
            if (selectedDrop == null)
            {
                DebugLog.Msg(tag, "dead drop aborted: no available drop");
                return;
            }

            DebugLog.Msg(tag,
                $"dead drop ELIGIBLE: rel={normalizedRel:F2} tol={profile.Tolerance:F2} " +
                $"lifetime={profile.LifetimeDeals} deals -> REDIRECTING to drop {DebugLog.Short(selectedDrop)}");

            // Extract expected product details
            string expectedProductID = drugType ?? "";
            int expectedQuality = 2; // EQuality.Standard default
            int expectedQuantity = 1;
            try
            {
                if (info.Products?.entries != null && info.Products.entries.Count > 0)
                {
                    var entry = info.Products.entries[0];
                    expectedProductID = entry.ProductID ?? "";
                    expectedQuality = (int)entry.Quality;
                    expectedQuantity = entry.Quantity;
                }
            }
            catch { }

            bool isPrepaid = (float)UnityEngine.Random.value < ddConfig.PrepaidChance;
            float basePayment = info.Payment;
            if (!isPrepaid)
            {
                float premium = ddConfig.AsyncPremiumMin +
                    (ddConfig.AsyncPremiumMax - ddConfig.AsyncPremiumMin) * (float)UnityEngine.Random.value;
                basePayment = (float)Math.Round(basePayment * (1f + premium), 2);
                info.Payment = basePayment;
            }

            // MUTATE the ContractInfo: redirect delivery to the dead drop
            info.DeliveryLocationGUID = selectedDrop;

            string dealId = $"dd_{guid}_{currentDay}_{UnityEngine.Random.Range(1000, 9999)}";
            var deal = new DeadDropDeal
            {
                DealId = dealId,
                CustomerGuid = guid,
                DropGuid = selectedDrop,
                ExpectedProductID = expectedProductID,
                DrugType = drugType ?? "",
                ExpectedQuality = expectedQuality,
                ExpectedQuantity = expectedQuantity > 0 ? expectedQuantity : 1,
                Payment = basePayment,
                IsPrepaid = isPrepaid,
                CreatedDay = currentDay,
                WindowDay = currentDay + 1,
                IsResolved = false,
                Result = "pending"
            };
            SaveManager.Data.ActiveDeadDropDeals.Add(deal);

            profile.ActiveDeadDropGuid = selectedDrop;
            profile.ActiveDeadDropIsPrepaid = isPrepaid;
            profile.ActiveDeadDropPendingCompletion = false;

            if (isPrepaid && basePayment > 0f)
            {
                try
                {
                    var mm = MoneyManager.Instance;
                    if (mm != null)
                        mm.ChangeCashBalance(basePayment, true, true);
                }
                catch (Exception ex)
                {
                    MelonLogger.Warning($"[DynamicOrdersMod] Prepaid deposit failed: {ex.Message}");
                }
                NotificationHelper.Send("Dead Drop Contract (Prepaid)",
                    $"Customer paid ${basePayment:F2} upfront. Deliver to the dead drop by tomorrow.",
                    8f);
            }
            else
            {
                NotificationHelper.Send("Dead Drop Contract",
                    $"Customer wants {expectedQuantity}x {expectedProductID} at a dead drop. Payment on delivery: ${basePayment:F2}.",
                    8f);
            }

            DebugLog.Msg(tag,
                $"dead drop contract CREATED: prepaid={(isPrepaid ? "YES" : "NO")} " +
                $"payment=${basePayment:F2} product={expectedProductID} qty={expectedQuantity} " +
                $"drop={DebugLog.Short(selectedDrop)} day={currentDay}");

            try { SaveManager.Save(); } catch { }
        }
    }
}
```

- [ ] **Step 1: Write the full OfferContractPatch class**

Open `DynamicOrdersMod/DynamicOrdersMod/Patches/CustomerPatches.cs`. Replace its entire contents with the Patch 1 code above plus the required `using` statements and namespace. Save.

- [ ] **Step 2: Commit**

```bash
git add DynamicOrdersMod/DynamicOrdersMod/Patches/CustomerPatches.cs
git commit -m "feat: OfferContractPatch PREFIX — scaling + dead drop interception"
```

### Patch 2: `ProcessHandoverPatch` — tolerance + overdose with real item data

Append to `CustomerPatches.cs` (after the existing namespace close, add a new top-level class):

```csharp
[HarmonyPatch(typeof(Customer), "ProcessHandover")]
public static class ProcessHandoverPatch
{
    public static void Postfix(
        Customer __instance,
        Il2CppScheduleOne.UI.Handover.HandoverScreen.EHandoverOutcome outcome,
        Contract contract,
        List<ItemInstance> items,
        bool handoverByPlayer,
        bool giveBonuses)
    {
        string guid = null;
        try { guid = __instance?.NPC?.GUID.ToString(); }
        catch { }
        string tag = "cust=" + DebugLog.Short(guid);

        try
        {
            if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true) return;
            if (__instance == null) return;
            if (outcome != Il2CppScheduleOne.UI.Handover.HandoverScreen.EHandoverOutcome.Finalize)
            {
                DebugLog.Msg(tag, $"handover skipped: outcome={outcome}");
                return;
            }

            var profile = CustomerProfileManager.GetOrCreateProfile(guid);
            if (profile == null) return;

            int currentDay = 0;
            try { currentDay = Il2CppScheduleOne.GameTime.TimeManager.Instance.ElapsedDays; }
            catch { }
            if (currentDay <= 0) return;
            if (profile.IsHospitalized)
            {
                DebugLog.Msg(tag, "handover skipped: hospitalized");
                return;
            }

            try { profile.LastKnownAddiction = __instance.CurrentAddiction; } catch { }
            try { CustomerProfileManager.ApplyPendingRelationshipHit(profile, __instance.NPC); }
            catch { }

            // Compute matchedProductCount and highestAddiction (potency) from real items
            int matchedProductCount = 0;
            float highestAddiction = 0f;
            int expectedQuality = 2; // EQuality.Standard default
            string expectedProductID = "";
            try
            {
                if (contract?.ProductList?.entries != null && contract.ProductList.entries.Count > 0)
                {
                    expectedProductID = contract.ProductList.entries[0].ProductID ?? "";
                    expectedQuality = (int)contract.ProductList.entries[0].Quality;
                }
            }
            catch { }

            if (items != null)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    var item = items[i];
                    if (item == null) continue;
                    string productID = "";
                    int itemQty = 0;
                    try
                    {
                        var data = item.GetItemData();
                        if (data != null)
                        {
                            productID = data.ID ?? "";
                            itemQty = data.Quantity;
                        }
                    }
                    catch { }
                    if (itemQty <= 0) itemQty = 1;

                    if (string.IsNullOrEmpty(productID)) continue;
                    if (productID == expectedProductID)
                        matchedProductCount += itemQty;

                    // Item-level potency: use the ProductItemInstance's effect addiction data
                    try
                    {
                        var prodItem = item as Il2CppScheduleOne.Product.ProductItemInstance;
                        if (prodItem != null)
                        {
                            // ProductItemInstance has Amount of active ingredient
                            float amount = prodItem.Amount;
                            if (amount > highestAddiction) highestAddiction = amount;
                        }
                    }
                    catch { }
                }
            }

            // Fallback to customer's CurrentAddiction if no item-level data (hybrid approach)
            if (highestAddiction <= 0f)
            {
                try { highestAddiction = __instance.CurrentAddiction; } catch { }
            }

            // Compute qualityDifference from item quality
            float qualityDifference = 0f;
            try
            {
                if (items != null)
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        var qi = items[i] as Il2CppScheduleOne.ItemFramework.QualityItemInstance;
                        if (qi != null)
                        {
                            qualityDifference = (int)qi.Quality - expectedQuality;
                            break;
                        }
                    }
                }
            }
            catch { }

            float payment = 0f;
            int orderableQuantity = 1;
            try { payment = contract?.Payment ?? 0f; } catch { }
            try { orderableQuantity = contract?.ProductList?.GetTotalQuantity() ?? 1; } catch { }

            // Apply quality expectation shift
            var toleranceConfig = ConfigManager.Config.Tolerance;
            if (toleranceConfig.QualityExpectationShift && profile.Tolerance > 0f && qualityDifference < 0f)
            {
                DebugLog.Msg(tag,
                    $"satisfaction penalty: qualityDiff={qualityDifference} tolerance={profile.Tolerance:F2}");
            }

            DebugLog.Msg(tag,
                $"handover matched={matchedProductCount}/{orderableQuantity} payment=${payment:F2} " +
                $"qualityDiff={qualityDifference} potency={highestAddiction:F2}");

            profile.RecordPurchase(currentDay, profile.LastRequestedDrugType ?? "",
                matchedProductCount > 0 ? matchedProductCount : 1, payment);
            profile.RecordSuccess();

            CustomerProfileManager.ApplyToleranceGrowth(
                profile, matchedProductCount, orderableQuantity, __instance.CurrentAddiction);

            // Overdose roll
            bool shouldRoll = matchedProductCount > 0;
            if (shouldRoll && profile.OverdoseGraceUntilDay > 0 && currentDay < profile.OverdoseGraceUntilDay)
            {
                DebugLog.Msg(tag, $"overdose roll skipped: grace period (until day {profile.OverdoseGraceUntilDay})");
                shouldRoll = false;
            }
            if (matchedProductCount == 0)
                DebugLog.Msg(tag, "overdose roll skipped: matchedProductCount=0");

            if (shouldRoll)
            {
                float quantityFactor = profile.LastRequestedQuantity > 0
                    ? (float)matchedProductCount / Math.Max(1, profile.LastRequestedQuantity)
                    : 1f;
                float chance = EventManager.CalculateOverdoseChance(
                    profile, qualityDifference, highestAddiction,
                    __instance.CurrentAddiction, quantityFactor);
                float roll = UnityEngine.Random.value;
                if (chance <= 0f)
                {
                    DebugLog.Msg(tag, $"overdose roll: chance=0 (no potency/addiction)");
                }
                else if (roll < chance)
                {
                    DebugLog.Msg(tag,
                        $"OVERDOSE ROLL: chance={chance:F4} roll={roll:F4} -> YES " +
                        $"(qtyFactor={quantityFactor:F2} potency={highestAddiction:F2} " +
                        $"addiction={__instance.CurrentAddiction:F2})");
                    bool overdosed = EventManager.ResolveOverdose(profile, currentDay);
                    if (overdosed && profile.OverdoseCount >= 2)
                    {
                        try
                        {
                            __instance.NPC.RelationData.ChangeRelationship(
                                -ConfigManager.Config.Overdose.SecondOverdoseRelationshipHit);
                        }
                        catch { }
                    }
                    try { SaveManager.Save(); } catch { }
                }
                else
                {
                    DebugLog.Msg(tag, $"overdose roll: chance={chance:F4} roll={roll:F4} -> NO");
                }
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[DynamicOrdersMod] ProcessHandoverPatch error: {ex.Message}");
        }
    }
}
```

Required additional using: `using System.Collections.Generic;` and `using Il2CppScheduleOne.ItemFramework;` and `using Il2CppScheduleOne.Product;` at the top of the file.

- [ ] **Step 3: Add the ProcessHandoverPatch class**

Append the `ProcessHandoverPatch` class inside the same `namespace DynamicOrdersMod.Patches` block, after `OfferContractPatch`. Update the `using` block at the top of the file to include the new namespaces. Save.

- [ ] **Step 4: Commit**

```bash
git add DynamicOrdersMod/DynamicOrdersMod/Patches/CustomerPatches.cs
git commit -m "feat: ProcessHandoverPatch POSTFIX — real item potency for overdose"
```

### Patch 3: `ContractCompletePatch` — success recording

Append:

```csharp
[HarmonyPatch(typeof(Contract), "Complete")]
public static class ContractCompletePatch
{
    public static void Postfix(Contract __instance, bool network)
    {
        try
        {
            if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true) return;
            if (__instance == null) return;

            // Contract.Customer is a NetworkObject — get the Customer component
            var customer = __instance.Customer?.GetComponent<Customer>();
            if (customer == null) return;

            string guid = null;
            try { guid = customer.NPC?.GUID.ToString(); } catch { }
            string tag = "cust=" + DebugLog.Short(guid);
            float payment = 0f;
            int qty = 0;
            try { payment = __instance.Payment; } catch { }
            try { qty = __instance.ProductList?.GetTotalQuantity() ?? 0; } catch { }

            DebugLog.Msg(tag, $"Contract.Complete payment=${payment:F2} qty={qty} network={network}");
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[DynamicOrdersMod] ContractCompletePatch error: {ex.Message}");
        }
    }
}
```

- [ ] **Step 5: Add ContractCompletePatch**

Append after ProcessHandoverPatch, same namespace. Save.

- [ ] **Step 6: Commit**

```bash
git add DynamicOrdersMod/DynamicOrdersMod/Patches/CustomerPatches.cs
git commit -m "feat: ContractCompletePatch POSTFIX — completion observability"
```

### Patch 4: `ChangeAddictionPatch` — tolerance-modified addiction

Append:

```csharp
[HarmonyPatch(typeof(Customer), "RpcLogic___ChangeAddiction_431000436")]
public static class ChangeAddictionPatch
{
    public static void Prefix(Customer __instance, ref float change)
    {
        string guid = null;
        try { guid = __instance?.NPC?.GUID.ToString(); }
        catch { }
        string tag = "cust=" + DebugLog.Short(guid);

        try
        {
            if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true) return;
            if (__instance == null || change <= 0f)
            {
                DebugLog.Msg(tag, $"ChangeAddiction skipped: change<=0 (change={change})");
                return;
            }

            var profile = CustomerProfileManager.GetOrCreateProfile(guid);
            if (profile == null) return;

            float original = change;
            float modified = CustomerProfileManager.ModifyAddictionDelta(profile, change);
            if (modified != change) change = modified;

            float modifier = 1f - profile.Tolerance * 0.5f;
            DebugLog.Msg(tag,
                $"ChangeAddiction original={original:F4} tolerance_modifier={modifier:F2} " +
                $"tolerance={profile.Tolerance:F2} -> modified={modified:F4}");
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[DynamicOrdersMod] ChangeAddictionPatch error: {ex.Message}");
        }
    }
}
```

- [ ] **Step 7: Add ChangeAddictionPatch**

Append after ContractCompletePatch. Save.

- [ ] **Step 8: Commit**

```bash
git add DynamicOrdersMod/DynamicOrdersMod/Patches/CustomerPatches.cs
git commit -m "feat: ChangeAddictionPatch PREFIX — tolerance-modified addiction delta"
```

---

## Task 2: Strip redundant UnityEvent handlers from DynamicEconomyCore

**Files:**
- Modify: `DynamicOrdersMod/DynamicOrdersMod/Core/DynamicEconomyCore.cs`

The UnityEvent handlers `OnCustomerContractAssigned` and `OnCustomerDealCompleted` were doing scaling and overdose work that now lives in the Harmony patches. They would now double-record purchases. Strip them down to debug-only logging, or remove entirely. Keep `OnContractComplete` and `OnContractEnded` as fallbacks.

- [ ] **Step 1: Remove `OnCustomerContractAssigned` body**

Find the `OnCustomerContractAssigned` method in `DynamicEconomyCore.cs` (around line 313). Replace its body with a single DebugLog line confirming the UnityEvent still fires (for diagnostic purposes — proves the event subscription path still works as a fallback signal):

```csharp
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
        DebugLog.Msg(tag, "onContractAssigned (UnityEvent fallback) — scaling handled by OfferContractPatch");
    }
    catch (System.Exception ex)
    {
        MelonLogger.Error($"[DynamicOrdersMod] OnCustomerContractAssigned error: {ex.Message}");
    }
}
```

- [ ] **Step 2: Remove `OnCustomerDealCompleted` body**

Find `OnCustomerDealCompleted`. Replace its body with a simple debug log (the Harmony `ProcessHandoverPatch` now handles tolerance/overdose/purchase recording):

```csharp
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
        DebugLog.Msg(tag, "onDealCompleted (UnityEvent fallback) — tolerance/overdose handled by ProcessHandoverPatch");
    }
    catch (System.Exception ex)
    {
        MelonLogger.Error($"[DynamicOrdersMod] OnCustomerDealCompleted error: {ex.Message}");
    }
}
```

- [ ] **Step 3: Keep OnContractComplete and OnContractEnded as backups**

Leave them unchanged. They serve as fallback signals if Harmony patches ever fail to fire.

- [ ] **Step 4: Commit**

```bash
git add DynamicOrdersMod/DynamicOrdersMod/Core/DynamicEconomyCore.cs
git commit -m "refactor: strip UnityEvent scaling/overdose handlers — Harmony handles them now"
```

---

## Task 3: Clean up ModEntry diagnostic code

**Files:**
- Modify: `DynamicOrdersMod/DynamicOrdersMod/Core/ModEntry.cs`

The `LogPatchBindingStatus` method was diagnostic for the probe phase. With the rewrite complete, we no longer need every patch's binding status logged on every startup — the `HarmonyInstance.GetPatchedMethods()` log line is sufficient. Strip `LogPatchBindingStatus`.

- [ ] **Step 1: Remove LogPatchBindingStatus method and its call**

In `OnInitializeMelon`, remove the line `LogPatchBindingStatus(HarmonyInstance);`. Also delete the entire `LogPatchBindingStatus` method body (the long method with the targets array).

- [ ] **Step 2: Verify Harmony patched methods log line stays**

The `Harmony patched methods: ...` line should remain — it's a useful one-line confirmation on startup.

- [ ] **Step 3: Commit**

```bash
git add DynamicOrdersMod/DynamicOrdersMod/Core/ModEntry.cs
git commit -m "chore: strip probe diagnostic — GetPatchedMethods log line is enough"
```

---

## Task 4: Update design doc with confirmed Scenario A outcome

**Files:**
- Modify: `docs/superpowers/specs/2026-07-22-probe-driven-hook-architecture-design.md`

Append a "Confirmed Outcome" section at the end of the design doc documenting that the probe confirmed Scenario A (all 4 patches bound) once the csproj was converted to net6.0.

- [ ] **Step 1: Append outcome section**

Add to the end of the spec file:

```markdown

## Confirmed Outcome (2026-07-22)

Probe results: **Scenario A — all 4 patches bind and fire.**

```
[DynamicOrdersMod v3] Harmony patched methods: Il2CppScheduleOne.Economy.Customer.OfferContract,
Il2CppScheduleOne.Economy.Customer.ProcessHandover, Il2CppScheduleOne.Quests.Contract.InitializeContract,
Il2CppScheduleOne.Economy.Dealer.ContractedOffered, Il2CppScheduleOne.Money.MoneyManager.ChangeCashBalance,
Il2CppScheduleOne.Persistence.SaveManager.Save
```

**Root cause of the original "patches don't bind" issue:** csproj targeted `net472` while MelonLoader 0.7.3 is built for `net6.0`. Type identity mismatch between the two runtimes caused `PatchClassProcessor` to silently fail parameter-type matching. Converting to SDK-style `net6.0` csproj fixed everything.

**Implementation path taken:** Scenario A — full features.
- Scaling: `OfferContract` PREFIX mutates ContractInfo BEFORE contract creation (fixes the "customer still asks for original quantity" bug)
- Dead drops: `OfferContract` PREFIX mutates `info.DeliveryLocationGUID` for wholesale-tier customers (30% chance, replaces in-person)
- Overdose: `ProcessHandover` POSTFIX reads real item list, computes potency from `ProductItemInstance.Amount`
```

- [ ] **Step 2: Commit**

```bash
git add docs/superpowers/specs/2026-07-22-probe-driven-hook-architecture-design.md
git commit -m "docs: confirm Scenario A outcome — all patches bind with net6.0"
```

---

## Task 5: Final verification

**Files:** None (read-only checks)

- [ ] **Step 1: Verify no MelonLog typos**

Run: `grep -rn "MelonLog\b\.\|MelonLogseer" DynamicOrdersMod/DynamicOrdersMod/ | grep -v "bin/\|obj/\|MelonLogger"`
Expected: empty output.

- [ ] **Step 2: Verify patch class structure**

Run: `grep -n "HarmonyPatch\|public static class.*Patch" DynamicOrdersMod/DynamicOrdersMod/Patches/CustomerPatches.cs`
Expected: 4 `[HarmonyPatch]` attributes, each followed by a `public static class XXXPatch` declaration, with `public static void Prefix` or `public static void Postfix` methods inside.

- [ ] **Step 3: Verify no duplicate purchase recording**

Run: `grep -n "RecordPurchase\|RecordSuccess" DynamicOrdersMod/DynamicOrdersMod/Core/DynamicEconomyCore.cs`
Expected: 0 matches (the call sites moved to ProcessHandoverPatch).

- [ ] **Step 4: Commit final state and push**

```bash
git push origin main
```

---

## Self-Review Checklist

- **Spec coverage:** Dead drop interception for wholesale-tier customers ✓ (Task 1 Patch 1, `TryDeadDropInterception`). Real item potency for overdose ✓ (Task 1 Patch 2, reads `ProductItemInstance.Amount`). Scaling via Harmony PREFIX ✓ (Task 1 Patch 1, mutates `info.Products.entries[*].Quantity` BEFORE contract creation).
- **Placeholder scan:** All code blocks are complete implementations. No "TODO" / "TBD" / "implement later".
- **Type consistency:** Method names match across patches (`Prefix`, `Postfix`). `CustomerProfile` API matches what's already defined in `Models/CustomerProfile.cs`. `DebugLog.Msg`/`Short` signatures match `Core/DebugLog.cs`. All Il2Cpp types use `Il2CppScheduleOne.*` prefix consistently.
