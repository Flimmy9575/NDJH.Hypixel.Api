using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace NDJH.Hypixel.API.Services;

public interface IResource
{
    
}

public class Resource : IResource
{
    private  readonly HttpClient _httpClient;
    private readonly ILogger<Resource> _logger; 

    public Resource(HttpClient httpClient, ILogger<Resource> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }
    
    public static IResource Create(HttpClient httpClient, ILogger<Resource>? logger = null) =>
        new Resource(httpClient, logger ?? NullLogger<Resource>.Instance);
}