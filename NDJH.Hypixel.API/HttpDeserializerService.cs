using System.Text.Json;
using Microsoft.Extensions.Logging;
using NDJH.Hypixel.API.Exceptions;

namespace NDJH.Hypixel.API;

public interface IHttpDeserializerService
{
    public Task<TResponse> RequestAndSerializeResponseAsync<TResponse>(string url, CancellationToken cancellationToken);
}

public class HttpDeserializerService : IHttpDeserializerService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<HttpDeserializerService> _logger;

    public HttpDeserializerService(HttpClient httpClient, ILogger<HttpDeserializerService> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }


    public async Task<TResponse> RequestAndSerializeResponseAsync<TResponse>(string url,
        CancellationToken cancellationToken)
    {
        try
        {
            _logger.LogTrace("Requesting to {Path}.", url);
            // Sending GET request to the collections endpoint
            var response = await _httpClient.GetAsync(url, cancellationToken);

            // if the HTTP response status is an error status, this will throw an exception
            response.EnsureSuccessStatusCode();
            _logger.LogTrace("Received {Path} response. Deserializing.", url);
            // Read the response content as a stream
            var responseStream = await response.Content.ReadAsStreamAsync(cancellationToken);
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