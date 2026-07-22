using System;
using System.IO;
using HarmonyLib;
using DynamicOrdersMod.Core;
using DynamicOrdersMod.Persistence;

namespace DynamicOrdersMod.Patches
{
    /// <summary>
    /// Hooks the game's save system so the mod's saveData.json is flushed every time
    /// the game writes its own save (auto-saves, manual saves, sleep transitions, etc).
    ///
    /// CRITICAL for per-save isolation: captures the game's save folder path from the
    /// Save(string) overload and stores it in Constants.ActiveSaveFolder. This makes the
    /// mod write saveData.json INTO the game's save folder (e.g. SaveGame_3/DynamicOrdersMod/)
    /// instead of a global AppData location — so different game saves get different mod data.
    /// </summary>
    public static class SaveFolderHelper
    {
        /// <summary>
        /// Resolves the active save folder from the game's SaveManager singleton.
        /// Called from both Save patches to ensure ActiveSaveFolder is set before writing.
        /// </summary>
        public static void ResolveIfMissing()
        {
            if (Constants.ActiveSaveFolder != null) return;
            try
            {
                var sm = Il2CppScheduleOne.Persistence.SaveManager.Instance;
                if (sm == null) return;
                string playersPath = sm.PlayersSavePath;
                if (!string.IsNullOrEmpty(playersPath))
                {
                    var dir = Path.GetDirectoryName(playersPath);
                    if (!string.IsNullOrEmpty(dir))
                    {
                        Constants.ActiveSaveFolder = dir;
                        // Trigger per-save reload now that we know the folder
                        SaveManager.ReloadForActiveSave();
                    }
                }
            }
            catch { }
        }
    }

    [HarmonyPatch(typeof(Il2CppScheduleOne.Persistence.SaveManager), "Save", new Type[0])]
    public static class SaveManagerSaveDefaultPatches
    {
        static void Postfix()
        {
            SaveFolderHelper.ResolveIfMissing();

            var core = DynamicEconomyCore.Instance;
            if (core == null) return;
            core.OnGameSave();

            int profileCount = SaveManager.Data?.CustomerProfiles?.Count ?? 0;
            int dealCount = SaveManager.Data?.ActiveDeadDropDeals?.Count ?? 0;
            DebugLog.Msg("save", $"game save() flushed profiles={profileCount} deals={dealCount} dir={Constants.ModSaveDir}");
        }
    }

    [HarmonyPatch(typeof(Il2CppScheduleOne.Persistence.SaveManager), "Save", new[] { typeof(string) })]
    public static class SaveManagerSaveFolderPatches
    {
        static void Postfix(string saveFolderPath)
        {
            if (!string.IsNullOrEmpty(saveFolderPath))
                Constants.ActiveSaveFolder = saveFolderPath;

            var core = DynamicEconomyCore.Instance;
            if (core == null) return;
            core.OnGameSave();

            DebugLog.Msg("save", $"folder save ({saveFolderPath}) flushed");
        }
    }
}
