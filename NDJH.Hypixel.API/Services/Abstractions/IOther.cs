namespace NDJH.Hypixel.API.Services.Abstractions;

public interface IOther
{
    public Task GetBoosters();
    public Task GetBoosters(CancellationToken cancellationToken);
    public Task GetPlayerCounts();
    public Task GetPlayerCounts(CancellationToken cancellationToken);
    public Task GetLeaderboards();
    public Task GetLeaderboards(CancellationToken cancellationToken);
    public Task GetPunishmentStats();
    public Task GetPunishmentStats(CancellationToken cancellationToken);
}