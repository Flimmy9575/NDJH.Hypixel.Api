using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NDJH.Hypixel.API.Configuration;
using NDJH.Hypixel.API.Exceptions;
using NDJH.Hypixel.API.Services;

namespace NDJH.Hypixel.API.DependencyInjection;

public static class ServiceExtensions
{
    public static IServiceCollection AddHypixel(this IServiceCollection services, IConfiguration config)
    {
        // retrieving Config
        var hypixelConfigSection = config.GetSection("hypixel");

        if (hypixelConfigSection.Exists())
        {
            var hypixelConfig = hypixelConfigSection.Get<HypixelConfiguration>() ?? new HypixelConfiguration();

            // validate hypixelConfig 
            if (string.IsNullOrWhiteSpace(hypixelConfig.ApiKey))
            {
                throw new ConfigurationException("Hypixel API Key is required.");
            }

            if (string.IsNullOrWhiteSpace(hypixelConfig.BaseUrl))
            {
                throw new ConfigurationException("Hypixel Base URL is required.");
            }


            // Setting up HttpClient
            services.AddHttpClient<IHypixelWrapper, HypixelWrapper>(client =>
                HttpClientConfiguration.ConfigureHttpClientDefault(client, hypixelConfig));

            // The services for the api wrapper
            services.AddSingleton<IHypixelWrapper, HypixelWrapper>();
            services.AddSingleton<IPlayerData, PlayerData>();
            services.AddSingleton<ISkyBlock, SkyBlock>();
            services.AddSingleton<IResource, Resource>();
            services.AddSingleton<IOther, Other>();
        }
        else
        {
            throw new ConfigurationException("Hypixel Configuration section is missing in configuration.");
        }

        return services;
    }
}