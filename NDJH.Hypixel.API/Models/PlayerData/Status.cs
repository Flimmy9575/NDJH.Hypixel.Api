using System.Text.Json.Serialization;

namespace NDJH.Hypixel.API.Models.PlayerData;

public record Status([property: JsonPropertyName("session")] Session Session) : BaseResponse;

public record Session(
    [property: JsonPropertyName("online")] bool Online,
    [property: JsonPropertyName("gameType")]
    string GameType,
    [property: JsonPropertyName("mode")] string Mode,
    [property: JsonPropertyName("map")] string Map);