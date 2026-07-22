# DynamicOrdersMod

A MelonLoader mod for **Schedule I** that overhauls the customer economy with dynamic scaling, dead drops, wholesale deals, pricing tiers, random events, and overdose mechanics.

## Features

- **Dynamic Order Scaling** — Customer order sizes scale with addiction, relationship, and tolerance. Binge orders can randomly occur.
- **Tolerance System** — Customers build tolerance over time (grows per delivery, decays daily). High-tolerance customers expect higher quality and are less satisfied with the same product.
- **Pricing Engine** — Volume discounts at 5/15/50/100 deals, per-customer market fluctuation, and addiction-based price premiums.
- **Dead Drop Contracts** — High-relationship customers switch from handoffs to dead drops. Supports prepaid (customer pays upfront, player delivers) and async (payment on delivery, risk of non-payment) deals. Dead drops carry risk of theft, non-payment, and police interception (scaled by heat and active crackdowns). Resolution reads actual storage contents — partial quantity pays proportionally, higher quality earns a bonus, lower quality means the customer bargains down, wrong product is a failure. One active deal per customer; 7-day cooldown on failure.
- **Discovery Quests** — When a customer first becomes dead-drop eligible, discovery quests spawn for undiscovered locations.
- **Wholesale Deals** — Customers with 20+ completed deals and high relationship can become wholesale buyers, generating weekly passive income.
- **Random Events** — Police crackdowns (reduced orders, increased dead drop risk) and supply shortages (reduced orders, increased prices) roll weekly per region.
- **Overdose System** — Small chance per delivery, driven by delivered product potency (highest effect addictiveness from mix composition) and customer's cumulative addiction. Higher-than-expected quality increases risk (customer's body can't handle the jump); lower quality is the base value. Quantity consumed scales risk. Hospitalized customers are unavailable for 5-10 days with a 2-day post-release grace period to prevent immediate re-overdose. Repeated overdoses cause escalating relationship damage and eventual permanent refusal.
- **Config Hot-Reload** — Config is re-read every sleep cycle. Edit `config.json` in `%APPDATA%/DynamicOrdersMod/v3/` and sleep in-game to apply.
- **Auto-Save Sync** — The mod's `saveData.json` is flushed every time the game writes its own save (auto-saves, manual saves, sleep), not just at sleep. The two never drift.
- **Debug Logging** — Set `"DebugLogging": true` in `config.json` to get a `[DOM] [tag]` log line for every mod event: scaling breakdowns, delivery outcomes, overdose rolls (with chance + roll + components), dead drop contract creation and resolution, tolerance changes, event rolls, hospital releases, wholesale revenue, save flushes, and every skip reason (why scaling didn't fire for a given customer). Zero overhead when disabled.

## Requirements

- **Schedule I** with MelonLoader installed
- **.NET Framework 4.7.2** (ships with MelonLoader)
- **Windows** (the game is Windows-only; the .csproj references Windows game paths)

## Building from Source

### Prerequisites

1. **Visual Studio 2017+** (or Build Tools for Visual Studio) with the **.NET Framework 4.7.2** targeting pack
2. A local install of **Schedule I** via Steam — the `.csproj` references DLLs from `D:\SteamLibrary\steamapps\common\Schedule I\MelonLoader\`

If your Steam library is on a different drive, update the `<HintPath>` values in `DynamicOrdersMod/DynamicOrdersMod/DynamicOrdersMod.csproj` to point to your MelonLoader directory.

### Compile (Windows)

**Option A — Visual Studio**
1. Open `DynamicOrdersMod.sln` in Visual Studio
2. Set configuration to **Release**
3. Build → Build Solution (Ctrl+Shift+B)
4. Output DLL: `DynamicOrdersMod/DynamicOrdersMod/bin/Release/DynamicOrdersMod.dll`

**Option B — Developer Command Prompt**
```bat
:: Open "x64 Native Tools Command Prompt for VS 2022" (or VS 2019/2017)
cd /d path\to\DynamicOrdersMod
msbuild DynamicOrdersMod.sln /p:Configuration=Release /p:Platform=AnyCPU
```
Output: `DynamicOrdersMod/DynamicOrdersMod/bin/Release/DynamicOrdersMod.dll`

### Install

1. Copy `DynamicOrdersMod.dll` into your game's `Mods` folder:
   ```
   D:\SteamLibrary\steamapps\common\Schedule I\MelonLoader\Mods\
   ```
2. Launch the game. A config file is auto-generated on first run at:
   ```
   %APPDATA%\DynamicOrdersMod\v3\config.json
   ```
3. Edit `config.json` to customize settings, then sleep in-game to hot-reload.

## Configuration

Config lives at `%APPDATA%/DynamicOrdersMod/v3/config.json`. Key sections:

| Section | Controls |
|---------|----------|
| `General` | Enable/disable mod, debug logging |
| `Scaling` | Addiction/relationship/tolerance weights, binge order chance |
| `Tolerance` | Gain per delivery, daily decay, quality expectation shift |
| `DeadDrop` | Enable, min relationship, prepaid chance, theft/police chances, discovery quests |
| `Pricing` | Discount tiers, market fluctuation, addiction premium |
| `Wholesale` | Enable, min relationship/deals/tolerance, weekly revenue cut |
| `Events` | Crackdown/shortage chances, durations, effects |
| `Overdose` | Base chance, hospital duration, relationship penalties, refusal rules |

## Save Data

Persistent data (customer profiles, dead drop states, events, wholesale records, statistics) is stored at:

```
%APPDATA%\DynamicOrdersMod\v3\saveData.json
```

Saves are atomic (write to `.tmp` then `File.Move`) to prevent corruption. The mod saves at the end of each sleep cycle, on overdose events, and on wholesale activation.

## Project Structure

```
DynamicOrdersMod/
├── Core/
│   ├── ModEntry.cs              # MelonLoader entry point, Harmony patchAll
│   ├── DynamicEconomyCore.cs    # Singleton orchestrator
│   └── Constants.cs             # Paths, version numbers
├── Models/
│   ├── ModConfig.cs             # JSON-serializable config
│   ├── ModSaveData.cs           # JSON-serializable save state
│   ├── CustomerProfile.cs       # Per-customer tracking data
│   ├── DeadDropState.cs         # Per-dead-drop state
│   ├── ActiveEvent.cs           # Active event (crackdown/shortage)
│   └── WholesaleRecord.cs       # Historical wholesale revenue
├── Patches/
│   ├── CustomerPatches.cs       # Harmony patches for Customer methods
│   ├── TimeManagerPatches.cs    # EndSleep hook (events, decay, wholesale)
│   └── MoneyManagerPatches.cs   # Cash balance tracking
├── Systems/
│   ├── ScalingEngine.cs         # Order quantity calculation
│   ├── PricingEngine.cs         # Price calculation with discounts/fluctuation
│   ├── CustomerProfileManager.cs# Profile lifecycle, hospitalization
│   ├── DeadDropManager.cs       # Dead drop selection, resolution, discovery
│   └── EventManager.cs          # Random event rolling, effects
├── Persistence/
│   ├── ConfigManager.cs         # Config load/hot-reload
│   └── SaveManager.cs           # Atomic JSON save/load
└── UI/
    └── NotificationHelper.cs    # In-game notification utilities
```

## Testing Guide

Use this checklist to verify every feature works. Play on a **single-player** save (host-only). Enable `DebugLogging: true` in config and watch the MelonLoader console (`F5` in-game or check console window).

### 1. Basic Scaling
- [ ] Start a new game, unlock a customer, and complete a few deliveries
- [ ] Verify order sizes gradually increase as addiction grows
- [ ] Check that the scaling feels different per customer based on relationship level

### 2. Tolerance System
- [ ] Deliver to the same customer repeatedly — check `saveData.json` that `Tolerance` is increasing
- [ ] Sleep for several days without delivering — verify tolerance decays (check save data)
- [ ] Deliver low-quality product to a high-tolerance customer — satisfaction should be lower than expected (QualityExpectationShift)

### 3. Binge Orders
- [ ] With default 5% chance, watch for occasional unusually large orders (2.5x multiplier)
- [ ] Check MelonLoader console for "binge" log messages

### 4. Pricing Engine
- [ ] Verify payments vary slightly between deliveries (MarketFluctuationRange = 15%)
- [ ] After 5/15/50/100 deals with one customer, check that discounts are applied (payments decrease)
- [ ] Highly addicted customers should pay a premium (AddictionPricePremium = 10%)

### 5. Dead Drop Contracts
- [ ] Build a customer to relationship ≥ 0.4, tolerance ≥ 0.3, and 5+ lifetime deals
- [ ] When they next generate a contract, the delivery location should change to a dead drop
- [ ] Check that some deals are prepaid and some are async (async should have higher payment)
- [ ] Complete a dead drop delivery — verify `TotalDeadDropsCompleted` increments in save data
- [ ] Fail a dead drop (let it expire) — verify `TotalDeadDropsFailed` increments

### 6. Dead Drop Risks
- [ ] Watch for theft events on dead drops (3% base chance) — customer should lose product
- [ ] Watch for non-payment events (8% base chance) — you should lose revenue
- [ ] Watch for police interception (2% base chance × heat) — relationship penalty
- [ ] Repeat dead drops to build heat — verify police chance increases
- [ ] Sleep for several days — verify heat decays over time

### 7. Discovery Quests
- [ ] When a customer first becomes dead-drop eligible, discovery quests should auto-spawn
- [ ] Check for new dead drop collection quests in the quest log
- [ ] Verify discovered dead drops are tracked in save data

### 8. Wholesale Deals
- [ ] Build a customer to relationship ≥ 0.7, tolerance ≥ 0.5, and 20+ completed deals
- [ ] Sleep — the customer should activate as a wholesale buyer
- [ ] Sleep through another week — verify weekly wholesale revenue is generated
- [ ] Check `TotalWholesaleRevenue` increments in save data statistics
- [ ] Check `WholesaleRecords` list grows in save data

### 9. Random Events
- [ ] Play for several in-game weeks — watch for police crackdowns (2% per week per region)
- [ ] During a crackdown: orders in that region should be reduced (~50%), dead drop police risk tripled
- [ ] Watch for supply shortages (5% per week per region)
- [ ] During a shortage: orders reduced (~60%), prices increased (~40%)
- [ ] Check active events in save data

### 10. Overdose System
- [ ] Deliver to customers repeatedly — watch for overdose events (0.2% base chance)
- [ ] On overdose: customer should be hospitalized for 5-10 days
- [ ] While hospitalized: customer should not receive new orders (gated out)
- [ ] On release: relationship should decrease
- [ ] Trigger a second overdose on the same customer — additional relationship hit
- [ ] Trigger a third overdose (if ThirdOverdosePermanentRefusal is true) — customer permanently refuses

### 11. Hospitalized/Refusing Customer Gating
- [ ] Hospitalized customers should not get new contracts
- [ ] Customers with overdose refusal should not get new contracts
- [ ] Verify `IsCustomerAvailable` check works (check debug logs)

### 12. Event Order Reduction
- [ ] During a crackdown or shortage, verify order quantities are reduced
- [ ] Check debug logs for "order reduction" messages

### 13. Config Hot-Reload
- [ ] While in-game, edit `config.json` (e.g., change `DebugLogging` to `true` or adjust `BingeOrderChance`)
- [ ] Sleep in-game
- [ ] Verify the new config values take effect (check MelonLoader console for config reload message)

### 14. Save/Load Persistence
- [ ] Play for a while, then close the game
- [ ] Verify `saveData.json` exists and contains customer profiles, dead drop states, etc.
- [ ] Relaunch the game — verify state persists (customer tolerance, wholesale status, etc.)

### 15. Multiplayer Host Check
- [ ] If testing multiplayer, verify the mod only runs economy logic on the host
- [ ] Non-host clients should not trigger scaling/events (check logs)

## Technical Details

- **.NET Framework 4.7.2**, C# 7.3
- **HarmonyLib 2.10.2** for runtime patching
- **Newtonsoft.Json 13.0.3** for serialization
- **FishNet** multiplayer — all economy logic is host-authoritative
- 6 Harmony patches: `GetWeightedRandomProduct`, `ChangeAddiction`, `EvaluateDelivery`, `TryGenerateContract`, `TimeManager.EndSleep`, `MoneyManager.ChangeCashBalance`
- Atomic JSON saves (write temp → `File.Move`) to prevent corruption

## License

This project is provided as-is for educational and personal use.