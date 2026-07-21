# DynamicOrdersMod v3 Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Rewrite DynamicOrdersMod v3 from scratch with dynamic order scaling, dead drop deliveries, tolerance, wholesale customers, pricing, and random events.

**Architecture:** Central `DynamicEconomyCore` singleton owns all subsystems. Six thin Harmony patches route game calls into the core. Deterministic, host-authority for multiplayer. JSON config with hot-reload.

**Tech Stack:** C# (.NET Framework 4.7.2), MelonLoader 0.7.x, HarmonyLib 2.10.2, Il2CppInterop, Newtonsoft.Json 13.0.3, FishNet (host detection only).

**Design Spec:** `docs/superpowers/specs/2026-07-21-dynamic-orders-v3-design.md`

**Game API Reference:** Decompiled stubs in `Assembly-CSharp/` (method bodies are stubs — only signatures/fields are reliable).

---

## Performance & Bug-Safety Rules (Apply to EVERY Task)

1. **Every Harmony patch method wraps in try-catch.** Log the exception, return without modifying state. A mod bug must never crash the game.
2. **Null-check every `__instance` parameter** at the top of every patch.
3. **Check `DynamicEconomyCore.Instance != null`** before accessing any system.
4. **Use `Dictionary.TryGetValue`** — never `[]` indexer for lookups that may miss.
5. **No allocations in hot paths.** `GetWeightedRandomProduct` and `ChangeAddiction` postfixes: no `new`, no string concat, no LINQ. Use cached `System.Random`, not `UnityEngine.Random` (which boxes).
6. **EndSleep is the only place** allowed to do file I/O, heavy computation, or full collection iteration.
7. **All float math uses clamping** — no NaN/Infinity propagation.
8. **Save data is written atomically:** write to temp file, then `File.Move`. Prevents corruption on crash.

---

## Phase 1: Foundation + Scaling/Tolerance

This phase produces a working mod that scales order quantities based on addiction, relationship, and tolerance.

### Task 1: Project Setup

**Files:**
- Delete: `BudgetManager.cs`, `CustomerDataPatches.cs`, `DataManager.cs`, `Models.cs`, `TimeManagerPatches.cs`
- Modify: `DynamicOrdersMod.csproj` (update Compile items, add AllowUnsafeBlocks)
- Modify: `Properties/AssemblyInfo.cs` (v3.0.0.0, new MelonInfo)
- Create: `Core/Constants.cs`, `Core/ModEntry.cs` (skeleton), `Core/DynamicEconomyCore.cs`
- Create: Empty stubs for all other files (namespace only, so it compiles)

- [ ] **Step 1: Delete all v2 source files except Properties/AssemblyInfo.cs**

- [ ] **Step 2: Update csproj** — Replace the `<Compile>` ItemGroup with all v3 files listed below. Add `<AllowUnsafeBlocks>true</AllowUnsafeBlocks>` to the main PropertyGroup.

Compile list:
```
Core\Constants.cs
Core\ModEntry.cs
Core\DynamicEconomyCore.cs
Models\CustomerProfile.cs
Models\DeadDropState.cs
Models\ModConfig.cs
Models\ModSaveData.cs
Models\ActiveEvent.cs
Models\WholesaleRecord.cs
Persistence\ConfigManager.cs
Persistence\SaveManager.cs
Systems\ScalingEngine.cs
Systems\CustomerProfileManager.cs
Systems\PricingEngine.cs
Systems\DeadDropManager.cs
Systems\EventManager.cs
Patches\CustomerPatches.cs
Patches\TimeManagerPatches.cs
Patches\MoneyManagerPatches.cs
UI\NotificationHelper.cs
Properties\AssemblyInfo.cs
```

- [ ] **Step 3: Create empty namespace stubs** for every file above so the project compiles. Each file gets only its namespace declaration. Example:
```csharp
namespace DynamicOrdersMod.Models { }
```

- [ ] **Step 4: Write `Core/Constants.cs`**
```csharp
using System.IO;

namespace DynamicOrdersMod.Core
{
    public static class Constants
    {
        public const int SaveVersion = 3;
        public const int ConfigVersion = 1;

        public static readonly string ModSaveDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "DynamicOrdersMod", "v3");

        public static readonly string SaveFilePath = Path.Combine(ModSaveDir, "saveData.json");
        public static readonly string ConfigFilePath = Path.Combine(ModSaveDir, "config.json");
        public static readonly string TempSaveFilePath = Path.Combine(ModSaveDir, "saveData.json.tmp");
    }
}
```

