using MelonLoader;

namespace DynamicOrdersMod.UI
{
    public static class NotificationHelper
    {
        public static void Send(string title, string subtitle, float duration = 5f)
        {
            try
            {
                var mgr = Il2CppScheduleOne.UI.NotificationsManager.Instance;
                if (mgr == null) return;
                mgr.SendNotification(title, subtitle, null, duration, true);
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"[DynamicOrdersMod] Notification failed: {ex.Message}");
            }
        }
    }
}