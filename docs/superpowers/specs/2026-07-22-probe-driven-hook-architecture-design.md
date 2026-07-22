# Probe-Driven Hook Architecture for Dead Drops + Overdose Accuracy

**Date:** 2026-07-22
**Status:** Approved (brainstormed)
**Goal:** Fix two known limitations — dead drop contract interception and item-level overdose potency — via a test-first approach that determines which Harmony signatures actually bind in this MelonLoader/Il2Cpp environment.

## Background

The mod's architecture relies on Harmony patches and UnityEvent subscriptions to observe and modify game state. Empirical testing (2026-07-22) proved that:

- **Harmony patches on `Customer` methods silently fail to bind.** `PatchProcessor.GetPatchInfo` reports `prefixes=0 postfixes=0` for `Customer.OfferContract`, `Customer.ContractAccepted`, `Customer.ProcessHandover`, `Customer.CurrentContractEnded`, `Customer.RpcLogic___ChangeAddiction_431000436`, and `Contract.Complete`.
- **Harmony patches on non-Customer types (e.g. `SaveManager.Save`) bind correctly** (reported `postfixes=2`).
- **UnityEvent subscriptions work reliably.** `Customer.onCustomerUnlocked`, `Customer.onContractAssigned<Contract>`, `Customer.onDealCompleted`, and `Contract.onComplete`/`onQuestEnd` all fire from native code as expected.

The root cause is suspected to be MelonLoader's Il2Cpp interop failing to attach patches when the resolved parameter signatures don't match — especially for methods on `NetworkBehaviour` types with `ref`/`out` parameters and generic collection types.

## Two Limitations

### Limitation 1: Dead drop interception
**Current state:** The mod hooks `Customer.onContractAssigned(Contract)` UnityEvent, which fires AFTER contract creation. Mutating `contract.DeliveryLocationGUID` at this point may not propagate to HUD/PoI/journal entry (those are configured during `InitializeContract` and `Begin`).

**Goal:** If a customer is dead-drop-eligible (high relationship, tolerance ≥ 0.3, 5+ lifetime deals, cooldown elapsed), ~30% of their contracts should redirect to a dead drop location. Player sees the dead drop as the delivery point on the map/journal/compass.

### Limitation 2: Overdose potency accuracy
**Current state:** Overdose chance uses `Customer.CurrentAddiction` as a potency proxy because item-level data isn't available at the `onDealCompleted` UnityEvent fire time.

**Goal:** Compute overdose chance using the actual delivered items' effect addiction data (the original design intent — "driven by delivered product potency, highest effect addictiveness from mix composition").

## Design: Probe-First Approach