- [ ] **Step 5: Write skeleton `Core/ModEntry.cs`**
```csharp
using MelonLoader;
using HarmonyLib;

namespace DynamicOrdersMod.Core
{
    public class ModEntry : MelonMod
    {
        public static ModEntry Instance { get; private set; }

        public override void OnInitializeMelon()
        {
            Instance = this;
            LoggerInstance.Msg("[DynamicOrdersMod v3] Initializing...");

            DynamicEconomyCore.Initialize();

            var harmony = new Harmony("com.akosmlnr.dynamicordersmod.v3");
            harmony.PatchAll();
            LoggerInstance.Msg("[DynamicOrdersMod v3] Patches applied. All systems ready.");
        }
    }
}
```

- [ ] **Step 6: Write skeleton `Core/DynamicEconomyCore.cs`** (will be expanded in Task 6)
```csharp
using MelonLoader;
using DynamicOrdersMod.Persistence;

namespace DynamicOrdersMod.Core
{
    public class DynamicEconomyCore
    {
        public static DynamicEconomyCore Instance { get; private set; }

        public static void Initialize()
        {
            if (Instance != null) return;
            Instance = new DynamicEconomyCore();

            ConfigManager.Load();
            SaveManager.Load();

            MelonLogger.Msg("[DynamicOrdersMod] Core initialized.");
        }

        public void OnDayEnd(int currentDay)
        {
            // Will be expanded in later tasks
        }
    }
}
```

- [ ] **Step 7: Update `Properties/AssemblyInfo.cs`** — Version `3.0.0.0`, MelonInfo name `"DynamicOrdersMod"`.

- [ ] **Step 8: Build and verify** the mod compiles with no errors.

- [ ] **Step 9: Commit**
```
git commit -m "chore: v3 project setup — delete v2, scaffold structure"
```

---

### Task 2: Models (All POCOs)

**Files:**
- Write: `Models/CustomerProfile.cs`
- Write: `Models/DeadDropState.cs`
- Write: `Models/ModConfig.cs`
- Write: `Models/ModSaveData.cs`
- Write: `Models/ActiveEvent.cs`
- Write: `Models/WholesaleRecord.cs`

- [ ] **Step 1: Write `Models/CustomerProfile.cs`**

```csharp
using System;
using System.Collections.Generic;

namespace DynamicOrdersMod.Models
{
    [Serializable]
    public class PurchaseRecord
    {
        public int Day;
        public string DrugType;
        public int Quantity;
        public float TotalSpent;
    }

    [Serializable]
    public class CustomerProfile
    {
        public string CustomerGuid;
        public float Tolerance;
        public float ScalingMultiplier;
        public int LifetimeDeals;
        public int SuccessfulDeals;
        public int FailedDeals;
        public bool IsWholesale;
        public int WholesaleWeeksActive;
        public int OverdoseCount;
        public int LastOverdoseDay;
        public bool IsHospitalized;
        public int HospitalReleaseDay;
        public int LastOverdoseRefusalDay;
        public List<string> DiscoveredDeadDrops = new List<string>();
        public int LastDeadDropFailDay;
        public List<PurchaseRecord> PurchaseHistory = new List<PurchaseRecord>();
        private const int MaxHistoryEntries = 50;

        public void RecordPurchase(int day, string drugType, int quantity, float totalSpent)
        {
            PurchaseHistory.Add(new PurchaseRecord
            {
                Day = day, DrugType = drugType, Quantity = quantity, TotalSpent = totalSpent
            });
            LifetimeDeals++;
            if (PurchaseHistory.Count > MaxHistoryEntries)
                PurchaseHistory.RemoveAt(0);
        }

        public void RecordSuccess() => SuccessfulDeals++;
        public void RecordFailure() => FailedDeals++;
    }
}
```

- [ ] **Step 2: Write `Models/DeadDropState.cs`**

```csharp
using System;

namespace DynamicOrdersMod.Models
{
    [Serializable]
    public class DeadDropState
    {
        public string DropGuid;
        public string DropName;
        public string Region;
        public float Heat;
        public bool IsDiscovered;
        public bool IsOccupied;
    }
}
```

