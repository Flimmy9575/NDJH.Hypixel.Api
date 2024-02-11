using NDJH.Hypixel.API.Models.SkyBlock;
using NDJH.Hypixel.API.Services.interfaces;

namespace NDJH.Hypixel.API.Services;

public class SkyBlock(IHttpDeserializerService httpRequestAndDeserializer) : ISkyBlock
{
    public async Task<CollectionResponse> GetCollectionsAsync() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<CollectionResponse>(
            "/recources/skyblock/collections");


    public async Task<SkillsResponse> GetSkillsAsync() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<SkillsResponse>("/resources/skyblock/skills");

    public async Task<ItemsResponse> GetItemsAsync() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<ItemsResponse>("/resources/skyblock/items");

    public async Task<ElectionsResponse> GetElectionsAsync() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<ElectionsResponse>(
            "/resources/skyblock/election");

    public async Task<BingoResponse> GetBingoAsync() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<BingoResponse>("/resources/skyblock/bingo");

    public async Task<NewsResponse> GetNewsAsync() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<NewsResponse>("/resources/skyblock/news");

    public async Task<AuctionResponse> GetAuctionAsync(string input, InputType inputType) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<AuctionResponse>(
            $"/skyblock/auction?{inputType}={input}");

    public async Task<AuctionsResponse> GetActiveAuctionsAsync(int page) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<AuctionsResponse>(
            $"/skyblock/auctions?page={page}");

    public async Task<AuctionsHistoryResponse> GetAuctionsHistoryAsync() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<AuctionsHistoryResponse>(
            "/skyblock/auctions_ended");

    public async Task<BazaarResponse> GetBazaarAsync() =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<BazaarResponse>("skyblock/bazaar");

    public async Task<ProfileResponse> GetProfileAsync(string profileId) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<ProfileResponse>("/skyblock/profile");

    public async Task<ProfilesResponse> GetProfilesAsync(string uuid) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<ProfilesResponse>("/skyblock/profiles");

    public async Task<BingoCompletionsResponse> GetBingoCompletionsAsync(string uuid) =>
        await httpRequestAndDeserializer.RequestAndSerializeResponseAsync<BingoCompletionsResponse>(
            $"/skyblock/bingo?uuid={uuid}");
}