using NDJH.Hypixel.API.Services.Abstractions;

namespace NDJH.Hypixel.API.Services;

public class RateLimitService : IRateLimitService
{
    private int _remainingRequests = int.MaxValue; // Initialize a high number until the actual limit is known
    private DateTimeOffset _resetTime;

    public Task WaitForRateLimitAsync(CancellationToken cancellationToken)
    {
        if (_remainingRequests > 0 || DateTimeOffset.Now >= _resetTime)
        {
            _remainingRequests--;
            return Task.CompletedTask; // no need to delay
        }

        return Task.Delay(_resetTime - DateTimeOffset.Now, cancellationToken);
    }

    public void SetRateLimit(int remaining, int resetsInSeconds)
    {
        _remainingRequests = remaining;
        _resetTime = DateTimeOffset.Now.AddSeconds(resetsInSeconds);
    }
}