- [ ] **Step 3: Write `Models/ModConfig.cs`**

Contains all config POCOs with defaults matching the design spec. Key classes: `ModConfig` (root), `ScalingConfig`, `ToleranceConfig`, `DeadDropConfig`, `PricingConfig` (with `DiscountTier`), `WholesaleConfig`, `EventsConfig` (with `IntRange`), `OverdoseConfig`, `GeneralConfig`. All fields have defaults matching the spec values. See the design spec `docs/superpowers/specs/2026-07-21-dynamic-orders-v3-design.md` for exact default values in each config section.

- [ ] **Step 4: Write `Models/ModSaveData.cs`**

```csharp
using System;
using System.Collections.Generic;

namespace DynamicOrdersMod.Models
{
    [Serializable]
    public class ModSaveData
    {
        public int Version;
        public Dictionary<string, CustomerProfile> CustomerProfiles = new Dictionary<string, CustomerProfile>();
        public Dictionary<string, DeadDropState> DeadDropStates = new Dictionary<string, DeadDropState>();
        public List<ActiveEvent> ActiveEvents = new List<ActiveEvent>();
        public ModStatistics Statistics = new ModStatistics();
    }

    [Serializable]
    public class ModStatistics
    {
        public int TotalDeadDropsCompleted;
        public int TotalDeadDropsFailed;
        public int TotalOverdoses;
        public float TotalWholesaleRevenue;
    }
}
```

- [ ] **Step 5: Write `Models/ActiveEvent.cs`**

```csharp
using System;

namespace DynamicOrdersMod.Models
{
    public enum ActiveEventType { PoliceCrackdown, SupplyShortage }

    [Serializable]
    public class ActiveEvent
    {
        public ActiveEventType Type;
        public int StartDay;
        public int EndDay;
        public string Region;    // For PoliceCrackdown
        public string DrugType;  // For SupplyShortage
    }
}
```

- [ ] **Step 6: Write `Models/WholesaleRecord.cs`**

```csharp
using System;

namespace DynamicOrdersMod.Models
{
    [Serializable]
    public class WholesaleRecord
    {
        public int Week;
        public string CustomerGuid;
        public float Amount;
    }
}
```

- [ ] **Step 7: Build and verify. Commit.**
```
git commit -m "feat: add all model POCOs with defaults"
```

---

### Task 3: ConfigManager + SaveManager

**Files:**
- Write: `Persistence/ConfigManager.cs`
- Write: `Persistence/SaveManager.cs`

- [ ] **Step 1: Write `Persistence/ConfigManager.cs`**

Key behaviors:
- `Load()` — reads `config.json`. If missing, writes defaults and returns them.
- `Reload()` — re-reads file (called on EndSleep for hot-reload).
- `ModConfig Config` static property.
- Default config written on first load.
- Uses `Newtonsoft.Json.JsonConvert`.

```csharp
using System.IO;
using MelonLoader;
using Newtonsoft.Json;
using DynamicOrdersMod.Core;
using DynamicOrdersMod.Models;

namespace DynamicOrdersMod.Persistence
{
    public static class ConfigManager
    {
        public static ModConfig Config { get; private set; }

        public static void Load()
        {
            try
            {
                if (!Directory.Exists(Constants.ModSaveDir))
                    Directory.CreateDirectory(Constants.ModSaveDir);

                if (File.Exists(Constants.ConfigFilePath))
                {
                    var json = File.ReadAllText(Constants.ConfigFilePath);
                    Config = JsonConvert.DeserializeObject<ModConfig>(json) ?? new ModConfig();
                }
                else
                {
                    Config = new ModConfig();
                    WriteDefaults();
                }
                MelonLogger.Msg($"[DynamicOrdersMod] Config loaded. Enabled={Config.General.Enabled}");
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] Config load failed: {ex.Message}");
                Config = new ModConfig();
            }
        }

        public static void Reload()
        {
            try
            {
                if (File.Exists(Constants.ConfigFilePath))
                {
                    var json = File.ReadAllText(Constants.ConfigFilePath);
                    Config = JsonConvert.DeserializeObject<ModConfig>(json) ?? new ModConfig();
                    if (Config.General.DebugLogging)
                        MelonLogger.Msg("[DynamicOrdersMod] Config reloaded.");
                }
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] Config reload failed: {ex.Message}");
            }
        }

        private static void WriteDefaults()
        {
            try
            {
                var json = JsonConvert.SerializeObject(Config, Formatting.Indented);
                File.WriteAllText(Constants.ConfigFilePath, json);
                MelonLogger.Msg($"[DynamicOrdersMod] Default config written to {Constants.ConfigFilePath}");
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] Failed to write default config: {ex.Message}");
            }
        }
    }
}
```

