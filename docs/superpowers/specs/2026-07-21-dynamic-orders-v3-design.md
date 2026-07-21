# DynamicOrdersMod v3 — Design Specification

**Game:** Schedule I (MelonLoader + Harmony, Il2Cpp, FishNet multiplayer)
**Author:** akosmlnr
**Date:** 2026-07-21
**Status:** Approved

## Overview

DynamicOrdersMod v3 is a complete rewrite of the v2 mod. It adds dynamic order scaling, a dead drop delivery system, tolerance mechanics, wholesale customers, volume pricing, random events (including overdoses), and a full config system — all without requiring new models or assets.

v2 was a ~100-line skeleton that assigned per-customer budget numbers from `CustomerData.Standards` but never used them. v3 replaces it entirely.

## Architecture: Middleware Layer (Approach B)

A central `DynamicEconomyCore` singleton owns all mod logic. Thin Harmony patches (6 total) route game calls into the core. This keeps the patch surface small, makes multiplayer work naturally (deterministic patches, host-authority for events), and centralizes config.

### Patch Surface

| Target | Type | Purpose |
|---|---|---|
| `Customer.TryGenerateContract` | Prefix | Intercept large orders for dead drop conversion |
| `Customer.GetWeightedRandomProduct` | Postfix | Adjust orderableQuantity based on scaling engine |
| `Customer.EvaluateDelivery` | Postfix | Inject tolerance into satisfaction, trigger overdose check |
| `Customer.ChangeAddiction` | Postfix | Reduce addiction gain for high-tolerance customers (tolerance slows addiction) |
| `TimeManager.EndSleep` | Postfix | Day-end processing: events, tolerance decay, wholesale revenue, dead drop expiry |
| `MoneyManager.ChangeCashBalance` | Postfix | Track cash flows (debug/info) |

### Data Flow

```
Game: TryGenerateContract
  → Prefix: Core checks if order qualifies for dead drop
    → If yes: Core creates dead drop contract, returns (skip original)
    → If no: Original runs → Postfix on GetWeightedRandomProduct adjusts quantities

Game: EvaluateDelivery
  → Postfix: Core adjusts satisfaction for tolerance, rolls overdose chance
    → If overdose: Hospitalize customer, send notification, update save

Game: EndSleep
  → Postfix: Core runs daily processing
    → EventManager rolls for random events
    → CustomerProfileManager applies tolerance decay, hospitalization timers
    → DeadDropManager resolves active drops, decays heat
    → If end of week: Wholesale revenue collection
    → SaveManager persists all state
```

## System 1: Order Scaling

### Progressive Growth

Each customer has a scaling multiplier based on addiction, relationship, and tolerance.

```
baseQuantity = game's original quantity
scaledQuantity = baseQuantity × (1 + addictionBonus + relationshipBonus + toleranceBonus)
scaledQuantity = Clamp(scaledQuantity, 1, 1000)
```

- `addictionBonus = CurrentAddiction × 2.0` (max addiction = 2× order size)
- `relationshipBonus = normalizedRelationship × 0.5` (max relationship = +50%)
- `toleranceBonus = toleranceLevel × 1.5` (see Tolerance system)

Random variability: ±20% per order. 5% chance of a "binge" order (2-3× normal, higher overdose risk).

### Tolerance System

Each customer tracks tolerance (0.0 to 1.0).

**Growth:** `toleranceGain = (quantity / baseQuantity - 1) × 0.01 × DependenceMultiplier`

**Decay:** `dailyDecay = 0.002 × (1 - CurrentAddiction)` (addicted customers barely decay)

**Effects:**
- Increases order quantities (via scaling multiplier)
- Reduces satisfaction: at 0.5 tolerance, satisfaction reduced by 25%
- Raises quality expectations: tolerant customers may reject Standard quality even if their `Standards` say Moderate
- Slows addiction gain: the `ChangeAddiction` patch multiplies addiction delta by `(1 - tolerance × 0.5)`, so a fully tolerant customer gains addiction at half the normal rate

### Config

```json
{
  "scaling": {
    "addictionWeight": 2.0,
    "relationshipWeight": 0.5,
    "toleranceWeight": 1.5,
    "randomVariability": 0.2,
    "bingeOrderChance": 0.05,
    "bingeOrderMultiplier": 2.5
  },
  "tolerance": {
    "gainPerDelivery": 0.01,
    "dailyDecayBase": 0.002,
    "satisfactionPenaltyScale": 0.5,
    "qualityExpectationShift": true
  }
}
```

## System 2: Dead Drop Orders

### Background

The game already has `DeadDrop` world objects with names, descriptions, regions, POI markers, storage containers, and lights. These are currently only used for supplier deliveries. v3 repurposes them for customer deliveries.

