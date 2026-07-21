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
