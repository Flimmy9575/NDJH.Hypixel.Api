using NDJH.Hypixel.API.Models.PlayerData;
using NDJH.Hypixel.API.Services;
using NDJH.Hypixel.API.Tests.Shared;
using NSubstitute;

namespace NDJH.Hypixel.API.IntegrationTests.ServiceTests;

public class PlayerDataTests
{
    [Fact]
    public async Task GetPlayerAsync_ReturnsPlayer()
    {
        // Arrange
        var uuid = TestConstants.Uuid.ToString();
        var (mockService, expectedPlayer) =
            await TestsUtility.SetupMockServiceAsync<Player>("TestsData/Player/PlayerData.json");
        var playerData = new PlayerData(mockService);

        // Act
        var actualPlayer = await playerData.GetPlayerAsync(uuid);

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<Player>($"player?uuid={uuid}", Arg.Any<CancellationToken>());
        Assert.Equal(expectedPlayer, actualPlayer);
    }

    [Fact]
    public async Task GetRecentGamesAsync_ReturnsRecentGames()
    {
        // Arrange
        var uuid = TestConstants.Uuid.ToString();
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<RecentGamesResponse>("TestsData/Player/RecentGames.json");
        var playerData = new PlayerData(mockService);

        // Act
        var actual = await playerData.GetRecentGamesAsync(uuid);

        // Asset
        await mockService.Received()
            .RequestAndSerializeResponseAsync<RecentGamesResponse>($"recentgames?uuid={uuid}",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }


    [Fact]
    public async Task GetStatusAsync_ReturnsStatus()
    {
        // Arrange
        var uuid = TestConstants.Uuid.ToString();
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<StatusResponse>("TestsData/Player/Status.json");
        var playerData = new PlayerData(mockService);

        // Act
        var actual = await playerData.GetStatusAsync(uuid);

        // Asset
        await mockService.Received()
            .RequestAndSerializeResponseAsync<StatusResponse>($"status?uuid={uuid}", Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task GetGuildAsync_ReturnsGuild()
    {
        // Arrange
        var uuid = TestConstants.Uuid.ToString();
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<GuildResponse>("TestsData/Player/Guild.json");
        var playerData = new PlayerData(mockService);

        // Act
        var actual = await playerData.GetGuildAsync(uuid, InputType.Player);

        // Asset
        await mockService.Received()
            .RequestAndSerializeResponseAsync<GuildResponse>($"guild?{InputType.Player.ToString().ToLower()}={uuid}",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }
}