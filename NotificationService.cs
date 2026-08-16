namespace LauncherOptimized.Services;

public sealed class NotificationService
{
    public event Action<string>? Notification;

    public void Show(string message)
    {
        Notification?.Invoke(message);
    }
}
