using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
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

    public Task<CollectionResponse> GetCollectionsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<SkillsResponse> GetSkillsAsync()
    {
        throw new NotImplementedException();
    private async Task<TResponse> RequestAndSerializeResponse<TResponse>(string url)
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
    }

    public Task<ItemsResponse> GetItemsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ElectionsResponse> GetElectionsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<BingoResponse> GetBingoAsync()
    {
        throw new NotImplementedException();
    }

    public Task<NewsResponse> GetNewsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<AuctionResponse> GetAuctionAsync(string input, InputType inputType)
    {
        throw new NotImplementedException();
    }

    public Task<AuctionResponse> GetActiveAuctionsAsync(int page)
    {
        throw new NotImplementedException();
    }

    public Task<AuctionsHistoryResponse> GetAuctionsHistoryAsync()
    {
        throw new NotImplementedException();
    }

    public Task<BazaarResponse> GetBazaarAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ProfileResponse> GetProfileAsync(string profileId)
    {
        throw new NotImplementedException();
    }

    public Task<ProfilesResponse> GetProfilesAsync(string uuid)
    {
        throw new NotImplementedException();
    }

    public Task<BingoCompletionsResponse> GetBingoCompletionsAsync(string uuid)
    {
        throw new NotImplementedException();
    }
}