using Microsoft.Extensions.Logging.Abstractions;
using NDJH.Hypixel.API.Models.PlayerData;

namespace NDJH.Hypixel.API.Services;

public class PlayerData(IHttpDeserializerService httpRequestAndDeserializer) : IPlayerData
{
    public async Task<Player> GetPlayerAsync(string uuid) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<Player>("/player");

    public async Task<RecentGamesResponse> GetRecentGamesResponseAsync(string uuid) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<RecentGamesResponse>("/recentgames");

    public async Task<StatusResponse> GetStatusResponseAsync(string uuid) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<StatusResponse>("/status");

    public async Task<GuildResponse> GetGuildResponseAsync(string input, InputType inputType) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<GuildResponse>("guild");
}