**Core principle:** Do not assume which Harmony signatures will bind. Probe empirically, then commit to an architecture based on results. Each probe costs one build cycle (~2 minutes of dev + user's compile time).

### Phase 1: Diagnostic Probe Build

Add 4 minimal test patches to `CustomerPatches.cs`. Each patch:
1. Has the simplest possible signature for its target method
2. Logs when it FIRES (not just binds) via `DebugLog.Msg` — the binding-vs-firing distinction matters
3. Wraps in try/catch to avoid runtime errors
4. Does NOT mutate state — purely observational

| # | Target | Type | Signature | What success would tell us |
|---|---|---|---|---|
| 1 | `Customer.OfferContract` | PREFIX | `(Customer __instance, ContractInfo info)` | Whether ANY Customer method can bind with a clean signature |
| 2 | `Customer.ProcessHandover` | POSTFIX | `(Customer __instance, HandoverScreen.EHandoverOutcome outcome, Contract contract, List<ItemInstance> items, bool handoverByPlayer, bool giveBonuses)` | Whether Customer methods with complex params (List<>) can bind |
| 3 | `Contract.InitializeContract` | POSTFIX | `(Contract __instance)` — access state via __instance, not params | Whether Contract/Quest methods bind (Quest is MonoBehaviour, not NetworkBehaviour) |
| 4 | `Dealer.ContractedOffered` | PREFIX | `(Dealer __instance, ContractInfo contractInfo, Customer customer)` | Whether Dealer methods bind (Dealer extends NPC) |

Also extend `ModEntry.LogPatchBindingStatus` to query each of these 4 targets.

**Success signal:** `[Diagnostic] Customer.OfferContract: BOUND (prefixes=1, postfixes=0)` AND `[DOM] [probe] OfferContract FIRED` appearing in logs when a deal happens.

**Failure signal:** `BOUND (prefixes=0, postfixes=0)` OR no `[probe] FIRED` lines despite deals happening.

### Phase 2: Scenario-Based Implementation

Based on which probes fire, pick the implementation path:

#### Scenario A: All 4 fire
**Best case.** Implement full features on the Harmony foundation.

- **Dead drops:** `Customer.OfferContract` PREFIX mutates `info.DeliveryLocationGUID` to a `DeadDrop.GUID` for eligible customers. Because this runs BEFORE contract creation, the mutation propagates through `InitializeContract` → `Begin` → HUD/PoI/journal configuration. Player sees the dead drop as the delivery point from the start.
- **Overdose:** `Customer.ProcessHandover` POSTFIX iterates the `items` list, extracts `ProductItemInstance` effect addiction data, computes `highestAddiction` accurately. Passes real potency to `EventManager.CalculateOverdoseChance`.
- **Scaling:** stays on UnityEvent (works fine, no reason to change).

#### Scenario B: Customer methods don't fire, but Contract/Dealer do
**Partial win.** Dead drops work via Contract/Dealer hooks; overdose uses proxy.

- **Dead drops:** `Contract.InitializeContract` POSTFIX mutates `contract.DeliveryLocationGUID` + re-resolves `DeliveryLocation` MonoBehaviour via `DeadDrop.Storage` lookup. OR `Dealer.ContractedOffered` PREFIX mutates `contractInfo.DeliveryLocationGUID` before it propagates.
- **Overdose:** no item data available → keep `Customer.CurrentAddiction` as potency proxy (already implemented).

#### Scenario C: Only Contract.InitializeContract fires
**Contract-level only.**

- **Dead drops:** mutate contract in `InitializeContract` postfix (same as Scenario B).
- **Overdose:** read `contract.ProductList` for expected items (not actual delivered items). Use as quality reference; combine with addiction for potency estimate. Not as accurate as Scenario A but better than pure addiction proxy.

#### Scenario D: None fire
**Accept the constraint, polish the current approach.**

- **Dead drops:** side-channel with notifications. `DeadDropDeal` records resolved next day. Player gets "Customer X wants a dead drop at location Y" notification. Contract completes normally in-person; dead drop is a bonus side channel with payment premium.
- **Overdose:** addiction proxy (already implemented).
- Document the limitation clearly in README.

### Phase 3: Implementation Patterns

Whichever scenario we land in, the implementation follows established patterns:

- **Harmony patches** go in `CustomerPatches.cs` (currently mostly empty, ready to receive working patches)
- Each patch wraps in try/catch with `MelonLogger.Error`
- Each patch uses `DebugLog.Msg` for observability
- Dead drop logic reuses `DeadDropManager.SelectDropForAsync()`, `DeadDropDeal` model, resolution flow in `DynamicEconomyCore.ResolveSingleDeal`
- Overdose logic reuses `EventManager.CalculateOverdoseChance`, `ResolveOverdose`
- All patches are host-only (data-mutating ops check `DynamicEconomyCore.IsHost()`)

### Dead Drop UX (Scenarios A/B/C — contract mutation)

When a customer is dead-drop-eligible:
1. **Eligibility check:** relationship ≥ `MinRelationship` (0.4), tolerance ≥ 0.3, lifetime deals ≥ 5, cooldown elapsed
2. **Roll:** 30% chance (`PrepaidChance` config) the contract redirects to a dead drop
3. **Drop selection:** `DeadDropManager.SelectDropForAsync()` returns GUID of lowest-heat discovered unoccupied drop
4. **Contract mutation:** set `contract.DeliveryLocationGUID = dropGuid` (and re-resolve `DeliveryLocation` MonoBehaviour in Scenarios B/C)
5. **Pricing:** apply async premium (10-20%) if not prepaid; run through `PricingEngine.CalculateCustomerPrice`
6. **Tracking:** create `DeadDropDeal` record with all contract terms; add to `SaveManager.Data.ActiveDeadDropDeals`
7. **Prepaid deposit:** if prepaid (50% chance), deposit full payment via `MoneyManager.Instance.ChangeCashBalance`
8. **Notification:** `NotificationHelper.Send("Dead Drop Contract", "...")` informing the player
9. **Resolution:** at next day-end, `DynamicEconomyCore.ResolveDeadDropDeals` reads the drop's storage, evaluates delivery (proportional payment for partial, quality bargain for low quality), pays out

### Overdose Potency (Hybrid)

Always:
1. Determine `potency` value for the overdose chance calculation
2. **If Scenario A (real item data available):** iterate items, compute `highestAddiction` from `ProductItemInstance` effect data
3. **Otherwise:** use `Customer.CurrentAddiction` as proxy
4. Pass `potency` to `EventManager.CalculateOverdoseChance(profile, qualityDiff, potency, currentAddiction, quantityFactor)`
5. Roll, resolve, log

## Risk and Verification

- **Risk:** Even "simple" Harmony signatures may not bind. Probe Phase 1 surfaces this in one build cycle.
- **Risk:** Contract mutation may desync PoI/HUD if `DeliveryLocation` MonoBehaviour isn't re-resolved. Scenario B/C patches must include `contract.DeliveryLocation = drop.Storage.GetComponent<DeliveryLocation>()` or similar.
- **Verification:** With `DebugLogging=true`:
  - Probe phase: `[probe] OfferContract FIRED` lines confirm which patches work
  - Implementation: `[DOM] [cust=xxx] dead drop contract CREATED deal: prepaid=YES payment=$X drop=yyy` confirms dead drop flow
  - Implementation: `[DOM] [cust=xxx] OVERDOSE ROLL: chance=X roll=Y -> YES (potency=Z)` with real potency value confirms item-level data

## Execution Order

1. **Implement Phase 1 (probe build)** — add 4 test patches + extend diagnostic. Commit, push.
2. **User builds and tests** — reports which `[probe] FIRED` lines appear during deal completion.
3. **Determine scenario** — based on probe results, document which scenario we're in.
4. **Implement Phase 3 (features)** — execute the scenario-specific implementation plan.
5. **Test and verify** — confirm dead drops appear in-map, overdose rolls use real potency (if applicable).

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
- Addiction: `RpcLogic___ChangeAddiction_431000436` PREFIX modifies `ref float change` with tolerance modifier

Redundant UnityEvent handlers (`OnCustomerContractAssigned`, `OnCustomerDealCompleted`) stripped to debug-only logging — their work moved to Harmony patches. `OnContractComplete` and `OnContractEnded` kept as fallback signals.