- [ ] **Step 2: Write `Persistence/SaveManager.cs`**

Key behaviors:
- `Load()` — reads `saveData.json`. If missing, returns empty `ModSaveData`. If version mismatch, starts fresh.
- `Save()` — atomic write: serialize to temp file, `File.Copy` over real file, delete temp.
- `ModSaveData Data` static property.

```csharp
using System.IO;
using MelonLoader;
using Newtonsoft.Json;
using DynamicOrdersMod.Core;
using DynamicOrdersMod.Models;

namespace DynamicOrdersMod.Persistence
{
    public static class SaveManager
    {
        public static ModSaveData Data { get; private set; } = new ModSaveData();

        public static void Load()
        {
            try
            {
                if (File.Exists(Constants.SaveFilePath))
                {
                    var json = File.ReadAllText(Constants.SaveFilePath);
                    var data = JsonConvert.DeserializeObject<ModSaveData>(json);
                    if (data != null && data.Version == Constants.SaveVersion)
                    {
                        Data = data;
                        MelonLogger.Msg($"[DynamicOrdersMod] Save loaded. {Data.CustomerProfiles.Count} customer profiles.");
                        return;
                    }
                    if (data != null && data.Version != Constants.SaveVersion)
                        MelonLogger.Warning($"[DynamicOrdersMod] Save version mismatch (got {data.Version}, want {Constants.SaveVersion}). Starting fresh.");
                }
                Data = new ModSaveData { Version = Constants.SaveVersion };
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] Save load failed: {ex.Message}");
                Data = new ModSaveData { Version = Constants.SaveVersion };
            }
        }

        public static void Save()
        {
            try
            {
                Data.Version = Constants.SaveVersion;
                var json = JsonConvert.SerializeObject(Data, Formatting.Indented);
                File.WriteAllText(Constants.TempSaveFilePath, json);
                File.Copy(Constants.TempSaveFilePath, Constants.SaveFilePath, true);
                if (File.Exists(Constants.TempSaveFilePath))
                    File.Delete(Constants.TempSaveFilePath);
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] Save failed: {ex.Message}");
            }
        }
    }
}
```

- [ ] **Step 3: Build and verify. Commit.**
```
git commit -m "feat: add ConfigManager (hot-reload) and SaveManager (atomic write)"
```

---

### Task 4: NotificationHelper + ScalingEngine

**Files:**
- Write: `UI/NotificationHelper.cs`
- Write: `Systems/ScalingEngine.cs`

- [ ] **Step 1: Write `UI/NotificationHelper.cs`**

Wraps `NotificationsManager.Instance.SendNotification()`. Null-checks the singleton. Catches exceptions. This is the ONLY way mod code sends notifications — never call the game's API directly from systems.

```csharp
using MelonLoader;

namespace DynamicOrdersMod.UI
{
    public static class NotificationHelper
    {
        public static void Send(string title, string subtitle, float duration = 5f)
        {
            try
            {
                var mgr = Il2CppScheduleOne.UI.NotificationsManager.Instance;
                if (mgr == null) return;
                mgr.SendNotification(title, subtitle, null, duration, true);
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] Notification failed: {ex.Message}");
            }
        }
    }
}
```

- [ ] **Step 2: Write `Systems/ScalingEngine.cs`**

Pure math class. No game API calls. No allocations in the hot `CalculateScaledQuantity` method.

