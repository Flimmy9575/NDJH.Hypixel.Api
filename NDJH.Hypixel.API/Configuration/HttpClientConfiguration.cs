using NDJH.Hypixel.API.Exceptions;

namespace NDJH.Hypixel.API.Configuration;

public static class HttpClientConfiguration
{
    public static HttpClient ConfigureHttpClientDefault(HttpClient httpClient, HypixelConfiguration? config)
    {
        if (config is null)
        {
            throw new ConfigurationException("A valid configuration wasn't provided");
        }
        
        httpClient.BaseAddress = new Uri(config.BaseUrl);
        
        // Added in case the method is somehow called twice on the same instance
        if (!httpClient.DefaultRequestHeaders.Contains("API-Key")) {
            // Adding api key to request
            httpClient.DefaultRequestHeaders.Add("API-Key", config.ApiKey);
        }

        return httpClient;
    }

    // TODO: Find alternative as this isn't thread safe.
    public static HttpClient? HttpClient { get; set; }

}