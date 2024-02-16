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

        // Reading and Deserializing file to specified object
        var json = await File.ReadAllTextAsync(jsonFilePath);
        var expectedObject = JsonSerializer.Deserialize<T>(json);

        // Mocking IHttpDeserializerService to return expected Data object
        mockService.RequestAndSerializeResponseAsync<T>(Arg.Any<string>(), Arg.Any<CancellationToken>())!
            .Returns(expectedObject);

        return (mockService, expectedObject);
    }
}