```csharp
using System;
using DynamicOrdersMod.Models;

namespace DynamicOrdersMod.Systems
{
    public static class ScalingEngine
    {
        [ThreadStatic]
        private static System.Random _rng;
        private static System.Random Rng => _rng ?? (_rng = new System.Random());

        /// <summary>
        /// HOT PATH: No allocations. Returns scaled quantity.
        /// </summary>
        public static int CalculateScaledQuantity(
            int baseQuantity,
            float currentAddiction,
            float normalizedRelationship,
            float tolerance,
            ScalingConfig config)
        {
            if (baseQuantity <= 0) return baseQuantity;

            float addictionBonus = currentAddiction * config.AddictionWeight;
            float relationshipBonus = normalizedRelationship * config.RelationshipWeight;
            float toleranceBonus = tolerance * config.ToleranceWeight;

            float variability = (float)(Rng.NextDouble() * 2.0 - 1.0) * config.RandomVariability;
            bool isBinge = Rng.NextDouble() < config.BingeOrderChance;
            float bingeMult = isBinge ? config.BingeOrderMultiplier : 1f;

            float multiplier = (1f + addictionBonus + relationshipBonus + toleranceBonus)
                              * (1f + variability) * bingeMult;
            float scaled = baseQuantity * multiplier;

            if (scaled < 1f) scaled = 1f;
            if (scaled > 1000f) scaled = 1000f;

            return (int)scaled;
        }

        /// <summary>
        /// Computes the cached scaling multiplier for a customer profile. Called from EndSleep.
        /// </summary>
        public static float ComputeScalingMultiplier(
            float currentAddiction,
            float normalizedRelationship,
            float tolerance,
            ScalingConfig config)
        {
            float bonus = currentAddiction * config.AddictionWeight
                        + normalizedRelationship * config.RelationshipWeight
                        + tolerance * config.ToleranceWeight;
            return 1f + bonus;
        }
    }
}
```

- [ ] **Step 3: Build and verify. Commit.**
```
git commit -m "feat: add NotificationHelper and ScalingEngine"
```

---

### Task 5: CustomerProfileManager

**Files:**
- Write: `Systems/CustomerProfileManager.cs`

- [ ] **Step 1: Write the file**

Key methods:
- `GetOrCreateProfile(string customerGuid)` — returns existing or creates default. Uses `TryGetValue`.
- `ApplyToleranceGrowth(profile, quantity, baseQuantity, dependenceMultiplier)` — called from EvaluateDelivery postfix. No allocations.
- `ModifyAddictionDelta(profile, originalDelta)` — called from ChangeAddiction postfix. No allocations.
- `ApplyDailyDecay(currentDay)` — called from EndSleep. Can allocate.
- `UpdateHospitalization(profile, currentDay)` — called from EndSleep.
- `IsCustomerAvailable(profile, currentDay)` — checks hospitalization, overdose refusal.

```csharp
using System;
using MelonLoader;
using DynamicOrdersMod.Models;
using DynamicOrdersMod.Persistence;

namespace DynamicOrdersMod.Systems
{
    public static class CustomerProfileManager
    {
        /// <summary>
        /// Get or create a customer profile. Hot path: must be fast.
        /// </summary>
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

        /// <summary>
        /// Called from EvaluateDelivery postfix. No allocations.
        /// </summary>
        public static void ApplyToleranceGrowth(
            CustomerProfile profile, int quantity, int baseQuantity, float dependenceMultiplier)
        {
            if (profile == null || baseQuantity <= 0) return;
            float configGain = ConfigManager.Config.Tolerance.GainPerDelivery;
            float ratio = (float)quantity / baseQuantity;
            if (ratio <= 1f) return;
            float gain = (ratio - 1f) * configGain * dependenceMultiplier;
            profile.Tolerance = Clamp01(profile.Tolerance + gain);
        }

        /// <summary>
        /// Called from ChangeAddiction postfix. No allocations.
        /// </summary>
        public static float ModifyAddictionDelta(CustomerProfile profile, float originalDelta)
        {
            if (profile == null || originalDelta <= 0f) return originalDelta;
            float modifier = 1f - profile.Tolerance * 0.5f;
            return originalDelta * modifier;
        }

        /// <summary>
        /// Called from EndSleep. Can allocate.
        /// </summary>
        public static void ApplyDailyDecay(int currentDay)
        {
            if (SaveManager.Data == null) return;
            float decayBase = ConfigManager.Config.Tolerance.DailyDecayBase;

            foreach (var profile in SaveManager.Data.CustomerProfiles.Values)
            {
                float decay = decayBase; // neutral estimate without live addiction access
                if (decay > 0f && profile.Tolerance > 0f)
                    profile.Tolerance = Clamp01(profile.Tolerance - decay);

                UpdateHospitalization(profile, currentDay);
            }
        }

        private static void UpdateHospitalization(CustomerProfile profile, int currentDay)
        {
            if (profile.IsHospitalized && currentDay >= profile.HospitalReleaseDay)
            {
                profile.IsHospitalized = false;
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

        private static float Clamp01(float v)
        {
            if (v < 0f) return 0f;
            return v > 1f ? 1f : v;
        }
    }
}
```

