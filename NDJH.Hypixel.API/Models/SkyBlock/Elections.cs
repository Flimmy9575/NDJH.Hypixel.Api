using System.Text.Json.Serialization;
using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Models.SkyBlock;

public record Perk(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("description")]
    string Description);

public record Candidate(
    [property: JsonPropertyName("key")] string Key,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("perks")] IReadOnlyList<Perk> Perks,
    [property: JsonPropertyName("votes")] int Votes);

public record Election(
    [property: JsonPropertyName("year")] int Year,
    [property: JsonPropertyName("candidates")]
    IReadOnlyList<Candidate> Candidates);

public record Mayor(
    [property: JsonPropertyName("key")] string Key,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("perks")] IReadOnlyList<Perk> Perks,
    [property: JsonPropertyName("election")]
    Election Election);

public record EletionsResponse(
    [property: JsonPropertyName("mayor")] Mayor Mayor) : ResourcesBaseModel;