using NDJH.Hypixel.API.Models.Resources;
using NDJH.Hypixel.API.Services.Abstractions;

namespace NDJH.Hypixel.API.Services;

public class Resource(IHttpDeserializerService httpRequestAndDeserializer) : IResource
{
    public async Task<AchievementResponse> GetAchievementsAsync() =>
        await GetAchievementsAsync(CancellationToken.None);

    public async Task<AchievementResponse> GetAchievementsAsync(CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<AchievementResponse>(
            "/resources/achievements", cancellationToken);


    public async Task<ChallengesResponse> GetChallengesAsync() =>
        await GetChallengesAsync(CancellationToken.None);

    public async Task<ChallengesResponse> GetChallengesAsync(CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<ChallengesResponse>(
            "/resources/challenges", cancellationToken);


    public async Task<QuestsResponse> GetQuestsAsync() =>
        await GetQuestsAsync(CancellationToken.None);

    public async Task<QuestsResponse> GetQuestsAsync(CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<QuestsResponse>("/resources/quests",
            cancellationToken);


    public async Task<GuildAchievementResponse> GetGuildAchievementsAsync() =>
        await GetGuildAchievementsAsync(CancellationToken.None);

    public async Task<GuildAchievementResponse> GetGuildAchievementsAsync(CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<GuildAchievementResponse>(
            "/resources/guilds/achievements", cancellationToken);


    public async Task<VanityPetsAndCompanionsResponse> GetVanityPetsInformationAsync() =>
        await GetVanityPetsInformationAsync(CancellationToken.None);

    public async Task<VanityPetsAndCompanionsResponse> GetVanityPetsInformationAsync(
        CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<VanityPetsAndCompanionsResponse>(
            "/resources/vanity/pets", cancellationToken);


    public async Task<VanityPetsAndCompanionsResponse> GetCompanionInformationAsync() =>
        await GetCompanionInformationAsync(CancellationToken.None);

    public async Task<VanityPetsAndCompanionsResponse> GetCompanionInformationAsync(
        CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<VanityPetsAndCompanionsResponse>(
            "/resources/vanity/companions", cancellationToken);
}