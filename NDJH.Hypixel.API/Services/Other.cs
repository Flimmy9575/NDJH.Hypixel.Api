using NDJH.Hypixel.API.Services.Abstractions;

namespace NDJH.Hypixel.API.Services;

public class Other(IHttpDeserializerService httpRequestAndDeserializer) : IOther
{
    public Task GetBoosters() => throw new NotSupportedException();

    public Task GetBoosters(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task GetPlayerCounts() => throw new NotSupportedException();

    public Task GetPlayerCounts(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task GetLeaderboards() => throw new NotSupportedException();

    public Task GetLeaderboards(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task GetPunishmentStats() => throw new NotSupportedException();

    public Task GetPunishmentStats(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}