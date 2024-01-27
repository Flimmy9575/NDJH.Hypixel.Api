using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace NDJH.Hypixel.API.Services;

public interface ISkyBlock
{
    
}

public class SkyBlock : ISkyBlock 
{
    private  readonly HttpClient __httpClient;
    private readonly ILogger<SkyBlock> _logger; 

    public SkyBlock(HttpClient httpClient, ILogger<SkyBlock> logger)
    {
        __httpClient = httpClient;
        _logger = logger;
    }
    
    public static ISkyBlock Create(HttpClient httpClient, ILogger<SkyBlock>? logger = null) =>
        new SkyBlock(httpClient, logger ?? NullLogger<SkyBlock>.Instance);
    
}