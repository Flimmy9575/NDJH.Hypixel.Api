using NDJH.Hypixel.API.Models.Resources;
using NDJH.Hypixel.API.Services;
using NSubstitute;

namespace NDJH.Hypixel.API.IntegrationTests.ServiceTests;

public class ResourceDataTests
{
    [Fact]
    public async Task GetAchievementsAsync_ReturnsAchievements()
    {
        // Arrange
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<AchievementResponse>("TestsData/Resources/Achievements.json");
        var resourceData = new Resource(mockService);

        // Act
        var actual = await resourceData.GetAchievementsAsync();

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<AchievementResponse>($"resources/achievements",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task GetChallengesAsync_ReturnsChallenges()
    {
        // Arrange
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<ChallengesResponse>("TestsData/Resources/Challenges.json");
        var resourceData = new Resource(mockService);

        // Act
        var actual = await resourceData.GetChallengesAsync();

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<
                ChallengesResponse>($"resources/challenges", Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task GetQuestsAsync_ReturnsQuests()
    {
        // Arrange
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<QuestsResponse>("TestsData/Resources/Quests.json");
        var resourceData = new Resource(mockService);

        // Act
        var actual = await resourceData.GetQuestsAsync();

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<QuestsResponse>("resources/quests", Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task GetGuildAchievementsAsync_ReturnsGuildAchievements()
    {
        // Arrange
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<GuildAchievementResponse>(
                "TestsData/Resources/GuildAchievements.json");
        var resourceData = new Resource(mockService);

        // Act
        var actual = await resourceData.GetGuildAchievementsAsync();

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<GuildAchievementResponse>("resources/guilds/achievements",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task GetVanityPetsAsync_ReturnsVanityPets()
    {
        // Arrange
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<VanityPetsAndCompanionsResponse>("TestsData/Resources/Pets.json");
        var resourceData = new Resource(mockService);

        // Act
        var actual = await resourceData.GetVanityPetsInformationAsync();

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<VanityPetsAndCompanionsResponse>("resources/vanity/pets",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task GetCompanionsAsync_ReturnsCompanions()
    {
        // Arrange
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<VanityPetsAndCompanionsResponse>(
                "TestsData/Resources/Companions.json");
        var resourceData = new Resource(mockService);

        // Act
        var actual = await resourceData.GetCompanionInformationAsync();

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<VanityPetsAndCompanionsResponse>("resources/vanity/companions",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }
}