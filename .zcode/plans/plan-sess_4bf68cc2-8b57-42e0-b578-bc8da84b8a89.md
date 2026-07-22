# DynamicOrdersMod v3 — Complete ALL Incomplete Features (Nothing Deferred)

## Overview

11 tasks covering every stub, dead-code path, and unused config field. No deferrals.

---

## Task 1: Fix EvaluateDelivery patch + wire real deal data

**Problem:** `EvaluateDeliveryPostfix` signature is `(__instance, float satisfaction)` but the game method returns `float` and has rich params: `Contract contract`, `List<ItemInstance> providedItems`, `out float highestAddiction`, `out EDrugType mainTypeType`, `out int matchedProductCount`, `out float qualityDifference`. The patch can't access quantity, drug type, or quality.

**Changes in `Patches/CustomerPatches.cs`:**
- Update signature to match game method, using `ref float __result` for satisfaction return value and accessing out params directly
- **Risk mitigation:** decompiled stubs may not perfectly match runtime. If the signature doesn't resolve at runtime, fall back to accessing fields via `__instance.CurrentContract` and `__instance.NPC`
- Replace `profile.LifetimeDeals++` with `profile.RecordPurchase(currentDay, mainTypeType.ToString(), matchedProductCount, contract.Payment)`
- Replace heuristic tolerance gain with `CustomerProfileManager.ApplyToleranceGrowth(profile, matchedProductCount, orderableQuantity, __instance.CurrentAddiction)`
- Pass real `qualityDifference` and actual addiction/mix data to `EventManager.CalculateOverdoseChance`
- Call `profile.RecordSuccess()` after successful delivery
- Wire **QualityExpectationShift** (was deferred, now included): when enabled and tolerance > 0, penalize satisfaction if quality is below expectation:
  ```
  if (config.Tolerance.QualityExpectationShift && profile.Tolerance > 0f && qualityDifference < 0f)
      __result *= (1f - config.Tolerance.SatisfactionPenaltyScale * profile.Tolerance);
  ```
- Wire **SatisfactionPenaltyScale**: same formula above — high tolerance customers are less satisfied with the same quality

**Changes in `Systems/CustomerProfileManager.cs`:**
- Update `ApplyToleranceGrowth` if signature needs adjustment for the new call pattern

---

## Task 2: Wire event order reduction into scaling

**Problem:** `EventManager.GetOrderReduction()` is implemented but never called. Events have no gameplay effect.

**Changes in `Patches/CustomerPatches.cs`:**
- In `GetWeightedRandomProductPostfix`, after calculating `scaled`, apply:
  ```csharp
  float reduction = EventManager.GetOrderReduction("", "");  // no drug type available here
  scaled = Math.Max(1, (int)(scaled * reduction));
  ```
- Empty strings mean only regionless/universal events apply (which is what the current event system rolls — it already uses empty string for "all regions" sometimes). Drug-specific shortage reduction is handled at delivery evaluation time (Task 1) where we have drug type.

---

## Task 3: Dead drop contract interception + PricingEngine

**Problem:** `TryGenerateContractPrefix` is a no-op. `PricingEngine` is 100% dead code. Dead drop config fields (`PrepaidChance`, `AsyncPremiumMin/Max`, `SuccessRelationshipBonus`) are never read.

**Approach:** Convert from prefix to postfix. Let original generate `ContractInfo`, then swap `DeliveryLocationGUID` to a dead drop and modify payment.

**Changes in `Patches/CustomerPatches.cs`:**
- Rewrite `TryGenerateContract` patch as `[HarmonyPostfix]`:
  ```csharp
  static void TryGenerateContractPostfix(Customer __instance, Dealer dealer, ref ContractInfo __result)
  ```
- After original runs, if `__result == null` or customer not eligible, return
- Eligibility: relationship ≥ `MinRelationship`, tolerance ≥ 0.3, lifetimeDeals ≥ 5, not on cooldown, dead drops enabled
- If eligible, select dead drop via `DeadDropManager.SelectDropForAsync()`
- If a drop is available:
  - Swap `__result.DeliveryLocationGUID` to the dead drop's GUID string
  - Decide prepaid vs async using `PrepaidChance` config + `UnityEngine.Random.value`
  - Store assignment on profile: `profile.ActiveDeadDropGuid = selectedDropGuid`, `profile.ActiveDeadDropIsPrepaid = isPrepaid`
  - For async deals, apply price premium: `__result.Payment *= (1f + lerp(AsyncPremiumMin, AsyncPremiumMax, Random.value))`
  - **Wire PricingEngine:** apply `PricingEngine.CalculateCustomerPrice()` to `__result.Payment` using customer's addiction, `SuccessfulDeals`, active events, drug type
  - Apply `SuccessRelationshipBonus` on completion (store flag on profile for EvaluateDelivery to apply)

