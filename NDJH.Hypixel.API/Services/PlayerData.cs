using NDJH.Hypixel.API.Models.PlayerData;
using NDJH.Hypixel.API.Services.interfaces;

namespace NDJH.Hypixel.API.Services;

public class PlayerData(IHttpDeserializerService httpRequestAndDeserializer) : IPlayerData
{
    public async Task<Player> GetPlayerAsync(string uuid) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<Player>($"player?uuid={uuid}");

    public async Task<RecentGamesResponse> GetRecentGamesAsync(string uuid) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<RecentGamesResponse>(
            $"recentgames?uuid={uuid}");

    public async Task<StatusResponse> GetStatusAsync(string uuid) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<StatusResponse>($"status?uuid={uuid}");

    public async Task<GuildResponse> GetGuildAsync(string input, InputType inputType) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<GuildResponse>($"guild?{inputType}={input}");
}