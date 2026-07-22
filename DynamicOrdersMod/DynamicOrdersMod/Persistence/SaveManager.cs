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
                // No existing save (or version mismatch): start fresh and persist immediately
                // so the file shows up on disk alongside config.json.
                Data = new ModSaveData { Version = Constants.SaveVersion };
                try { Save(); }
                catch (System.Exception saveEx)
                {
                    MelonLogger.Warning($"[DynamicOrdersMod] Initial save write failed: {saveEx.Message}");
                }
                MelonLogger.Msg($"[DynamicOrdersMod] Fresh save created at {Constants.SaveFilePath}");
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
                // Ensure the save directory exists (mirrors ConfigManager.Load behavior).
                // Cheap to call; safe if already present.
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