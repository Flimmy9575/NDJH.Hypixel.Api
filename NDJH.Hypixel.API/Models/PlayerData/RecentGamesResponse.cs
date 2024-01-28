using System.Text.Json.Serialization;

namespace NDJH.Hypixel.API.Models.PlayerData;

public record RecentGamesResponse(
    [property: JsonPropertyName("games")] IReadOnlyList<PlayedGames> PlayedGames) : BaseResponse;

public record PlayedGames(
    [property: JsonPropertyName("date")] DateTime Date,
    [property: JsonPropertyName("gameType")]
    string GameType,
    [property: JsonPropertyName("mode")] string? Mode,
    [property: JsonPropertyName("map")] string? Map,
    [property: JsonPropertyName("ended")] DateTime Ended);