using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace NDJH.Hypixel.API.Services;

public interface IOther
{
}

public class Other : IOther
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<IOther> _logger;

    public Other(HttpClient httpClient, ILogger<IOther> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public static IOther Create(HttpClient httpClient, ILogger<Other>? logger = null) =>
        new Other(httpClient, logger ?? NullLogger<Other>.Instance);
}