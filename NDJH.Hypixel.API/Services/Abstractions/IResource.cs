using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Services.Abstractions;

public interface IResource
{
    /// <summary>
    /// Retrieves the achievements data.
    /// </summary>
    /// <returns>An instance of AchievementResponse containing the achievements data.</returns>
    public Task<AchievementResponse> GetAchievementsAsync();

    /// <summary>
    /// Retrieves the achievements data.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token to cancel the asynchronous operation.</param>
    /// <returns>An instance of AchievementResponse containing the achievements data.</returns>
    public Task<AchievementResponse> GetAchievementsAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Retrieves the challenges data.
    /// </summary>
    /// <returns>An instance of ChallengesResponse containing the challenges data.</returns>
    public Task<ChallengesResponse> GetChallengesAsync();

    /// <summary>
    /// Retrieves the challenges data.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token to cancel the asynchronous operation.</param>
    /// <returns>An instance of ChallengesResponse containing the challenges data.</returns>
    public Task<ChallengesResponse> GetChallengesAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Retrieves the quests data.
    /// </summary>
    /// <returns>An instance of QuestsResponse containing the quests data.</returns>
    public Task<QuestsResponse> GetQuestsAsync();

    /// <summary>
    /// Retrieves the quests data.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token to cancel the asynchronous operation.</param>
    /// <returns>An instance of QuestsResponse containing the quests data.</returns>
    public Task<QuestsResponse> GetQuestsAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Retrieves the guild achievements data.
    /// </summary>
    /// <returns>An instance of GuildAchievementResponse containing the guild achievements data.</returns>
    public Task<GuildAchievementResponse> GetGuildAchievementsAsync();

    /// <summary>
    /// Retrieves the guild achievements data.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token to cancel the asynchronous operation.</param>
    /// <returns>An instance of GuildAchievementResponse containing the guild achievements data.</returns>
    public Task<GuildAchievementResponse> GetGuildAchievementsAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Retrieves the vanity pets and companions information.
    /// </summary>
    /// <returns>An instance of VanityPetsAndCompanionsResponse containing the vanity pets and companions data.</returns>
    public Task<VanityPetsAndCompanionsResponse> GetVanityPetsInformationAsync();

    /// <summary>
    /// Retrieves the vanity pets and companions information.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token to cancel the asynchronous operation.</param>
    /// <returns>An instance of VanityPetsAndCompanionsResponse containing the vanity pets and companions data.</returns>
    public Task<VanityPetsAndCompanionsResponse> GetVanityPetsInformationAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Retrieves the information about vanity pets and companions.
    /// </summary>
    /// <returns>An instance of VanityPetsAndCompanionsResponse containing the vanity pets and companions data.</returns>
    public Task<VanityPetsAndCompanionsResponse> GetCompanionInformationAsync();

    /// <summary>
    /// Retrieves the information about vanity pets and companions.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token to cancel the asynchronous operation.</param>
    /// <returns>An instance of VanityPetsAndCompanionsResponse containing the vanity pets and companions data.</returns>
    public Task<VanityPetsAndCompanionsResponse> GetCompanionInformationAsync(CancellationToken cancellationToken);
}