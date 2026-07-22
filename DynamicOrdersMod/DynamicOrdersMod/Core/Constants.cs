using System;
using System.IO;

namespace DynamicOrdersMod.Core
{
    public static class Constants
    {
        public const int SaveVersion = 3;
        public const int ConfigVersion = 1;

        /// <summary>
        /// Root directory for all Schedule I mod data. Uses the game's install directory
        /// (Schedule I/UserData/) which is where MelonLoader puts MelonPreferences.cfg and
        /// other mod data. Falls back to %APPDATA% if the game dir can't be resolved.
        /// </summary>
        private static readonly string GameUserDataDir = ResolveGameUserDataDir();

        /// <summary>
        /// Config directory — shared across all saves (config is player preference).
        /// Located at Schedule I/UserData/DynamicOrdersMod/
        /// </summary>
        public static readonly string ConfigDir = Path.Combine(GameUserDataDir, "DynamicOrdersMod");

        public static readonly string ConfigFilePath = Path.Combine(ConfigDir, "config.json");

        // --- Per-save data path (resolved at runtime) ---

        /// <summary>
        /// Folder where the active game save lives. Set by SaveManagerPatches when the
        /// game saves. Null until resolved — falls back to ConfigDir to avoid crashes.
        /// </summary>
        public static string ActiveSaveFolder;

        /// <summary>
        /// Directory for per-save mod data. Writes into the game's save folder
        /// (e.g. SaveGame_3/DynamicOrdersMod/) once ActiveSaveFolder is known.
        /// </summary>
        public static string ModSaveDir => ActiveSaveFolder != null
            ? Path.Combine(ActiveSaveFolder, "DynamicOrdersMod")
            : ConfigDir;

        public static string SaveFilePath => Path.Combine(ModSaveDir, "saveData.json");
        public static string TempSaveFilePath => Path.Combine(ModSaveDir, "saveData.json.tmp");

        /// <summary>
        /// Resolves the Schedule I UserData directory. MelonLoader sets the working
        /// directory to the game folder, so we walk up from the current directory to
        /// find "Schedule I/UserData/". Falls back to %APPDATA%/DynamicOrdersMod/v3/
        /// if not found (keeps the old location working).
        /// </summary>
        private static string ResolveGameUserDataDir()
        {
            try
            {
                // MelonLoader runs from the game root, so current dir is typically
                // "D:\SteamLibrary\steamapps\common\Schedule I\"
                string cwd = Environment.CurrentDirectory;
                string userData = Path.Combine(cwd, "UserData");
                if (Directory.Exists(userData))
                    return userData;

                // Walk up a few levels in case cwd is a subdirectory
                var parent = Directory.GetParent(cwd);
                for (int i = 0; i < 3 && parent != null; i++)
                {
                    userData = Path.Combine(parent.FullName, "UserData");
                    if (Directory.Exists(userData))
                        return userData;
                    parent = parent.Parent;
                }
            }
            catch { }

            // Fallback: old AppData location
            return Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "DynamicOrdersMod", "v3");
        }
    }
}
