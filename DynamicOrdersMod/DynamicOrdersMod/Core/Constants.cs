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