namespace NDJH.Hypixel.API.Services;

public interface IOther
{
    public Task GetBoosters();
    public Task GetPlayerCounts();
    public Task GetLeaderboards();
    public Task GetPunishmentStats();
}

public class Other(IHttpDeserializerService httpRequestAndDeserializer) : IOther
{
    public Task GetBoosters() => throw new NotSupportedException();

    public Task GetPlayerCounts() => throw new NotSupportedException();
    public Task GetLeaderboards() => throw new NotSupportedException();
    public Task GetPunishmentStats() => throw new NotSupportedException();
}