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