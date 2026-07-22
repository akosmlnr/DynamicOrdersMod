## DynamicOrdersMod v3 — Complete Remaining Features

13 sequential steps across 13 files (11 modified, 1 new, 1 csproj). All changes build on the existing middleware architecture.

### Key API Reference (Decompiled → Il2CppInterop)
- `ScheduleOne.*` → `Il2CppScheduleOne.*`
- `NPC.RelationData.ChangeRelationship(float delta, bool network=true)` — modify relationship
- `NPCRelationData.NormalizedRelationDelta` — 0-1 read-only
- `DeadDrop.DeadDrops` (static List), `DeadDrop.Region` (EMapRegion field), `DeadDrop.DeadDropName` (string field)
- `ProductDefinition.DrugType` (EDrugType), `ProductDefinition.BasePrice` (float field)
- `MoneyManager.Instance.ChangeCashBalance(float, bool, bool)` — add/remove money
- `EMapRegion`: Northtown, Westville, Downtown, Docks, Suburbia, Uptown
- `EDrugType`: Marijuana, Methamphetamine, Cocaine, MDMA, Shrooms, Heroin
- `EQuality`: Trash, Poor, Standard, Premium, Heavenly

---

### Step 1: Model Foundation
**Files:** `Models/CustomerProfile.cs`, `Models/ModSaveData.cs`, NEW `Models/DeadDropDeal.cs`

**CustomerProfile.cs** — add fields:
- `float LastKnownAddiction = 0f` — cached from EvaluateDelivery for decay calc
- `float PendingRelationshipHit = 0f` — deferred relationship hit for hospital release
- `string LastRequestedDrugType = ""` — cached from GetWeightedRandomProduct
- `int LastRequestedQuantity = 0` — cached from GetWeightedRandomProduct

**ModSaveData.cs** — add:
- `List<DeadDropDeal> ActiveDeadDropDeals = new List<DeadDropDeal>()`

**NEW DeadDropDeal.cs** — dead drop deal tracking model:
- `DealId` (string), `CustomerGuid`, `DropGuid`, `DrugType` (string), `Quantity` (int), `Payment` (float), `IsPrepaid` (bool), `CreatedDay` (int), `WindowDay` (int), `IsResolved` (bool), `Result` (string: "pending"/"success"/"theft"/"police"/"nonpayment"/"expired")

No SaveVersion bump — all new fields have safe defaults for backward compat.

---

### Step 2: Fix TryGenerateContract + Expose IsHost
**Files:** `Patches/CustomerPatches.cs`, `Core/DynamicEconomyCore.cs`

**Critical bug fix:** Current prefix has `ref bool __result` but the method returns `ContractInfo`. The patch never matches.
- Change to `ref Il2CppScheduleOne.Quests.ContractInfo __result`
- Add `using Il2CppScheduleOne.Quests;`

**DynamicEconomyCore.cs:** Change `private static bool IsHost()` → `public static bool IsHost()` so patches can check host authority.

---

### Step 3: Enhanced GetWeightedRandomProduct Postfix
**File:** `Patches/CustomerPatches.cs`

- Add `ref Il2CppScheduleOne.Product.ProductDefinition __result` to capture the returned product
- After quantity scaling, apply `EventManager.GetOrderReduction(drugType, "")` to reduce orders during events
- Store `__result.DrugType.ToString()` in `profile.LastRequestedDrugType` and `orderableQuantity` in `profile.LastRequestedQuantity`
- Add host check: `if (!DynamicEconomyCore.IsHost()) return;` for data-modifying ops

---

### Step 4: Improved EvaluateDelivery Postfix
**File:** `Patches/CustomerPatches.cs`, `Systems/CustomerProfileManager.cs`

Replace simplified tolerance/overdose logic with proper data:
- Use `profile.LastRequestedDrugType` and `profile.LastRequestedQuantity` for proper `ApplyToleranceGrowth(profile, estimatedQty, baseQty, 1f)`
- Call `profile.RecordPurchase(currentDay, drugType, estimatedQty, estimatedPayment)` with actual data instead of just `LifetimeDeals++`
- Store `profile.LastKnownAddiction = __instance.CurrentAddiction` for decay formula
- On overdose: apply immediate relationship hit via `__instance.NPC?.RelationData?.ChangeRelationship(-config.HospitalRelationshipDecay, false)`
- Set `profile.PendingRelationshipHit` for larger release-time hit (scaled by overdose count)
- Add host check

---

### Step 5: Hospital Release Relationship System
**File:** `Systems/CustomerProfileManager.cs`

- In `UpdateHospitalization`: when releasing, set `PendingRelationshipHit`:
  - 1st overdose: `config.ReleaseRelationshipHit` (0.3)
  - 2nd+ overdose: `config.ReleaseRelationshipHit * 2.5f` (0.75)
- Add `ApplyPendingHit(CustomerProfile profile, NPC npc)` method that calls `npc.RelationData.ChangeRelationship(-profile.PendingRelationshipHit)` and resets to 0
- Call `ApplyPendingHit` from EvaluateDeliveryPostfix when `PendingRelationshipHit > 0` (customer is interacting again after release)