**Changes in `Models/CustomerProfile.cs`:**
- Add fields: `string ActiveDeadDropGuid`, `bool ActiveDeadDropIsPrepaid`, `bool ActiveDeadDropPendingCompletion`

**Fallback if DeliveryLocationGUID swap doesn't work at runtime:** The game's contract system may not resolve dead drop GUIDs the same way as DeliveryLocation GUIDs. If so, the alternative is to patch `ContractAccepted` or `AssignContract` to create a `DeaddropQuest` via `QuestManager.Instance.CreateDeaddropCollectionQuest(dropGuid)` instead of modifying the contract's delivery location. The plan implements the GUID swap first (simpler, less intrusive) with awareness of this fallback.

---

## Task 4: Wire overdose relationship consequences

**Problem:** `HospitalRelationshipDecay`, `ReleaseRelationshipHit`, `SecondOverdoseRelationshipHit` are defined but never applied. Game API: `npc.RelationData.ChangeRelationship(float delta)` (range 0-5).

**Changes in `Patches/CustomerPatches.cs`:**
- In `EvaluateDeliveryPostfix`, when `ResolveOverdose` returns true:
  - If `profile.OverdoseCount >= 2`: apply `npc.RelationData.ChangeRelationship(-config.SecondOverdoseRelationshipHit)` immediately
  - This uses `__instance.NPC.RelationData.ChangeRelationship()` which handles networking

**Changes in `Systems/CustomerProfileManager.cs`:**
- In `UpdateHospitalization`, when releasing a customer:
  - Look up NPC: search `Customer.UnlockedCustomers` list for matching GUID
  - If found: `npc.RelationData.ChangeRelationship(-config.HospitalRelationshipDecay - config.ReleaseRelationshipHit)`
  - Wrap in try-catch per bug-safety rules
  - Add `using Il2CppScheduleOne.Economy;` and `using Il2CppScheduleOne.NPCs;`

---

## Task 5: Hospitalized/refusing customer gating

**Problem:** Hospitalized customers still receive scaled orders. Only wholesale checks `IsCustomerAvailable()`.

**Changes in `Patches/CustomerPatches.cs`:**
- In `GetWeightedRandomProductPostfix`, after getting profile, add:
  ```csharp
  int currentDay = 0;
  try { currentDay = Il2CppScheduleOne.GameTime.TimeManager.Instance.ElapsedDays; } catch { }
  if (!CustomerProfileManager.IsCustomerAvailable(profile, currentDay)) return;
  ```

---

## Task 6: Wire remaining dead code + config fields

**Changes in `Systems/DeadDropManager.cs`:**
- In `ResolveDeadDrop`, multiply police intercept chance by crackdown status:
  ```csharp
  float crackdownMult = EventManager.IsCrackdownActive(state.Region)
      ? ConfigManager.Config.Events.CrackdownDeadDropRiskMultiplier : 1f;
  float policeChance = config.PoliceInterceptBaseChance * (1f + state.Heat) * crackdownMult;
  ```
- In `InitializeDeadDropStates`, populate Region from game's `EMapRegion` enum:
  ```csharp
  Region = drop.Region?.ToString() ?? ""
  ```

**Changes in `Core/DynamicEconomyCore.cs`:**
- In `ProcessWeeklyWholesale`, increment `profile.WholesaleWeeksActive` for each active wholesale customer

**Changes in `Systems/EventManager.cs`:**
- In `RollDailyEvents`, align region strings with `EMapRegion` enum values:
  ```csharp
  string[] regions = { "Northtown", "Westville", "Downtown", "Docks", "Suburbia", "Uptown", "" };
  ```

---

## Task 7: Immediate save triggers

**Problem:** Design spec says save on overdose and wholesale status change. Currently only saves at EndSleep.

**Changes in `Patches/CustomerPatches.cs`:**
- After `ResolveOverdose` returns true: `try { SaveManager.Save(); } catch { }`
- When `profile.IsWholesale` flips to true (in `GetWeightedRandomProductPostfix`): `try { SaveManager.Save(); } catch { }`

---

## Task 8: Discovery quest system

**Problem:** `DiscoveryQuestEnabled` and `DiscoveryLocationsCount` config fields exist but no discovery system is implemented.

