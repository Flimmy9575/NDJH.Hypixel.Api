namespace NDJH.Hypixel.API.Services.interfaces;

public interface IOther
{
    public Task GetBoosters();
    public Task GetPlayerCounts();
    public Task GetLeaderboards();
    public Task GetPunishmentStats();
}