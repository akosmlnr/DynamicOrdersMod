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
        private static string _loadedSaveFolder;

        /// <summary>
        /// Initial setup during OnInitializeMelon. Save data is loaded only after the
        /// game exposes the active save folder, so profiles never leak between saves.
        /// </summary>
        public static void Load()
        {
            Data = new ModSaveData { Version = Constants.SaveVersion };
            Constants.ActiveSaveFolder = null;
            _loadedSaveFolder = null;
            MelonLogger.Msg("[DynamicOrdersMod] Save system initialized (waiting for save folder).");
        }

        /// <summary>
        /// Resolves and loads the save folder currently selected by the game.
        /// This is safe to call repeatedly and also handles switching saves in-process.
        /// </summary>
        public static void ResolveSaveFolder()
        {
            try
            {
                var sm = Il2CppScheduleOne.Persistence.SaveManager.Instance;
                if (sm == null) return;

                string playersPath = sm.PlayersSavePath;
                if (string.IsNullOrEmpty(playersPath)) return;

                string saveFolder = Path.GetDirectoryName(playersPath);
                if (!string.IsNullOrEmpty(saveFolder))
                    ResolveExplicitSaveFolder(saveFolder);
            }
            catch
            {
                // SaveManager is not ready yet; the update loop will retry.
            }
        }

        /// <summary>
        /// Loads the mod data for an explicit game save folder supplied by Save(string).
        /// </summary>
        public static void ResolveExplicitSaveFolder(string saveFolder)
        {
            if (string.IsNullOrEmpty(saveFolder)) return;
            saveFolder = Path.GetFullPath(saveFolder);
            if (!Directory.Exists(saveFolder)) return;
            if (string.Equals(_loadedSaveFolder, saveFolder, System.StringComparison.OrdinalIgnoreCase))
                return;

            Constants.ActiveSaveFolder = saveFolder;
            _loadedSaveFolder = saveFolder;
            Data = new ModSaveData { Version = Constants.SaveVersion };
            TryLoadFromFile();
            MelonLogger.Msg($"[DynamicOrdersMod] Active save folder: {saveFolder}");
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
                // Never fall back to shared config storage for save data. A game save
                // must be resolved first or this write could contaminate another save.
                if (string.IsNullOrEmpty(Constants.ActiveSaveFolder))
                {
                    MelonLogger.Warning("[DynamicOrdersMod] Save skipped: active game save folder is not resolved.");
                    return;
                }

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
