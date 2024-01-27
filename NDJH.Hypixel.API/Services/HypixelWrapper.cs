using Microsoft.Extensions.Logging;
using NDJH.Hypixel.API.Configuration;

namespace NDJH.Hypixel.API.Services;

public interface IHypixelWrapper
{
    public IOther OtherService { get; }
    public ISkyBlock SkyBlockService { get; }
    public IPlayerData PlayerDataService { get; }
    public IResource ResourceService { get; }
}

/// <summary>
/// Represents a wrapper class for the Hypixel API services.
/// </summary>
public class HypixelWrapper : IHypixelWrapper
{
    public IOther OtherService { get; }
    public ISkyBlock SkyBlockService { get; }
    public IPlayerData PlayerDataService { get; }
    public IResource ResourceService { get; }



    // DI Container
    /// <summary>
    /// Represents a wrapper class for the Hypixel API services.
    /// </summary>
    /// <remarks> This consturctor is to be used for DI purposes please use the </remarks>
    public HypixelWrapper(IOther otherService, ISkyBlock skyBlockService, IPlayerData playerDataService,
        IResource resourcesService)
    {
        OtherService = otherService;
        SkyBlockService = skyBlockService;
        PlayerDataService = playerDataService;
        ResourceService = resourcesService;
    }

    
    public HypixelWrapper(HypixelConfiguration config, HttpClient? httpClient = null, ILoggerFactory? loggerFactory = null)
    {
        // Setting up HTTP
        if (Setup.HttpClient is null && httpClient is null)
        {
            Setup.HttpClient = Setup.ConfigureHttpClientDefault(new HttpClient(), config);
        }
        
        
        httpClient = Setup.HttpClient;

        // Creating services
        OtherService = Other.Create(httpClient, loggerFactory?.CreateLogger<Other>());
        SkyBlockService = SkyBlock.Create(httpClient, loggerFactory?.CreateLogger<SkyBlock>());
        PlayerDataService = PlayerData.Create(httpClient, loggerFactory?.CreateLogger<PlayerData>());
        ResourceService = Resource.Create(httpClient, loggerFactory?.CreateLogger<Resource>());
    }

    /// <summary>
    /// Creates an instance of the HypixelWrapper class for interacting with the Hypixel API.
    /// </summary>
    /// <param name="config">The Hypixel configuration settings.</param>
    /// <param name="loggerFactory">Optional logger factory for logging purposes.</param>
    /// <returns>An instance of the HypixelWrapper class.</returns>
    /// <remarks> Currently this just calls the <see cref="HypixelWrapper"/> second constructor. </remarks>
    public static HypixelWrapper Create(HypixelConfiguration config, HttpClient? httpClient = null, LoggerFactory loggerFactory = null) =>
        new(config, httpClient, loggerFactory);
}