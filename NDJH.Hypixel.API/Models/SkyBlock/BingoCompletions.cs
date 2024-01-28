using System.Text.Json.Serialization;
using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Models.SkyBlock;

public record EventEntry(
    [property: JsonPropertyName("key")] int Key,
    [property: JsonPropertyName("points")] int Points,
    [property: JsonPropertyName("completed_goals")]
    IReadOnlyList<string> CompletedGoals);

public record BingoCompletionsResponse(
    [property: JsonPropertyName("events")] IReadOnlyList<EventEntry> Events) : ResourcesBaseModel;