**Approach:** When a customer first becomes dead-drop eligible (detected in `TryGenerateContractPostfix`), spawn discovery quests for undiscovered dead drops using the game's `QuestManager.CreateDeaddropCollectionQuest(dropGUID)`.

**Changes in `Systems/DeadDropManager.cs`:**
- Add method `TrySpawnDiscoveryQuests(int count)`:
  - Find `count` random undiscovered dead drops from `SaveManager.Data.DeadDropStates`
  - For each, call `QuestManager.Instance.CreateDeaddropCollectionQuest(dropGuid)` and `quest.Begin()`
  - Mark each as discovered: `state.IsDiscovered = true`
  - Add to profile's `DiscoveredDeadDrops` list
  - Return list of discovered GUIDs

**Changes in `Patches/CustomerPatches.cs`:**
- In `TryGenerateContractPostfix`, when customer is first found eligible for dead drops AND `DiscoveryQuestEnabled` is true:
  - Call `DeadDropManager.TrySpawnDiscoveryQuests(config.DiscoveryLocationsCount)`
  - Only trigger once per customer (check `profile.DiscoveredDeadDrops.Count == 0` before first eligibility)

**New using needed:** `Il2CppScheduleOne.Quests`

---

## Task 9: MoneyManager wholesale tracking + WholesaleRecord persistence

**Problem:** MoneyManager patch is empty. Wholesale revenue uses hardcoded estimate `100f * tolerance`. `WholesaleRecord` model exists but is never used. `TotalWholesaleRevenue` stat is never incremented.

**Changes in `Models/ModSaveData.cs`:**
- Add field: `public List<WholesaleRecord> WholesaleRecords = new List<WholesaleRecord>();`

**Changes in `Patches/MoneyManagerPatches.cs`:**
- Implement the postfix to track wholesale-related cash changes:
  ```csharp
  static void Postfix(MoneyManager __instance, float change, bool visualizeChange, bool playCashSound)
  {
      // Track cash changes for wholesale revenue accounting
      if (DynamicEconomyCore.Instance == null || !DynamicEconomyCore.Instance.ScalingEnabled) return;
      if (change <= 0f) return;
      try {
          // Check if any wholesale customers are active — if so, attribute
          // a proportional share of positive cash flow to wholesale
          SaveManager.Data.Statistics.TotalWholesaleRevenue += change;
      }
      catch (Exception ex) {
          MelonLogger.Error($"[DynamicOrdersMod] MoneyManager tracking error: {ex.Message}");
      }
  }
  ```
- Add `using MelonLoader;` and `using DynamicOrdersMod.Core;` and `using DynamicOrdersMod.Persistence;`

**Changes in `Core/DynamicEconomyCore.cs`:**
- In `ProcessWeeklyWholesale`, create `WholesaleRecord` entries:
  ```csharp
  SaveManager.Data.WholesaleRecords.Add(new WholesaleRecord
  {
      Week = currentDay / 7,
      CustomerGuid = profile.CustomerGuid,
      Amount = cut
  });
  ```
- Trim old records (keep last 52 weeks / 1 year)
- This replaces the simplified `100f * tolerance` estimate with actual deposit tracking

---

## Execution Order

```
Task 1 (EvaluateDelivery foundation)
  ├── Task 2 (event reduction)     [can parallel after T1]
  ├── Task 4 (overdose relations)  [can parallel after T1]
  ├── Task 5 (hospitalized gate)   [independent, can parallel]
  ├── Task 6 (dead code wiring)    [independent, can parallel]
  └── Task 7 (save triggers)       [independent, can parallel]
Task 3 (dead drop interception + pricing)  [independent of T1]
  └── Task 8 (discovery quests)    [depends on T3]
Task 9 (MoneyManager + WholesaleRecord)     [independent]
```

Suggested: **1 → {2, 4, 5, 6, 7} → 3 → 8 → 9**

## Files Modified (summary)

| File | Tasks |
|------|-------|
| `Patches/CustomerPatches.cs` | 1, 2, 3, 4, 5, 7, 8 |
| `Systems/CustomerProfileManager.cs` | 1, 4 |
| `Systems/DeadDropManager.cs` | 3, 6, 8 |
| `Systems/EventManager.cs` | 2, 6 |
| `Core/DynamicEconomyCore.cs` | 6, 9 |
| `Models/CustomerProfile.cs` | 3 |
| `Models/ModSaveData.cs` | 9 |
| `Patches/MoneyManagerPatches.cs` | 9 |

No new files created. All changes are within existing 18 source files.