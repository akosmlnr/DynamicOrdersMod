## Two changes: (1) Hook game save, (2) Comprehensive DebugLogging

### Part 1 — Mod saves whenever the game saves

**New file:** `Patches/SaveManagerPatches.cs`
- `[HarmonyPatch(typeof(Il2CppScheduleOne.Persistence.SaveManager), "Save")]` Postfix → calls `DynamicEconomyCore.Instance.OnGameSave()`
- Also patch the `Save(string)` overload to catch folder-targeted saves
- Host-only guard inside `OnGameSave` (clients shouldn't write mod save independently)
- Existing `OnDayEnd` save stays — it's still the authoritative day-end flush

**`Core/DynamicEconomyCore.cs`** — add:
```csharp
public void OnGameSave()
{
    if (!IsInitialized) return;
    if (!IsHost()) return;
    try { SaveManager.Save(); }
    catch (System.Exception ex) { MelonLogger.Error($"[DynamicOrdersMod] OnGameSave error: {ex.Message}"); }
}
```

**`DynamicOrdersMod.csproj`** — add `<Compile Include="Patches\SaveManagerPatches.cs" />`

### Part 2 — Comprehensive DebugLogging

**New file:** `Core/DebugLog.cs` — tiny centralized helper to avoid `if (DebugLogging) MelonLogseer.Msg(...)` repetition everywhere:
```csharp
public static class DebugLog
{
    public static bool Enabled => ConfigManager.Config?.General?.DebugLogging ?? false;
    public static void Msg(string tag, string msg)  { if (Enabled) MelonLogger.Msg($"[DOM] {tag} {msg}"); }
    public static void Warn(string tag, string msg) { if (Enabled) MelonLogger.Warning($"[DOM] {tag} {msg}"); }
    public static string Short(string guid) => string.IsNullOrEmpty(guid) ? "????????" : guid.Length <= 8 ? guid : guid.Substring(0, 8);
}
```
Tag format: `[DOM] [a1b2c3d4] <event> <details>` (matches your answer). When `DebugLogging=false`, zero overhead (single bool check).

**Log points to add** (all gated via `DebugLog.Msg`):

| File | Function | Log |
|---|---|---|
| `CustomerPatches.cs` | `GetWeightedRandomProductPostfix` | `[cust GUID] product=Heroin base_qty=2 → addiction_bonus=+1.8 rel_bonus=+0.3 tol_bonus=+0.5 rng_var=+0.12 binge=NO wholesale=NO → scaled=7` (full multiplier breakdown) |
| `CustomerPatches.cs` | `ChangeAddictionPostfix` | `[cust GUID] ChangeAddiction original=+0.05 modified=+0.04 (tolerance_modifier=0.8)` |
| `CustomerPatches.cs` | `EvaluateDeliveryPostfix` | `[cust GUID] delivery matched=3/3 payment=$120 satisfaction=0.85 qualityDiff=+0.2 highestAddiction=0.6` |
| `CustomerPatches.cs` | `EvaluateDeliveryPostfix` (overdose roll) | `[cust GUID] overdose roll: chance=0.012 rolled=0.453 → NO` (or `→ YES`) |
| `CustomerPatches.cs` | `TryGenerateContractPostfix` | `[cust GUID] dead drop contract: prepaid=true payment=$340 drop=drop_guid_8` (and skip reasons: `skipped: rel<0.4`, `skipped: tolerance<0.3`, `skipped: existing deal`) |
| `TimeManagerPatches.cs` | `StartSleep Postfix` | `[day=N] OnDayEnd fired` |
| `SaveManagerPatches.cs` (new) | `Save Postfix` | `[save] game save triggered, mod flushed N profiles, M deals` |
| `DynamicEconomyCore.cs` | `OnDayEnd` | `[day=N] decay: applied to N profiles (addiction_factor avg=0.7)` |
| `DynamicEconomyCore.cs` | `ResolveSingleDeal` | (existing log enhanced) `[deal ID] resolved: outcome=success payment=$X qty=3/5 quality=Premium rel_delta=+0.05` |
| `DynamicEconomyCore.cs` | `ProcessWeeklyWholesale` | (existing log enhanced) `[week=N] wholesale: processed N customers, revenue=$X` |
| `EventManager.cs` | `RollDailyEvents` | `[day=N] rolled: crackdown_chance=0.003 (NO), shortage_chance=0.007 (YES: Cocaine, 6 days)` |
| `EventManager.cs` | `RemoveExpiredEvents` | `[day=N] expired N events` |
| `EventManager.cs` | `CalculateOverdoseChance` | (called from patch already logs the roll; this logs the component breakdown if needed) — leave to patch to avoid double-logging |
| `EventManager.cs` | `ResolveOverdose` | `[cust GUID] OVERDOSE count=N hospitalized_days=M release_day=D grace_until=G` |
| `CustomerProfileManager.cs` | `ApplyToleranceGrowth` | `[cust GUID] tolerance +X (gain=0.01 * ratio=2.0 * dep=0.5)` |
| `CustomerProfileManager.cs` | `UpdateHospitalization` | `[cust GUID] HOSPITAL RELEASED hit=X applied=true/false` (existing log, converted to DebugLog format) |
| `CustomerProfileManager.cs` | `ApplyPendingRelationshipHit` | `[cust GUID] pending relationship hit applied: -X` |
| `DeadDropManager.cs` | `EvaluateDelivery` | `[drop GUID] delivery: qty=3/5 highest_quality=Premium wrong_product=false` |
| `DeadDropManager.cs` | `SelectDropForAsync` | `[drop GUID] selected (heat=0.12)` |
| `DeadDropManager.cs` | `AddHeat` / `ReleaseDrop` | `[drop GUID] heat +X → Y` / `released` |
| `DeadDropManager.cs` | `InitializeDeadDropStates` | `[init] registered N drops (new=M, existing=K)` |
| `DeadDropManager.cs` | `TrySpawnDiscoveryQuests` | `[cust GUID] discovery: N quests spawned` |
| `PricingEngine.cs` | `CalculateCustomerPrice` | `[cust GUID] price: base=$50 * loyalty=0.88 * addiction=1.10 * market=1.05 * event=1.00 → $50.7` (called from patch, log there with cust context) |

**Skip reasons** (important for debugging why scaling/contracts aren't firing): every `return` in a postfix that bails early logs why — `skipped: customer not available`, `skipped: not host`, `skipped: orderableQuantity<=1`, etc. This is the #1 thing you need to see when "nothing is happening."

### Files touched
- **New:** `Core/DebugLog.cs`, `Patches/SaveManagerPatches.cs`
- **Modified:** `DynamicOrdersMod.csproj`, `Core/DynamicEconomyCore.cs`, `Core/ModEntry.cs` (no change — already calls PatchAll), `Persistence/SaveManager.cs` (no change), `Patches/CustomerPatches.cs`, `Patches/TimeManagerPatches.cs`, `Systems/EventManager.cs`, `Systems/CustomerProfileManager.cs`, `Systems/DeadDropManager.cs`, `Systems/PricingEngine.cs`

### Backward compat
- No config schema change — uses existing `General.DebugLogging` flag
- No save data migration — pure observability layer
- When `DebugLogging=false`: zero allocations, zero Il2Cpp calls beyond the single bool check per site

### Verification
After implementing: pull on PC, set `"DebugLogging": true` in `%APPDATA%\DynamicOrdersMod\v3\config.json`, launch, and you should see a log line for every single mod event. Sleep in-game → day-end processing logs. Deliver product → scaling/tolerance/overdose logs. Game auto-saves → `[save]` log.

### Execution order
1. Create `DebugLog.cs` helper
2. Create `SaveManagerPatches.cs` + `OnGameSave` method
3. Update csproj with new files
4. Wire DebugLog calls into each system/patch (one file at a time, commit per logical group)
5. Single squashed commit at end (or 3-4 small commits — your call)