using NDJH.Hypixel.API.Services.interfaces;

namespace NDJH.Hypixel.API.Services;

public class Other(IHttpDeserializerService httpRequestAndDeserializer) : IOther
{
    public Task GetBoosters() => throw new NotSupportedException();

    public Task GetPlayerCounts() => throw new NotSupportedException();
    public Task GetLeaderboards() => throw new NotSupportedException();
    public Task GetPunishmentStats() => throw new NotSupportedException();
}