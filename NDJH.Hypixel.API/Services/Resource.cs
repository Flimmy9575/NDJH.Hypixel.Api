using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Services;

public interface IResource
{
    /// <summary>
    /// Retrieves the achievements data.
    /// </summary>
    /// <returns>An instance of AchievementResponse containing the achievements data.</returns>
    public Task<AchievementResponse> GetAchievements();

    /// <summary>
    /// Retrieves the challenges data.
    /// </summary>
    /// <returns>An instance of ChallengesResponse containing the challenges data.</returns>
    public Task<ChallengesResponse> GetChallenges();

    /// <summary>
    /// Retrieves the quests data.
    /// </summary>
    /// <returns>An instance of QuestsResponse containing the quests data.</returns>
    public Task<QuestsResponse> GetQuests();

    /// <summary>
    /// Retrieves the guild achievements data.
    /// </summary>
    /// <returns>An instance of GuildAchievementResponse containing the guild achievements data.</returns>
    public Task<GuildAchievementResponse> GetGuildAchievements();

    /// <summary>
    /// Retrieves the vanity pets and companions information.
    /// </summary>
    /// <returns>An instance of VanityPetsAndCompanionsResponse containing the vanity pets and companions data.</returns>
    public Task<VanityPetsAndCompanionsResponse> GetVanityPetsInformation();

    /// <summary>
    /// Retrieves the information about vanity pets and companions.
    /// </summary>
    /// <returns>An instance of VanityPetsAndCompanionsResponse containing the vanity pets and companions data.</returns>
    public Task<VanityPetsAndCompanionsResponse> GetCompanionInformation();
}

public class Resource(IHttpDeserializerService httpRequestAndDeserializer) : IResource
{
    public async Task<AchievementResponse> GetAchievements() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<AchievementResponse>(
            "/resources/achievements");

    public async Task<ChallengesResponse> GetChallenges() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<ChallengesResponse>("/resources/challenges");

    public async Task<QuestsResponse> GetQuests() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<QuestsResponse>("/resources/quests");

    public async Task<GuildAchievementResponse> GetGuildAchievements() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<GuildAchievementResponse>(
            "/resources/guilds/achievements");

    public async Task<VanityPetsAndCompanionsResponse> GetVanityPetsInformation() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<VanityPetsAndCompanionsResponse>(
            "/resources/vanity/pets");

    public async Task<VanityPetsAndCompanionsResponse> GetCompanionInformation() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<VanityPetsAndCompanionsResponse>(
            "/resources/vanity/companions");
}