---

### Step 6: Tolerance Decay Enhancement
**File:** `Systems/CustomerProfileManager.cs`

- Change decay formula in `ApplyDailyDecay`:
  - Old: `decay = decayBase` (constant)
  - New: `decay = decayBase * Math.Max(0.1f, 1f - profile.LastKnownAddiction)`
  - Rationale: highly addicted customers should lose tolerance slower

---

### Step 7: Event System Fixes
**File:** `Systems/EventManager.cs`

- Replace hardcoded `string[] regions = { "Downtown", "Uptown", "Suburbs", "Industrial", "" }` with actual `EMapRegion` enum names: `{ "Northtown", "Westville", "Downtown", "Docks", "Suburbia", "Uptown", "" }`
- Replace hardcoded `string[] drugTypes = { "Weed", "Cocaine", "Meth", "Heroin", "" }` with `EDrugType` enum names: `{ "Marijuana", "Methamphetamine", "Cocaine", "MDMA", "Shrooms", "Heroin", "" }`
- This ensures event checks match the game's actual data

---

### Step 8: DeadDrop Manager Improvements
**File:** `Systems/DeadDropManager.cs`

- In `InitializeDeadDropStates`: use `drop.DeadDropName` (not `drop.name`) and `drop.Region.ToString()` for Region
- In `ResolveDeadDrop`: multiply police intercept chance by `config.CrackdownDeadDropRiskMultiplier` when `EventManager.IsCrackdownActive(state.Region)` is true
- After resolution: `SaveManager.Data.Statistics.TotalDeadDropsCompleted++` on success, `TotalDeadDropsFailed++` on failure
- Add `using Il2CppScheduleOne.Deaddrop;` and `using Il2CppScheduleOne.Map;`

---

### Step 9: Dead Drop Contract Interception
**File:** `Patches/CustomerPatches.cs`

In TryGenerateContract prefix, after existing eligibility checks pass:
1. Call `DeadDropManager.SelectDropForAsync()` — if null, fall through to original (return true)
2. Determine prepaid vs async: `UnityEngine.Random.value < config.PrepaidChance`
3. Calculate payment: `PricingEngine.CalculateCustomerPrice(basePrice, addiction, deals, pricingConfig, events, drugType, shortageIncrease) * quantity`
4. Create `DeadDropDeal` with all data, add to `SaveManager.Data.ActiveDeadDropDeals`
5. If prepaid: `MoneyManager.Instance.ChangeCashBalance(payment * 0.8f, false, false)` (80% upfront)
6. `NotificationHelper.Send(...)` informing player
7. Set `__result = null`, return false (skip original contract generation)

---

### Step 10: Dead Drop Deal Resolution
**File:** `Core/DynamicEconomyCore.cs`

New method `ResolveDeadDropDeals(int currentDay)`:
- Iterate `SaveManager.Data.ActiveDeadDropDeals` where `WindowDay <= currentDay && !IsResolved`
- Call `DeadDropManager.ResolveDeadDrop(deal.DropGuid, deal.IsPrepaid, true)` for outcome
- **Success**: async → deposit full payment; prepaid → deposit remaining 20% bonus; relationship +0.05
- **Theft**: relationship -0.1; notification
- **Police**: relationship -0.2; notification about increased heat
- **Non-payment** (async only): notification about lost payment
- Mark `IsResolved = true`, set `Result`
- Call from `OnDayEnd` after `EventManager.RollDailyEvents` and before `SaveManager.Save()`
- Clean up resolved deals (remove from list or keep for history)

---

### Step 11: Wholesale Revenue Tracking
**Files:** `Core/DynamicEconomyCore.cs`, `Patches/MoneyManagerPatches.cs`

- In `ProcessWeeklyWholesale`: replace the `$50-200` estimate with a calculation using `PricingEngine.CalculateWholesaleTotal()` and a reasonable base price per drug type
- Track actual revenue: `SaveManager.Data.Statistics.TotalWholesaleRevenue += totalRevenue`
- Add immediate `SaveManager.Save()` after wholesale processing

---

### Step 12: Seeded RNG for Deterministic Multiplayer
**File:** `Systems/ScalingEngine.cs`

- Add `static int HashToSeed(string guid, int day)` — simple deterministic hash combining GUID and day
- In `CalculateScaledQuantity`: accept optional seed parameter, use `new System.Random(seed)` when available
- In `GetWeightedRandomProductPostfix`: pass `HashToSeed(customerGuid, currentDay)` as seed
- This ensures all clients compute identical scaled quantities for the same customer on the same day

---

### Step 13: Polish & csproj
**Files:** `Core/DynamicEconomyCore.cs`, `DynamicOrdersMod.csproj`

- Add `SaveManager.Save()` after overdose events in EvaluateDelivery
- Add `SaveManager.Save()` after dead drop resolution
- Add `<Compile Include="Models\DeadDropDeal.cs" />` to csproj

---

### Execution Order
Steps 1 → 2 → 3 → 4 → 5 → 6 → 7 → 8 → 9 → 10 → 11 → 12 → 13

Each step will be implemented, verified, and committed before moving to the next.