using System.Text.Json;
using NDJH.Hypixel.API.Services.Abstractions;
using NSubstitute;

namespace NDJH.Hypixel.API.IntegrationTests;

public static class TestsUtility
{
    public static async Task<(IHttpDeserializerService, T)> SetupMockServiceAsync<T>(string jsonFilePath)
        where T : class
    {
        var mockService = Substitute.For<IHttpDeserializerService>();

        var json = await File.ReadAllTextAsync(jsonFilePath);
        var expectedObject = JsonSerializer.Deserialize<T>(json);

        mockService.RequestAndSerializeResponseAsync<T>(Arg.Any<string>(), Arg.Any<CancellationToken>())!
            .Returns(expectedObject);

        return (mockService, expectedObject);
    }
}