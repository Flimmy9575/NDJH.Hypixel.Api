using System.Text.Json;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using NDJH.Hypixel.API.Exceptions;
using NDJH.Hypixel.API.Models.SkyBlock;

namespace NDJH.Hypixel.API.Services;

public class SkyBlock : ISkyBlock
{
    private readonly IHttpDeserializerService _httpRequestAndDeserializer; 

    public SkyBlock(IHttpDeserializerService httpRequestAndDeserializer)
    {
        _httpRequestAndDeserializer = httpRequestAndDeserializer;
    }
    
    public async Task<CollectionResponse> GetCollectionsAsync() =>
        await _httpRequestAndDeserializer.RequestAndSerializeResponseAsync<CollectionResponse>("/recources/skyblock/collections");
    

    public async Task<SkillsResponse> GetSkillsAsync() =>
        await _httpRequestAndDeserializer.RequestAndSerializeResponseAsync<SkillsResponse>("/resources/skyblock/skills");

    public async Task<ItemsResponse> GetItemsAsync() =>
        await _httpRequestAndDeserializer.RequestAndSerializeResponseAsync<ItemsResponse>("/resources/skyblock/items");

    public async Task<ElectionsResponse> GetElectionsAsync() =>
        await _httpRequestAndDeserializer.RequestAndSerializeResponseAsync<ElectionsResponse>("/resources/skyblock/election");

    public async Task<BingoResponse> GetBingoAsync() =>
        await _httpRequestAndDeserializer.RequestAndSerializeResponseAsync<BingoResponse>("/resources/skyblock/bingo");

    public async Task<NewsResponse> GetNewsAsync() =>
        await _httpRequestAndDeserializer.RequestAndSerializeResponseAsync<NewsResponse>("/resources/skyblock/news");

    public async Task<AuctionResponse> GetAuctionAsync(string input, InputType inputType) =>
        await _httpRequestAndDeserializer.RequestAndSerializeResponseAsync<AuctionResponse>($"/skyblock/auction?{inputType}={input}");

    public async Task<AuctionsResponse> GetActiveAuctionsAsync(int page) =>
        await _httpRequestAndDeserializer.RequestAndSerializeResponseAsync<AuctionsResponse>($"/skyblock/auctions?page={page}");

    public async Task<AuctionsHistoryResponse> GetAuctionsHistoryAsync() =>
        await _httpRequestAndDeserializer.RequestAndSerializeResponseAsync<AuctionsHistoryResponse>("/skyblock/auctions_ended");

    public async Task<BazaarResponse> GetBazaarAsync() =>
        await _httpRequestAndDeserializer.RequestAndSerializeResponseAsync<BazaarResponse>("skyblock/bazaar");

    public async Task<ProfileResponse> GetProfileAsync(string profileId) =>
        await _httpRequestAndDeserializer.RequestAndSerializeResponseAsync<ProfileResponse>("/skyblock/profile");

    public async Task<ProfilesResponse> GetProfilesAsync(string uuid) => await _httpRequestAndDeserializer.RequestAndSerializeResponseAsync<ProfilesResponse>("/skyblock/profiles");

    public async Task<BingoCompletionsResponse> GetBingoCompletionsAsync(string uuid) =>
        await _httpRequestAndDeserializer.RequestAndSerializeResponseAsync<BingoCompletionsResponse>($"/skyblock/bingo?uuid={uuid}");
}