using System.Text.Json.Serialization;
using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Models.SkyBlock;

public record Tier(
    [property: JsonPropertyName("tier")] int TierValue,
    [property: JsonPropertyName("amountRequired")]
    int AmountRequired,
    [property: JsonPropertyName("unlocks")]
    IReadOnlyList<string> Unlocks);

public record CollectionItem(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("maxTiers")]
    int MaxTiers,
    [property: JsonPropertyName("tiers")] IReadOnlyList<Tier> Tiers);

public record Collection(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("items")] IReadOnlyDictionary<string, CollectionItem> Items);

public record CollectionResponse(
    [property: JsonPropertyName("version")]
    string Version,
    [property: JsonPropertyName("collections")]
    IReadOnlyDictionary<string, Collection> Collections) : ResourcesBaseModel;