### Eligibility

- `normalizedRelationship >= 0.4`
- Order quantity > 3× normal (configurable threshold)
- No dead drop failure within 7 days (cooldown)

### Two Types

**Prepaid Drop (50% chance):**
- Customer leaves cash at a `DeadDrop` location near them (found via `DeadDrop.GetRandomEmptyDrop(customerPosition)`)
- Player picks up cash, prepares package, leaves at location
- Customer collects within the deal window
- Full payment upfront, no premium

**Async Drop (50% chance):**
- Player selects a discovered dead drop location
- Player prepares and leaves package
- Customer collects and leaves payment
- 10-20% premium for convenience
- Risk of non-payment (8% chance)

### Time Windows

Dead drops use the same `EDealWindow` system as normal deals (Morning, Afternoon, Night, LateNight).

**Missed window consequences:**
- Prepaid, cash not picked up: customer reclaims cash, -0.1 relationship
- Prepaid, cash picked up, no delivery: -1.0 relationship (severe — can trigger cartel defection at normalized ≤ 0.25)
- Async, no delivery: standard -0.5 deal rejection

### Events

| Event | Chance | Effect |
|---|---|---|
| Theft | 3% | Package stolen, no payment, -0.5 relationship, heat +0.3 |
| Non-payment | 8% (async only) | 30-60% payment, -0.15 relationship, a follow-up quest is created using the game's `Quest` system requiring the player to visit the customer to collect the remaining debt |
| Police intercept | 2% × (1 + heat) | Package confiscated, law intensity +5%, -0.3 relationship, heat +0.5 |
| Success | Remaining | +0.25 relationship (via satisfaction), heat -0.1 |

### Discovery

When a customer first becomes dead-drop eligible, a one-time quest is created using the game's `Quest` system. The player must visit 3-5 `DeadDrop` locations. Visited locations are marked as "discovered" and become available for future drops.

### Heat System

Each `DeadDrop` has a mod-internal heat value (0.0 to 1.0). Reusing the same location increases heat. Heat affects police intercept chance. Heat decays 0.1/day when not used.

**Map display** (configurable toggle): Dead drop POI labels are updated via `POI.SetMainText()` to show risk level: `"Alley Drop [Risk: Medium]".

### One dead drop per deal at a time. Only discovered locations are options.

### Config

```json
{
  "deadDrops": {
    "enabled": true,
    "minRelationship": 0.4,
    "quantityThreshold": 3.0,
    "prepaidChance": 0.5,
    "asyncPremiumMin": 0.10,
    "asyncPremiumMax": 0.20,
    "theftChance": 0.03,
    "nonPaymentChance": 0.08,
    "policeInterceptBaseChance": 0.02,
    "theftCooldownDays": 7,
    "successRelationshipBonus": 0.05,
    "heatDecayPerDay": 0.1,
    "showHeatOnMap": true,
    "discoveryQuestEnabled": true,
    "discoveryLocationsCount": 5
  }
}
```

## System 3: Wholesale & Pricing

### Volume Discounts

```
quantity < 5:    no discount
quantity 5-15:   5% discount
quantity 15-50:  12% discount
quantity 50-100: 20% discount
quantity > 100:  30% discount
```

### Player Price Negotiation

Suggested price factors in: market price × volume discount × addiction premium × supply/demand × random fluctuation (±5-15%).

Price above suggested → satisfaction penalty. Price >20% above → deal may be rejected.

### Wholesale Customers

**Eligibility:** relationship ≥ 0.7, ≥ 20 successful deliveries, tolerance ≥ 0.5

**Behavior:**
- Order 5-10× normal quantities
- Get tier 3-4 pricing automatically
- Generate passive weekly revenue: `weeklyPurchaseTotal × 0.30` paid to player via `MoneyManager.ChangeCashBalance()`

### Config

```json
{
  "pricing": {
    "discountTiers": [
      { "minQuantity": 5,  "discount": 0.05 },
      { "minQuantity": 15, "discount": 0.12 },
      { "minQuantity": 50, "discount": 0.20 },
      { "minQuantity": 100, "discount": 0.30 }
    ],
    "marketFluctuationRange": 0.15,
    "addictionPricePremium": 0.10
  },
  "wholesale": {
    "enabled": true,
    "minRelationship": 0.7,
    "minCompletedDeals": 20,
    "minTolerance": 0.5,
    "weeklyRevenueCut": 0.30,
    "bulkOrderMultiplier": 7.0
  }
}
```

## System 4: Random Events & Overdoses

### Event Rolling

Events roll at end of each in-game day via `EventManager`. Weighted by game state.

### Overdose System

**Chance per delivery:**
```
baseChance = 0.002 (0.2%)

