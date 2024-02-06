using NDJH.Hypixel.API.Models.PlayerData;

namespace NDJH.Hypixel.API.Services;

public class PlayerData(IHttpDeserializerService httpRequestAndDeserializer) : IPlayerData
{
    public async Task<Player> GetPlayerAsync(string uuid) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<Player>("/player");

    public async Task<RecentGamesResponse> GetRecentGamesAsync(string uuid) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<RecentGamesResponse>("/recentgames");

    public async Task<StatusResponse> GetStatusAsync(string uuid) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<StatusResponse>("/status");

    public async Task<GuildResponse> GetGuildAsync(string input, InputType inputType) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<GuildResponse>("guild");
}