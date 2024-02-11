using Microsoft.Extensions.Logging;
using NDJH.Hypixel.API.Configuration;
using NDJH.Hypixel.API.Services.Abstractions;

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


    public HypixelWrapper(HypixelConfiguration config, HttpClient? httpClient = null,
        ILoggerFactory? loggerFactory = null)
    {
        // Setting up HTTP
        if (HttpClientConfiguration.HttpClient is null && httpClient is null)
        {
            HttpClientConfiguration.HttpClient =
                HttpClientConfiguration.ConfigureHttpClientDefault(new HttpClient(), config);
        }


        httpClient = HttpClientConfiguration.HttpClient;

        // Creating services
        // OtherService = Other.Create(httpClient, loggerFactory?.CreateLogger<Other>());
        // SkyBlockService = new SkyBlock(httpClient, loggerFactory?.CreateLogger<SkyBlock>(), new HttpDeserializerService(httpClient, loggerFactory?.CreateLogger<HttpDeserializerService>()));
        // PlayerDataService = new PlayerData();
        // ResourceService = Resource.Create(httpClient, loggerFactory?.CreateLogger<Resource>());
    }

    public IOther OtherService { get; }
    public ISkyBlock SkyBlockService { get; }
    public IPlayerData PlayerDataService { get; }
    public IResource ResourceService { get; }

    /// <summary>
    /// Creates an instance of the HypixelWrapper class for interacting with the Hypixel API.
    /// </summary>
    /// <param name="config">The Hypixel configuration settings.</param>
    /// <param name="loggerFactory">Optional logger factory for logging purposes.</param>
    /// <returns>An instance of the HypixelWrapper class.</returns>
    /// <remarks> Currently this just calls the <see cref="HypixelWrapper"/> second constructor. </remarks>
    public static HypixelWrapper Create(HypixelConfiguration config, HttpClient? httpClient = null,
        LoggerFactory loggerFactory = null) =>
        new(config, httpClient, loggerFactory);
}