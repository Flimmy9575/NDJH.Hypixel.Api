using NDJH.Hypixel.API.Models.PlayerData;
using NDJH.Hypixel.API.Services.Abstractions;

namespace NDJH.Hypixel.API.Services;

public class PlayerData(IHttpDeserializerService httpRequestAndDeserializer) : IPlayerData
{
    public async Task<Player> GetPlayerAsync(string uuid) =>
        await GetPlayerAsync(uuid, CancellationToken.None);

    public async Task<Player> GetPlayerAsync(string uuid, CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<Player>($"player?uuid={uuid}",
            cancellationToken);


    public async Task<RecentGamesResponse> GetRecentGamesAsync(string uuid) =>
        await GetRecentGamesAsync(uuid, CancellationToken.None);

    public async Task<RecentGamesResponse> GetRecentGamesAsync(string uuid, CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<RecentGamesResponse>(
            $"recentgames?uuid={uuid}", cancellationToken);


    public async Task<StatusResponse> GetStatusAsync(string uuid) =>
        await GetStatusAsync(uuid, CancellationToken.None);

    public async Task<StatusResponse> GetStatusAsync(string uuid, CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<StatusResponse>($"status?uuid={uuid}",
            cancellationToken);


    public async Task<GuildResponse> GetGuildAsync(string input, InputType inputType) =>
        await GetGuildAsync(input, inputType, CancellationToken.None);

    public async Task<GuildResponse> GetGuildAsync(string input, InputType inputType,
        CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<GuildResponse>(
            $"guild?{inputType.ToString().ToLower()}={input}", cancellationToken);
}