- [ ] **Step 2: Build and verify. Commit.**
```
git commit -m "feat: add CustomerProfileManager with tolerance growth/decay"
```

---

### Task 6: Wire Up Scaling — Core, Patches, ModEntry

**Files:**
- Expand: `Core/DynamicEconomyCore.cs`
- Expand: `Patches/CustomerPatches.cs`
- Write: `Patches/TimeManagerPatches.cs`
- Write: `Patches/MoneyManagerPatches.cs` (stub)

This is the task where scaling actually starts working in-game.

- [ ] **Step 1: Expand `Core/DynamicEconomyCore.cs`**

Add `IsInitialized`, `ScalingEnabled`, `OnDayEnd` with host check, config reload, tolerance decay, and save.

```csharp
using MelonLoader;
using DynamicOrdersMod.Persistence;
using DynamicOrdersMod.Systems;

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
                ConfigManager.Reload();
                CustomerProfileManager.ApplyDailyDecay(currentDay);
                SaveManager.Save();
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] OnDayEnd error: {ex.Message}");
            }
        }

        private static bool IsHost()
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
```

- [ ] **Step 2: Write `Patches/CustomerPatches.cs`** — GetWeightedRandomProduct and ChangeAddiction.

**Critical:** `GetWeightedRandomProduct` is a hot path. Zero allocations. The `ref int orderableQuantity` parameter must match the game's actual parameter name from the decompiled signature.

```csharp
using System;
using HarmonyLib;
using Il2CppScheduleOne.Economy;
using MelonLoader;
using DynamicOrdersMod.Core;
using DynamicOrdersMod.Systems;
using DynamicOrdersMod.Persistence;

namespace DynamicOrdersMod.Patches
{
    public static class CustomerPatches
    {
        [HarmonyPatch(typeof(Customer), "GetWeightedRandomProduct")]
        [HarmonyPostfix]
        static void GetWeightedRandomProductPostfix(
            Customer __instance,
            ref float appeal,
            ref int orderableQuantity)
        {
            try
            {
                if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true) return;
                if (__instance == null || orderableQuantity <= 1) return;

                var profile = CustomerProfileManager.GetOrCreateProfile(
                    __instance.NPC?.GUID.ToString());
                if (profile == null) return;

                float addiction = __instance.CurrentAddiction;
                float normalizedRel = 0f;
                try { normalizedRel = __instance.NPC?.RelationData?.NormalizedRelationDelta ?? 0f; }
                catch { }

                int scaled = ScalingEngine.CalculateScaledQuantity(
                    orderableQuantity, addiction, normalizedRel, profile.Tolerance,
                    ConfigManager.Config.Scaling);

                if (scaled != orderableQuantity) orderableQuantity = scaled;
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] GetWeightedRandomProduct error: {ex.Message}");
            }
        }

        [HarmonyPatch(typeof(Customer), "ChangeAddiction")]
        [HarmonyPostfix]
        static void ChangeAddictionPostfix(Customer __instance, ref float amount)
        {
            try
            {
                if (!DynamicEconomyCore.Instance?.ScalingEnabled ?? true) return;
                if (__instance == null || amount <= 0f) return;

                var profile = CustomerProfileManager.GetOrCreateProfile(
                    __instance.NPC?.GUID.ToString());
                if (profile == null) return;

                float modified = CustomerProfileManager.ModifyAddictionDelta(profile, amount);
                if (modified != amount) amount = modified;
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] ChangeAddiction error: {ex.Message}");
            }
        }
    }
}
```

- [ ] **Step 3: Write `Patches/TimeManagerPatches.cs`**

