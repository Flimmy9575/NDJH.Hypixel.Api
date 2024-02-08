using NDJH.Hypixel.API.Models.PlayerData;
using NDJH.Hypixel.API.Services;
using NSubstitute;

namespace NDJH.Hypixel.API.Tests.ServiceTests;

public class PlayerDataServiceTests
{
    private readonly IHttpDeserializerService _httpRequestAndDeserializer;
    private readonly PlayerData _playerData;

    public PlayerDataServiceTests()
    {
        _httpRequestAndDeserializer = Substitute.For<IHttpDeserializerService>();
        _playerData = new PlayerData(_httpRequestAndDeserializer);
    }

    [Fact]
    public async Task TestGetPlayerAsync()
    {
        await _playerData.GetPlayerAsync(TestConstants.Uuid.ToString());

        await _httpRequestAndDeserializer.Received().RequestAndSerializeResponseAsync<Player>("/player");
    }

    [Fact]
    public async Task TestGetRecentGamesAsync()
    {
        await _playerData.GetRecentGamesAsync(TestConstants.Uuid.ToString());

        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<RecentGamesResponse>("/recentgames");
    }

    [Fact]
    public async Task TestGetStatusAsync()
    {
        await _playerData.GetStatusAsync(TestConstants.Uuid.ToString());

        await _httpRequestAndDeserializer.Received().RequestAndSerializeResponseAsync<StatusResponse>("/status");
    }

    [Fact]
    public async Task TestGetGuildAsync()
    {
        var input = TestConstants.Uuid.ToString();
        const InputType inputType = InputType.Player;
        await _playerData.GetGuildAsync(input, inputType);

        await _httpRequestAndDeserializer.Received().RequestAndSerializeResponseAsync<GuildResponse>("/guild");
    }
}