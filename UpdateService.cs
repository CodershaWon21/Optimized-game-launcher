namespace LauncherOptimized.Services;

public sealed class UpdateService
{
    public Task<bool> HasUpdateAsync(CancellationToken cancellationToken = default)
    {
        return Task.FromResult(false);
    }
}
