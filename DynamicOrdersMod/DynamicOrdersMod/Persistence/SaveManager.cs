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