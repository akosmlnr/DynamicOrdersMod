using System;
using System.IO;

namespace DynamicOrdersMod.Core
{
    public static class Constants
    {
        public const int SaveVersion = 3;
        public const int ConfigVersion = 1;

        /// <summary>
        /// Global config directory — shared across all saves (config is player preference, not game state).
        /// </summary>
        public static readonly string ConfigDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "DynamicOrdersMod", "v3");

        public static readonly string ConfigFilePath = Path.Combine(ConfigDir, "config.json");

        // --- Per-save data path (resolved at runtime) ---

        /// <summary>
        /// Folder where the active game save lives. Set by SaveManagerPatches when the
        /// game saves, or discovered via SaveManager.Instance at load time. Null until resolved.
        /// When null, we fall back to the global config dir so the mod doesn't crash on first launch.
        /// </summary>
        public static string ActiveSaveFolder;

        /// <summary>
        /// Directory for per-save mod data. Uses the game's save folder if known,
        /// otherwise falls back to the global config dir (prevents data leakage between saves).
        /// </summary>
        public static string ModSaveDir => ActiveSaveFolder != null
            ? Path.Combine(ActiveSaveFolder, "DynamicOrdersMod")
            : ConfigDir;

        public static string SaveFilePath => Path.Combine(ModSaveDir, "saveData.json");
        public static string TempSaveFilePath => Path.Combine(ModSaveDir, "saveData.json.tmp");
    }
}
