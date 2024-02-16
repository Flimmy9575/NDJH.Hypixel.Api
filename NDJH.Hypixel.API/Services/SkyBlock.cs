using NDJH.Hypixel.API.Models.SkyBlock;
using NDJH.Hypixel.API.Services.Abstractions;

namespace NDJH.Hypixel.API.Services;

public class SkyBlock(IHttpDeserializerService httpRequestAndDeserializer) : ISkyBlock
{
    #region Resources

    public async Task<CollectionResponse> GetCollectionsAsync() =>
        await GetCollectionsAsync(CancellationToken.None);

    public async Task<CollectionResponse> GetCollectionsAsync(CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<CollectionResponse>(
            "resources/skyblock/collections", cancellationToken);


    public async Task<SkillsResponse> GetSkillsAsync() =>
        await GetSkillsAsync(CancellationToken.None);

    public async Task<SkillsResponse> GetSkillsAsync(CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<SkillsResponse>(
            "resources/skyblock/skills", cancellationToken);


    public async Task<ItemsResponse> GetItemsAsync() =>
        await GetItemsAsync(CancellationToken.None);

    public async Task<ItemsResponse> GetItemsAsync(CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<ItemsResponse>(
            "resources/skyblock/items", cancellationToken);


    public async Task<ElectionsResponse> GetElectionsAsync() =>
        await GetElectionsAsync(CancellationToken.None);

    public async Task<ElectionsResponse> GetElectionsAsync(CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<ElectionsResponse>(
            "resources/skyblock/election", cancellationToken);


    public async Task<BingoResponse> GetBingoAsync() =>
        await GetBingoAsync(CancellationToken.None);

    public async Task<BingoResponse> GetBingoAsync(CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<BingoResponse>(
            "resources/skyblock/bingo", cancellationToken);


    public async Task<NewsResponse> GetNewsAsync() =>
        await GetNewsAsync(CancellationToken.None);

    public async Task<NewsResponse> GetNewsAsync(CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<NewsResponse>("skyblock/news",
            cancellationToken);

    #endregion Resources

    #region PlayerData

    public async Task<AuctionResponse> GetAuctionAsync(string input, InputType inputType) =>
        await GetAuctionAsync(input, inputType, CancellationToken.None);

    public async Task<AuctionResponse> GetAuctionAsync(string input, InputType inputType,
        CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<AuctionResponse>(
            $"skyblock/auction?{inputType.ToString().ToLower()}={input}", cancellationToken);


    public async Task<AuctionsResponse> GetActiveAuctionsAsync(int page) =>
        await GetActiveAuctionsAsync(page, CancellationToken.None);

    public async Task<AuctionsResponse> GetActiveAuctionsAsync(int page, CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<AuctionsResponse>(
            $"skyblock/auctions?page={page}", cancellationToken);


    public async Task<AuctionsHistoryResponse> GetAuctionsHistoryAsync() =>
        await GetAuctionsHistoryAsync(CancellationToken.None);

    public async Task<AuctionsHistoryResponse> GetAuctionsHistoryAsync(CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<AuctionsHistoryResponse>(
            "skyblock/auctions_ended", cancellationToken);


    public async Task<BazaarResponse> GetBazaarAsync() =>
        await GetBazaarAsync(CancellationToken.None);

    public async Task<BazaarResponse> GetBazaarAsync(CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<BazaarResponse>("skyblock/bazaar",
            cancellationToken);


    public async Task<ProfileResponse> GetProfileAsync(string profileId) =>
        await GetProfileAsync(profileId, CancellationToken.None);

    public async Task<ProfileResponse> GetProfileAsync(string profileId, CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<ProfileResponse>(
            $"skyblock/profile?profile={profileId}",
            cancellationToken);


    public async Task<ProfilesResponse> GetProfilesAsync(string uuid) =>
        await GetProfilesAsync(uuid, CancellationToken.None);

    public async Task<ProfilesResponse> GetProfilesAsync(string uuid, CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<ProfilesResponse>(
            $"skyblock/profiles?uuid={uuid}",
            cancellationToken);


    public async Task<BingoCompletionsResponse> GetBingoCompletionsAsync(string uuid) =>
        await GetBingoCompletionsAsync(uuid, CancellationToken.None);

    public async Task<BingoCompletionsResponse> GetBingoCompletionsAsync(string uuid,
        CancellationToken cancellationToken) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<BingoCompletionsResponse>(
            $"skyblock/bingo?uuid={uuid}", cancellationToken);

    #endregion
}