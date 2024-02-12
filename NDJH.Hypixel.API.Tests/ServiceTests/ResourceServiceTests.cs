using NDJH.Hypixel.API.Models.Resources;
using NDJH.Hypixel.API.Services;
using NDJH.Hypixel.API.Services.Abstractions;
using NSubstitute;

namespace NDJH.Hypixel.API.Tests.ServiceTests;

public class ResourceServiceTests
{
    private readonly IHttpDeserializerService _httpRequestAndDeserializer;
    private readonly Resource _resourceService;

    public ResourceServiceTests()
    {
        _httpRequestAndDeserializer = Substitute.For<IHttpDeserializerService>();
        _resourceService = new Resource(_httpRequestAndDeserializer);
    }

    [Fact]
    public async Task TestGetAchievementsAsync()
    {
        await _resourceService.GetAchievementsAsync();
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<AchievementResponse>("/resources/achievements", CancellationToken.None);
    }

    [Fact]
    public async Task TestGetChallengesAsync()
    {
        await _resourceService.GetChallengesAsync();
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<ChallengesResponse>("/resources/challenges", CancellationToken.None);
    }

    [Fact]
    public async Task TestGetQuestsAsync()
    {
        await _resourceService.GetQuestsAsync();
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<QuestsResponse>("/resources/quests", CancellationToken.None);
    }

    [Fact]
    public async Task TestGetGuildAchievementsAsync()
    {
        await _resourceService.GetGuildAchievementsAsync();
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<GuildAchievementResponse>("/resources/guilds/achievements",
                CancellationToken.None);
    }

    [Fact]
    public async Task TestGetVanityPetsInformationAsync()
    {
        await _resourceService.GetVanityPetsInformationAsync();
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<VanityPetsAndCompanionsResponse>("/resources/vanity/pets",
                CancellationToken.None);
    }

    [Fact]
    public async Task GetCompanionInformationAsync()
    {
        await _resourceService.GetCompanionInformationAsync();
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<VanityPetsAndCompanionsResponse>("/resources/vanity/companions",
                CancellationToken.None);
    }
}