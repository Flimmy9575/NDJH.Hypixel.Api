using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace NDJH.Hypixel.API.Services;

public interface IPlayerData
{
    
}

public class PlayerData : IPlayerData
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<IPlayerData> _logger; 

    public PlayerData(HttpClient httpClient, ILogger<IPlayerData> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }
    
    public static IPlayerData Create(HttpClient httpClient, ILogger<PlayerData>? logger = null) =>
        new PlayerData(httpClient, logger ?? NullLogger<PlayerData>.Instance);
}