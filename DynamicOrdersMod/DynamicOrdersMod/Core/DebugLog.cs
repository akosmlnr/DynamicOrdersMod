using MelonLoader;
using DynamicOrdersMod.Persistence;

namespace DynamicOrdersMod.Core
{
    /// <summary>
    /// Centralized debug logger. All calls are no-ops when General.DebugLogging is false
    /// (single bool check per call, no allocations on the cold path).
    ///
    /// Format: [DOM] [tag] message
    ///   tag is typically a short customer/drop GUID (first 8 chars) or a scope label
    ///   like "day=12", "save", "init".
    /// </summary>
    public static class DebugLog
    {
        public static bool Enabled => ConfigManager.Config?.General?.DebugLogging ?? false;

        public static void Msg(string tag, string msg)
        {
            if (Enabled) MelonLogger.Msg($"[DOM] [{tag}] {msg}");
        }

        public static void Warn(string tag, string msg)
        {
            if (Enabled) MelonLogger.Warning($"[DOM] [{tag}] {msg}");
        }

        /// <summary>
        /// Shortens a GUID to its first 8 chars for log readability.
        /// Returns "????????" if null/empty so log columns stay aligned.
        /// </summary>
        public static string Short(string guid)
        {
            if (string.IsNullOrEmpty(guid)) return "????????";
            return guid.Length <= 8 ? guid : guid.Substring(0, 8);
        }
    }
}
