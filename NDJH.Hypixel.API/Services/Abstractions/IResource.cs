using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Services.interfaces;

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