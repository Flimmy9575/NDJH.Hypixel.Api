using System.Text.Json;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using NDJH.Hypixel.API.Exceptions;
using NDJH.Hypixel.API.Models.SkyBlock;

namespace NDJH.Hypixel.API.Services;

public class SkyBlock : ISkyBlock
{
    private readonly HttpClient __httpClient;
    private readonly ILogger<SkyBlock> _logger;

    public SkyBlock(HttpClient httpClient, ILogger<SkyBlock> logger)
    {
        __httpClient = httpClient;
        _logger = logger;
    }

    public static ISkyBlock Create(HttpClient httpClient, ILogger<SkyBlock>? logger = null) =>
        new SkyBlock(httpClient, logger ?? NullLogger<SkyBlock>.Instance);

    public async Task<CollectionResponse> GetCollectionsAsync() =>
        await RequestAndSerializeResponseAsync<CollectionResponse>("/recources/skyblock/collections");

    private async Task<TResponse> RequestAndSerializeResponseAsync<TResponse>(string url)
    {
        try
        {
            _logger.LogTrace("Requesting to {Path}.", url);

            // Sending GET request to the collections endpoint
            var response = await __httpClient.GetAsync(url);


            // if the HTTP response status is an error status, this will throw an exception
            response.EnsureSuccessStatusCode();

            _logger.LogTrace("Received {Path} response. Deserializing.", url);

            // Read the response content as a stream
            var responseStream = await response.Content.ReadAsStreamAsync();

            // Deserialize the response content stream into a CollectionResponse object
            var data = await JsonSerializer.DeserializeAsync<TResponse>(responseStream);

            if (data is null)
            {
                throw new ApiResponseNullException(
                    $"Deserialization resulted in null. {typeof(TResponse)} object is not received as expected from the API.");
            }

            _logger.LogTrace("Deserialization complete.");

            return data;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error retrieving information from Hypixel API({Path}).", url);
            throw;
        }
    }

    public async Task<SkillsResponse> GetSkillsAsync() =>
        await RequestAndSerializeResponseAsync<SkillsResponse>("/resources/skyblock/skills");

    public async Task<ItemsResponse> GetItemsAsync() =>
        await RequestAndSerializeResponseAsync<ItemsResponse>("/resources/skyblock/items");

    public async Task<ElectionsResponse> GetElectionsAsync() =>
        await RequestAndSerializeResponseAsync<ElectionsResponse>("/resources/skyblock/election");

    public async Task<BingoResponse> GetBingoAsync() =>
        await RequestAndSerializeResponseAsync<BingoResponse>("/resources/skyblock/bingo");

    public async Task<NewsResponse> GetNewsAsync() =>
        await RequestAndSerializeResponseAsync<NewsResponse>("/resources/skyblock/news");

    public async Task<AuctionResponse> GetAuctionAsync(string input, InputType inputType) =>
        await RequestAndSerializeResponseAsync<AuctionResponse>($"/skyblock/auction?{inputType}={input}");

    public async Task<AuctionsResponse> GetActiveAuctionsAsync(int page) =>
        await RequestAndSerializeResponseAsync<AuctionsResponse>($"/skyblock/auctions?page={page}");

    public async Task<AuctionsHistoryResponse> GetAuctionsHistoryAsync() =>
        await RequestAndSerializeResponseAsync<AuctionsHistoryResponse>("/skyblock/auctions_ended");

    public async Task<BazaarResponse> GetBazaarAsync() =>
        await RequestAndSerializeResponseAsync<BazaarResponse>("skyblock/bazaar");

    public async Task<ProfileResponse> GetProfileAsync(string profileId) =>
        await RequestAndSerializeResponseAsync<ProfileResponse>("/skyblock/profile");

    public async Task<ProfilesResponse> GetProfilesAsync(string uuid) => await RequestAndSerializeResponseAsync<ProfilesResponse>("/skyblock/profiles");

    public async Task<BingoCompletionsResponse> GetBingoCompletionsAsync(string uuid) =>
        await RequestAndSerializeResponseAsync<BingoCompletionsResponse>($"/skyblock/bingo?uuid={uuid}");
}