```csharp
using System;
using HarmonyLib;
using Il2CppScheduleOne.GameTime;
using MelonLoader;
using DynamicOrdersMod.Core;

namespace DynamicOrdersMod.Patches
{
    [HarmonyPatch(typeof(TimeManager), "EndSleep")]
    public static class TimeManagerPatches
    {
        static void Postfix(TimeManager __instance)
        {
            try
            {
                if (DynamicEconomyCore.Instance == null) return;
                int currentDay = 0;
                try { currentDay = __instance.ElapsedDays; } catch { }
                DynamicEconomyCore.Instance.OnDayEnd(currentDay);
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] EndSleep error: {ex.Message}");
            }
        }
    }
}
```

- [ ] **Step 4: Write `Patches/MoneyManagerPatches.cs`** (stub for Phase 3)

```csharp
using HarmonyLib;
using Il2CppScheduleOne.Money;

namespace DynamicOrdersMod.Patches
{
    [HarmonyPatch(typeof(MoneyManager), "ChangeCashBalance")]
    public static class MoneyManagerPatches
    {
        static void Postfix(MoneyManager __instance, float change, bool visualizeChange, bool playCashSound)
        {
            // Phase 3: wholesale revenue tracking
        }
    }
}
```

- [ ] **Step 5: Build and verify. Commit.**
```
git commit -m "feat: Phase 1 complete — scaling engine with tolerance, patches wired"
```

---

## Phase 2: Dead Drop System

### Task 7: DeadDropManager + Dead Drop Patches

**Files:**
- Write: `Systems/DeadDropManager.cs`
- Modify: `Patches/CustomerPatches.cs` (add TryGenerateContract prefix)
- Modify: `Core/DynamicEconomyCore.cs` (add dead drop processing to OnDayEnd)

- [ ] **Step 1: Write `Systems/DeadDropManager.cs`**

~200 lines. Key methods:
- `InitializeDeadDropStates()` — scans `DeadDrop.DeadDrops` static list, creates `DeadDropState` for any not in save data
- `GetDiscoveredDrops()` — filters `DeadDropStates` where `IsDiscovered && !IsOccupied`
- `GetDropForPrepaid(Vector3 customerPosition)` — calls `DeadDrop.GetRandomEmptyDrop()`, returns its GUID, marks occupied
- `SelectDropForAsync(string customerGuid)` — returns discovered drop with lowest heat, marks occupied
- `ResolveDeadDrop(string dropGuid, bool isPrepaid)` — rolls events (theft/non-payment/police), applies relationship changes, clears occupied
- `UpdateHeat()` — iterates all drops, decays heat, removes expired active events
- `UpdateMapLabels()` — if config enabled, updates `DeadDrop.PoI.SetMainText()` with heat level
- `MarkDropDiscovered(string dropGuid)` — sets `IsDiscovered = true`

Event roll follows spec exactly:
- Theft: 3% chance, -0.5 relationship, heat +0.3
- Non-payment (async only): 8% chance, 30-60% payment, -0.15 relationship
- Police intercept: 2% × (1 + heat) chance, law intensity +5%, -0.3 relationship, heat +0.5
- Success: +0.05 relationship, heat -0.1

- [ ] **Step 2: Add `TryGenerateContract` prefix to `Patches/CustomerPatches.cs`**

Check: mod enabled + dead drops enabled + customer eligible (relationship ≥ min, not hospitalized, quantity ≥ threshold). If all met: create `ContractInfo` with dead drop GUID as `DeliveryLocationGUID`, return `true` to skip original. Otherwise: return `false`.

- [ ] **Step 3: Add discovery quest creation**

When a customer first becomes eligible for dead drops, create a quest using the game's `Quest` system. Quest entries point to undiscovered `DeadDrop` transforms. On completion, `IsDiscovered = true`.

- [ ] **Step 4: Update `DynamicEconomyCore.OnDayEnd`** to call `DeadDropManager.InitializeDeadDropStates()` (first call), `DeadDropManager.UpdateHeat()`, `DeadDropManager.UpdateMapLabels()`.

- [ ] **Step 5: Build, test in-game, commit.**
```
git commit -m "feat: Phase 2 complete — dead drop orders with events, heat, discovery"
```

---

## Phase 3: Wholesale + Pricing

### Task 8: PricingEngine

**Files:**
- Write: `Systems/PricingEngine.cs`

- [ ] **Step 1: Write the file.** Pure math, no game API. Methods: `GetDiscountRate(quantity)`, `CalculateSuggestedPrice(basePrice, quantity, addiction)`, `GetPriceSatisfactionModifier(offered, suggested)`.