Modifiers (multiplicative):
  quality below standards:    × (standardQuality - deliveredQuality) × 0.01
  mix intensity (ValueChange): × abs(mixValueChange) × 0.005
  tolerance > 0.7:            × 1.5
  addiction > 0.8:            × 2.0
  DependenceMultiplier:       × DependenceMultiplier
  quality above standards:    × (deliveredQuality - standardQuality) × 0.005
  clean product:              × 0.5

Capped at 5% max.
```

**Consequence progression:**
1. First overdose: Hospitalized 5-10 days, -0.3 relationship on release
2. Second overdose (within 30 days): -0.8 relationship, customer refuses orders for 14 days
3. Third overdose: Permanent refusal (customer lost)

### Police Crackdown (~2% per week)

- Duration: 3-5 days
- All customers reduce order frequency by 50%
- Dead drop police intercept chance × 3
- Region-specific notification

### Supply Shortage (~5% per week)

- Random `EDrugType` affected
- Orders for that type reduced 60%, price +40%
- Duration: 5-7 days

### Config

```json
{
  "events": {
    "enabled": true,
    "policeCrackdownChancePerWeek": 0.02,
    "crackdownDurationDays": [3, 5],
    "crackdownOrderReduction": 0.5,
    "crackdownDeadDropRiskMultiplier": 3.0,
    "supplyShortageChancePerWeek": 0.05,
    "shortageDurationDays": [5, 7],
    "shortageOrderReduction": 0.6,
    "shortagePriceIncrease": 0.40
  },
  "overdose": {
    "baseChance": 0.002,
    "maxChance": 0.05,
    "hospitalizationDays": [5, 10],
    "hospitalRelationshipDecay": 0.02,
    "releaseRelationshipHit": 0.3,
    "secondOverdoseRelationshipHit": 0.8,
    "secondOverdoseRefusalDays": 14,
    "thirdOverdosePermanentRefusal": true
  }
}
```

## System 5: Persistence

### Save Location

`%APPDATA%/DynamicOrdersMod/v3/saveData.json`

### Save Triggers

- End of each in-game day
- Immediately on overdose/hospitalization
- On wholesale status change

### Key Save Data

Per-customer: tolerance, scaling multiplier, wholesale status, overdose count, hospitalization state, discovered dead drops, purchase history.

Per-dead-drop: heat value.

Active events: type, affected region/drug, end day.

Statistics: total dead drops, overdoses, wholesale revenue.

## System 6: Config

### Config Location

`%APPDATA%/DynamicOrdersMod/v3/config.json`

### Behavior

- Written with defaults on first load (all values documented)
- Hot-reloaded on each `TimeManager.EndSleep` (player edits file, sleeps, changes apply)
- All sections from Systems 1-4 merged into one file with a `general` section (`enabled`, `debugLogging`, `configVersion`)

## System 7: Multiplayer

### Approach

- No custom NetworkBehaviours or RPCs
- All patches run on all clients independently
- Mod state is deterministic (seeded RNG from in-game day)
- Host authority: event rolls, wholesale calculations, dead drop conversions only on host
- Save data is per-client
- Config is per-client

### Why This Works

The host controls the simulation. Contracts created by the host sync via FishNet. Our patches modify quantities on the host side, and results flow through existing game network sync.

## File Structure

```
DynamicOrdersMod/
├── DynamicOrdersMod.csproj
├── Properties/
│   └── AssemblyInfo.cs
├── Core/
│   ├── DynamicEconomyCore.cs
│   ├── ModEntry.cs
│   └── Constants.cs
├── Systems/
│   ├── CustomerProfileManager.cs
│   ├── DeadDropManager.cs
│   ├── PricingEngine.cs
│   ├── EventManager.cs
│   └── ScalingEngine.cs
├── Models/
│   ├── CustomerProfile.cs
│   ├── DeadDropState.cs
│   ├── ModConfig.cs
│   ├── ModSaveData.cs
│   ├── ActiveEvent.cs
│   └── WholesaleRecord.cs
├── Persistence/
│   ├── ConfigManager.cs
│   └── SaveManager.cs
├── Patches/
│   ├── CustomerPatches.cs
│   ├── TimeManagerPatches.cs
│   └── MoneyManagerPatches.cs
└── UI/
    └── NotificationHelper.cs
```

~18 source files. Each with a single clear responsibility.

## Out of Scope

- New phone app or UI panels
- New drug types or products
- Territory/cartel system changes
- New NPC behaviors or dialogue
- Map mods or new locations
- Custom network messages