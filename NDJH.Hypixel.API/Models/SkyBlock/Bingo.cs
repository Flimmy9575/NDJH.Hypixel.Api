using System.Text.Json.Serialization;
using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Models.SkyBlock;

public record Goal(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("lore")] string Lore,
    [property: JsonPropertyName("tiers")] IReadOnlyList<int> Tiers,
    [property: JsonPropertyName("progress")]
    int Progress,
    [property: JsonPropertyName("requiredAmount")]
    int RequiredAmount);

public record BingoResponse(
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("goals")] IReadOnlyList<Goal> Goals) : ResourcesBaseModel;