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
        private static bool _loaded;

        /// <summary>
        /// Initial load during OnInitializeMelon. At this point the game hasn't loaded a save yet,
        /// so ActiveSaveFolder is null and we fall back to the global config dir.
        /// The per-save data is loaded later via ReloadForActiveSave() when the game's save folder
        /// becomes known (first Save() call).
        /// </summary>
        public static void Load()
        {
            Data = new ModSaveData { Version = Constants.SaveVersion };
            TryLoadFromFile();
            _loaded = true;
        }

        /// <summary>
        /// Reloads mod data from the per-save folder once it becomes known.
        /// Called from SaveFolderHelper.ResolveIfMissing() the first time ActiveSaveFolder is set.
        /// This ensures each game save loads its own mod data instead of sharing a global file.
        /// </summary>
        public static void ReloadForActiveSave()
        {
            if (!_loaded) return;
            // Preserve in-memory state if we already have profiles and the save folder
            // was just discovered (the data was being accumulated since launch).
            // Only reload if the current in-memory data is empty (fresh launch with no activity).
            if (Data.CustomerProfiles.Count > 0) return;

            MelonLogger.Msg($"[DynamicOrdersMod] Reloading mod data from per-save folder: {Constants.ModSaveDir}");
            TryLoadFromFile();
        }

        private static void TryLoadFromFile()
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
                        MelonLogger.Msg($"[DynamicOrdersMod] Save loaded from {Constants.SaveFilePath}. {Data.CustomerProfiles.Count} customer profiles.");
                        return;
                    }
                    if (data != null && data.Version != Constants.SaveVersion)
                        MelonLogger.Warning($"[DynamicOrdersMod] Save version mismatch (got {data.Version}, want {Constants.SaveVersion}). Starting fresh.");
                }
                // No existing save: start fresh. Don't persist yet — wait for the first Save() call
                // which will have the correct save folder path.
                MelonLogger.Msg($"[DynamicOrdersMod] No save found at {Constants.SaveFilePath}. Fresh profile.");
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
                if (!Directory.Exists(Constants.ModSaveDir))
                    Directory.CreateDirectory(Constants.ModSaveDir);

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
