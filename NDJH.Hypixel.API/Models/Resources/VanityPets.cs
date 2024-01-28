using System.Text.Json.Serialization;

namespace NDJH.Hypixel.API.Models.Resources;

public record Type(
    [property: JsonPropertyName("key")] string Key,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("rarity")] string Rarity,
    [property: JsonPropertyName("package")]
    string Package);

public record Rarity(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("color")] string Color);

public record VanityPetsAndCompanionsResponse(
    [property: JsonPropertyName("types")] IReadOnlyList<Type> Types,
    [property: JsonPropertyName("rarities")]
    IReadOnlyList<Rarity> Rarities) : ResourcesBaseModel;