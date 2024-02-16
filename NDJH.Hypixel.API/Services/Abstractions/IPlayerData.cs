using NDJH.Hypixel.API.Models.PlayerData;

namespace NDJH.Hypixel.API.Services.Abstractions;

public interface IPlayerData
{
    /// <summary>
    /// Retrieves the player data asynchronously.
    /// </summary>
    /// <param name="uuid">The UUID of the player.</param>
    /// <returns>The player data.</returns>
    public Task<Player> GetPlayerAsync(string uuid);


    /// <summary>
    /// Retrieves the player data asynchronously.
    /// </summary>
    /// <param name="uuid">The UUID of the player.</param>
    /// <param name="cancellationToken">Cancellation token to cancel the asynchronous operation.</param>
    /// <returns>The player data.</returns>
    public Task<Player> GetPlayerAsync(string uuid, CancellationToken cancellationToken);

    /// <summary>
    /// Retrieves the recent games played by a player asynchronously.
    /// </summary>
    /// <param name="uuid">The UUID of the player.</param>
    /// <returns>The recent games response.</returns>
    public Task<RecentGamesResponse> GetRecentGamesAsync(string uuid);

    /// <summary>
    /// Retrieves the recent games played by a player asynchronously.
    /// </summary>
    /// <param name="uuid">The UUID of the player.</param>
    /// <param name="cancellationToken">Cancellation token to cancel the asynchronous operation.</param>
    /// <returns>The recent games response.</returns>
    public Task<RecentGamesResponse> GetRecentGamesAsync(string uuid, CancellationToken cancellationToken);

    /// <summary>
    /// Retrieves the status response for a player asynchronously.
    /// </summary>
    /// <param name="uuid">The UUID of the player.</param>
    /// <returns>The status response.</returns>
    public Task<StatusResponse> GetStatusAsync(string uuid);

    /// <summary>
    /// Retrieves the status response for a player asynchronously.
    /// </summary>
    /// <param name="uuid">The UUID of the player.</param>
    /// <param name="cancellationToken">Cancellation token to cancel the asynchronous operation.</param>
    /// <returns>The status response.</returns>
    public Task<StatusResponse> GetStatusAsync(string uuid, CancellationToken cancellationToken);

    /// <summary>
    /// Retrieves the guild data asynchronously.
    /// </summary>
    /// <param name="input">The input string specifying the guild. Can be the guild name, guild ID, or guild tag.</param>
    /// <param name="inputType">The type of input specified (Uuid, Player, or Profile).</param>
    /// <returns>The guild data.</returns>
    public Task<GuildResponse> GetGuildAsync(string input, InputType inputType);


    /// <summary>
    /// Retrieves the guild data asynchronously.
    /// </summary>
    /// <param name="input">The input string specifying the guild. Can be the guild name, guild ID, or guild tag.</param>
    /// <param name="inputType">The type of input specified (Uuid, Player, or Profile).</param>
    /// <param name="cancellationToken">Cancellation token to cancel the asynchronous operation.</param>
    /// <returns>The guild data.</returns>
    public Task<GuildResponse> GetGuildAsync(string input, InputType inputType, CancellationToken cancellationToken);
}