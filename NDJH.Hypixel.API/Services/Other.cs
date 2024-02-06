using Microsoft.Extensions.Logging.Abstractions;

namespace NDJH.Hypixel.API.Services;

public interface IOther
{
    
}

public class Other(IHttpDeserializerService httpRequestAndDeserializer) : IOther
{
    
}