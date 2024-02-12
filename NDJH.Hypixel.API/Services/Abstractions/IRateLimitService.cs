namespace NDJH.Hypixel.API.Services.Abstractions;

public interface IRateLimitService
{
    Task WaitForRateLimitAsync(CancellationToken cancellationToken);
    void SetRateLimit(int remaining, int resetsInSeconds);
}