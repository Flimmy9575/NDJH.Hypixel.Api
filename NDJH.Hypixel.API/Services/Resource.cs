using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Services;

public interface IResource
{
    /// <summary>
    /// Retrieves the achievements data.
    /// </summary>
    /// <returns>An instance of AchievementResponse containing the achievements data.</returns>
    public Task<AchievementResponse> GetAchievementsAsync();

    /// <summary>
    /// Retrieves the challenges data.
    /// </summary>
    /// <returns>An instance of ChallengesResponse containing the challenges data.</returns>
    public Task<ChallengesResponse> GetChallengesAsync();

    /// <summary>
    /// Retrieves the quests data.
    /// </summary>
    /// <returns>An instance of QuestsResponse containing the quests data.</returns>
    public Task<QuestsResponse> GetQuestsAsync();

    /// <summary>
    /// Retrieves the guild achievements data.
    /// </summary>
    /// <returns>An instance of GuildAchievementResponse containing the guild achievements data.</returns>
    public Task<GuildAchievementResponse> GetGuildAchievementsAsync();

    /// <summary>
    /// Retrieves the vanity pets and companions information.
    /// </summary>
    /// <returns>An instance of VanityPetsAndCompanionsResponse containing the vanity pets and companions data.</returns>
    public Task<VanityPetsAndCompanionsResponse> GetVanityPetsInformationAsync();

    /// <summary>
    /// Retrieves the information about vanity pets and companions.
    /// </summary>
    /// <returns>An instance of VanityPetsAndCompanionsResponse containing the vanity pets and companions data.</returns>
    public Task<VanityPetsAndCompanionsResponse> GetCompanionInformationAsync();
}

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