- [ ] **Step 2: Build and commit.**
```
git commit -m "feat: add PricingEngine with volume discounts and negotiation modifiers"
```

### Task 9: Wholesale System

**Files:**
- Modify: `Systems/CustomerProfileManager.cs` (add wholesale check)
- Modify: `Core/DynamicEconomyCore.cs` (add weekly processing)
- Modify: `Patches/CustomerPatches.cs` (wholesale quantity multiplier)

- [ ] **Step 1: Add wholesale promotion logic** to CustomerProfileManager. Check eligibility (relationship ≥ 0.7, deals ≥ 20, tolerance ≥ 0.5) in EndSleep loop.

- [ ] **Step 2: Add weekly wholesale revenue** to DynamicEconomyCore. On week boundary (currentDay % 7 == 0), iterate wholesale customers, calculate revenue cut, add via `MoneyManager.Instance.ChangeCashBalance()`.

- [ ] **Step 3: Add wholesale quantity multiplier** in GetWeightedRandomProductPostfix. If customer is wholesale, multiply scaled quantity by `BulkOrderMultiplier`.

- [ ] **Step 4: Build, test, commit.**
```
git commit -m "feat: Phase 3 complete — pricing engine, wholesale customers, passive income"
```

---

## Phase 4: Events + Overdose

### Task 10: EventManager + Overdose

**Files:**
- Write: `Systems/EventManager.cs`
- Modify: `Patches/CustomerPatches.cs` (add EvaluateDelivery postfix)
- Modify: `Core/DynamicEconomyCore.cs` (add event rolling to OnDayEnd)

- [ ] **Step 1: Write `Systems/EventManager.cs`**

Key methods:
- `RollDailyEvents(int currentDay)` — rolls for police crackdown and supply shortage
- `CalculateOverdoseChance(profile, qualityDiff, mixIntensity, addiction, depMultiplier)` — follows spec formula exactly
- `ResolveOverdose(profile, currentDay)` — hospitalizes, increments count, schedules release
- `IsCrackdownActive(region)`, `IsShortageActive(drugType)` — check active events
- `GetOrderReduction(drugType, region)` — returns 0.0-1.0 multiplier

- [ ] **Step 2: Add `EvaluateDelivery` postfix** to CustomerPatches. Gets profile, applies tolerance growth, calculates satisfaction penalty, rolls overdose, records purchase.

- [ ] **Step 3: Update `DynamicEconomyCore.OnDayEnd`** to call `EventManager.RollDailyEvents(currentDay)`.

- [ ] **Step 4: Build, test overdoses carefully, commit.**
```
git commit -m "feat: Phase 4 complete — events, overdoses, crackdowns, shortages"
```

---

## Phase 5: Polish

### Task 11: Dead Drop Map Heat Display

- [ ] **Step 1: In `DeadDropManager.UpdateHeat()`**, update `PoI.SetMainText()` with heat label.

- [ ] **Step 2: Commit.**
```
git commit -m "feat: dead drop heat display on map POI labels"
```

### Task 12: Final Integration Audit

- [ ] **Step 1: Audit every patch method** against Performance & Bug-Safety Rules.

- [ ] **Step 2: Verify default config writes correctly on first load.**

- [ ] **Step 3: Playtest checklist:**
  - [ ] Order quantities increase as addiction/relationship grow
  - [ ] Tolerance grows with large orders, decays without
  - [ ] Dead drops trigger for eligible customers with large orders
  - [ ] Prepaid drops: cash at location, player picks up
  - [ ] Async drops: premium applied to payment
  - [ ] Dead drop events fire at configured rates
  - [ ] Heat increases on reuse, decays, shows on map
  - [ ] Discovery quest triggers on first eligibility
  - [ ] Wholesale promoted, weekly revenue generated
  - [ ] Volume discounts on large orders
  - [ ] Overdoses fire rarely, hospitalization works
  - [ ] Police crackdown reduces orders
  - [ ] Supply shortage affects specific drug type
  - [ ] Config hot-reload works
  - [ ] Multiplayer: mod loads without error
  - [ ] Save persists across restarts

- [ ] **Step 4: Final commit.**
```
git commit -m "feat: v3.0.0 complete — full integration and polish"
```