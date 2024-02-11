using NDJH.Hypixel.API.Models.Resources;
using NDJH.Hypixel.API.Services.interfaces;

namespace NDJH.Hypixel.API.Services;

public class Resource(IHttpDeserializerService httpRequestAndDeserializer) : IResource
{
    public async Task<AchievementResponse> GetAchievementsAsync() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<AchievementResponse>(
            "/resources/achievements");

    public async Task<ChallengesResponse> GetChallengesAsync() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<ChallengesResponse>("/resources/challenges");

    public async Task<QuestsResponse> GetQuestsAsync() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<QuestsResponse>("/resources/quests");

    public async Task<GuildAchievementResponse> GetGuildAchievementsAsync() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<GuildAchievementResponse>(
            "/resources/guilds/achievements");

    public async Task<VanityPetsAndCompanionsResponse> GetVanityPetsInformationAsync() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<VanityPetsAndCompanionsResponse>(
            "/resources/vanity/pets");

    public async Task<VanityPetsAndCompanionsResponse> GetCompanionInformationAsync() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<VanityPetsAndCompanionsResponse>(
            "/resources/vanity/companions");
}