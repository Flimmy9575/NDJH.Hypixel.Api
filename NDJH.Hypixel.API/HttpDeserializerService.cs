using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using NDJH.Hypixel.API.Exceptions;
using NDJH.Hypixel.API.Models;
using NDJH.Hypixel.API.Services.Abstractions;

namespace NDJH.Hypixel.API;

public class HttpDeserializerService(
    HttpClient httpClient,
    ILogger<HttpDeserializerService> logger,
    IRateLimitService rateLimitService
)
    : IHttpDeserializerService
{
    /// <summary>
    /// Sends an HTTP request to the specified URL and deserializes the response into the specified type.
    /// </summary>
    /// <typeparam name="TResponse">The type to deserialize the response into.</typeparam>
    /// <param name="url">The URL to send the HTTP request to.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if necessary.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the deserialized response.</returns>
    /// <exception cref="ApiResponseNullException">Thrown when the API response is null.</exception>
    /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
    public async Task<TResponse> RequestAndSerializeResponseAsync<TResponse>(string url,
        CancellationToken cancellationToken)
    {
        await rateLimitService.WaitForRateLimitAsync(cancellationToken);
        var (content, statusCode) = await GetResponseAndLogStepsAsync(url, cancellationToken);

        // Serialize to ApiError and handle any errors
        var errorData = ReadAndDeserializeDataAsync<ApiErrorModel>(content);
        HandleErrorStatusCode(statusCode, errorData);

        logger.LogTrace("Received {Path} response. Deserializing", url);

        // Serialize to requested object and return
        var data = ReadAndDeserializeDataAsync<TResponse>(content);
        return data;
    }

    private async Task<(string, HttpStatusCode)> GetResponseAndLogStepsAsync(string url,
        CancellationToken cancellationToken)
    {
        logger.LogTrace("Requesting to {Path}.", url);
        // Making and reading response
        var response = await httpClient.GetAsync(url, cancellationToken);
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        logger.LogTrace("Hypixel returned an {StatusCode} with the response of: {Response}", response.StatusCode,
            content);

        // Settings remaining request and cooldown.
        SetRemainingLimits(response.Headers);


        return (content, response.StatusCode);
    }

    private void SetRemainingLimits(HttpHeaders headers)
    {
        var remainingRequests = 0;
        var resetTime = new DateTime();

        // Parse rate limit headers from response
        if (headers.TryGetValues("RateLimit-Remaining", out var remainingValues))
        {
            remainingRequests = int.Parse(remainingValues.First());
        }

        if (headers.TryGetValues("RateLimit-Reset", out var resetValues))
        {
            // The reset time is the current time plus the number of seconds until reset
            resetTime = DateTime.Now.AddSeconds(int.Parse(resetValues.First()));
        }

        rateLimitService.SetRateLimit(remainingRequests, resetTime.Second);
    }

    private TResponse ReadAndDeserializeDataAsync<TResponse>(string content)
    {
        // Reading and deserializing data from server response.
        var data = JsonSerializer.Deserialize<TResponse>(content);

        if (data is null)
        {
            var dataType = typeof(TResponse).Name;
            logger.LogError($"Failed to deserialize data of type {dataType}");
            throw new ApiResponseNullException($"Error: Deserialized data of type {dataType} was null.");
        }

        return data;
    }

    private void HandleErrorStatusCode(HttpStatusCode statusCode, ApiErrorModel errorData)
    {
        if (string.IsNullOrWhiteSpace(errorData.Cause))
        {
            return;
        }

        var logMessage = "An unknown API error occurred";
        switch (statusCode)
        {
            case HttpStatusCode.BadRequest:
                logMessage = "Hypixel returned Bad Request: {Cause}";
                break;
            case HttpStatusCode.Forbidden:
                logMessage = "Potentially invalid API Key: {Cause}";
                break;
            case HttpStatusCode.UnprocessableContent:
                logMessage = "Sent data is invalid: {Cause}";
                break;
            case HttpStatusCode.TooManyRequests:
                var global = "Unknown";
                if (errorData.Global.HasValue)
                {
                    global = errorData.Global.Value ? "is" : "isn't";
                }

                logMessage = "Rate limit hit. The throttle {Global} global";
                logger.LogWarning(logMessage, global);
                break;
        }

        // Global let's the client know if the rate limit is global or not.
        if (statusCode != HttpStatusCode.TooManyRequests)
        {
            logger.LogError(logMessage, errorData.Cause);
        }

        throw new ApiException((int)statusCode, errorData.Cause);
    }
}