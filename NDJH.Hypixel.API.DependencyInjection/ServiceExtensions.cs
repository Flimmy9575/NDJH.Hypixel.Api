using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace NDJH.Hypixel.API.DependencyInjection;

public static class ServiceExtensions
{
    public static IServiceCollection AddHypixel(this IServiceCollection services, IConfiguration config)
    {

        return services;
    }
}