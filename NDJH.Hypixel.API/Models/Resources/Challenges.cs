using System.Text.Json.Serialization;

namespace NDJH.Hypixel.API.Models.Resources;

public record Reward(
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("amount")] int Amount);

public record Challenge(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("rewards")]
    IReadOnlyList<Reward> Rewards);

public record ChallengesResponse(
    [property: JsonPropertyName("challenges")]
    IReadOnlyDictionary<string, IReadOnlyList<Challenge>> Challenges) : ResourcesBaseModel;