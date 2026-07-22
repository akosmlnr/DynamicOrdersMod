using HarmonyLib;
using DynamicOrdersMod.Core;
using DynamicOrdersMod.Persistence;

namespace DynamicOrdersMod.Patches
{
    /// <summary>
    /// Hooks the game's save system so the mod's saveData.json is flushed every time
    /// the game writes its own save (auto-saves, manual saves, sleep transitions, etc).
    ///
    /// Game flow: ScheduleOne.Persistence.SaveManager has two Save overloads:
    ///   - Save()                  // default target folder
    ///   - Save(string folderPath) // folder-targeted save
    /// Both queue saveable entities and write them to disk. Our Postfix runs after
    /// the game finishes its flush and writes our own file in the same atomic moment.
    /// </summary>
    [HarmonyPatch(typeof(Il2CppScheduleOne.Persistence.SaveManager), "Save", new System.Type[0])]
    public static class SaveManagerSaveDefaultPatches
    {
        static void Postfix()
        {
            var core = DynamicEconomyCore.Instance;
            if (core == null) return;
            core.OnGameSave();

            int profileCount = SaveManager.Data?.CustomerProfiles?.Count ?? 0;
            int dealCount = SaveManager.Data?.ActiveDeadDropDeals?.Count ?? 0;
            DebugLog.Msg("save", $"game save() triggered, mod flushed profiles={profileCount} deals={dealCount}");
        }
    }

    [HarmonyPatch(typeof(Il2CppScheduleOne.Persistence.SaveManager), "Save", new[] { typeof(string) })]
    public static class SaveManagerSaveFolderPatches
    {
        static void Postfix(string saveFolderPath)
        {
            var core = DynamicEconomyCore.Instance;
            if (core == null) return;
            core.OnGameSave();

            DebugLog.Msg("save", $"folder save ({saveFolderPath}) triggered, mod flushed");
        }
    }
}
