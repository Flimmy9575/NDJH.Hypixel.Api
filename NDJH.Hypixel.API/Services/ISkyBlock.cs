﻿using NDJH.Hypixel.API.Models.SkyBlock;

namespace NDJH.Hypixel.API.Services;

public interface ISkyBlock
{
    // Resources

    #region Resources

    /// <summary>
    /// Retrieves the collections information from the SkyBlock API.
    /// </summary>
    /// <returns>The response containing the collections information.</returns>
    public Task<CollectionResponse> GetCollectionsAsync();

    /// <summary>
    /// Retrieves the skills information from the SkyBlock API.
    /// </summary>
    /// <returns>The response containing the skills information.</returns>
    public Task<SkillsResponse> GetSkillsAsync();

    /// <summary>
    /// Retrieves the items information from the SkyBlock API.
    /// </summary>
    /// <returns>The response containing the items information.</returns>
    public Task<ItemsResponse> GetItemsAsync();

    /// <summary>
    /// Retrieves the elections information from the SkyBlock API.
    /// </summary>
    /// <returns>The response containing the elections information.</returns>
    public Task<ElectionsResponse> GetElectionsAsync();

    /// <summary>
    /// Retrieves the Bingo information from the SkyBlock API.
    /// </summary>
    /// <returns>The response containing the Bingo goals and progress.</returns>
    public Task<BingoResponse> GetBingoAsync();

    /// <summary>
    /// Retrieves the news from the SkyBlock API.
    /// </summary>
    /// <returns>The response containing the news items.</returns>
    public Task<NewsResponse> GetNewsAsync();

    // Firesales will go here

    #endregion


    #region PlayerData

    /// <summary>
    /// Retrieves the auction information based on the input.
    /// </summary>
    /// <param name="input">The input value to search for.</param>
    /// <param name="inputType">The type of input value to search for.</param>
    /// <returns>The response containing the retrieved auction information.</returns>
    public Task<AuctionResponse> GetAuctionAsync(string input, InputType inputType);

    /// <summary>
    /// Retrieves a list of active auctions.
    /// </summary>
    /// <param name="page">The page number of the auction list to retrieve.</param>
    /// <returns>A <see cref="AuctionResponse"/> object containing a list of active auctions.</returns>
    public Task<AuctionsResponse> GetActiveAuctionsAsync(int page);

    /// <summary>
    /// Retrieves the history of ended auctions.
    /// </summary>
    /// <returns>The history of ended auctions.</returns>
    public Task<AuctionsHistoryResponse> GetAuctionsHistoryAsync();

    /// <summary>
    /// Retrieves the bazaar information, including the current sell and buy listings for each product.
    /// </summary>
    /// <returns>The bazaar information.</returns>
    public Task<BazaarResponse> GetBazaarAsync();

    /// <summary>
    /// Retrieves the profile information for the specified profile ID.
    /// </summary>
    /// <param name="profileId">The ID of the profile to retrieve.</param>
    /// <returns>The profile information.</returns>
    public Task<ProfileResponse> GetProfileAsync(string profileId);

    /// <summary>
    /// Retrieves the profiles associated with a given UUID.
    /// </summary>
    /// <param name="uuid">The UUID of the player.</param>
    /// <returns>A response containing the profiles associated with the UUID.</returns>
    public Task<ProfilesResponse> GetProfilesAsync(string uuid);
    // Museum Response will go here

    /// <summary>
    /// Retrieves the bingo completions for a specific player.
    /// </summary>
    /// <param name="uuid">The UUID of the player.</param>
    /// <returns>The bingo completions response, which includes a list of events with completed goals.</returns>
    public Task<BingoCompletionsResponse> GetBingoCompletionsAsync(string uuid);

    #endregion
}