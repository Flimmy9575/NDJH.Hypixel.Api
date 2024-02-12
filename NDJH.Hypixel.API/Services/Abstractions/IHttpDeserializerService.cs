namespace NDJH.Hypixel.API.Services.Abstractions;

public interface IHttpDeserializerService
{
    public Task<TResponse> RequestAndSerializeResponseAsync<TResponse>(string url, CancellationToken cancellationToken);
}