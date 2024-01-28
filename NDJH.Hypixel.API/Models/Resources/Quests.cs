using System.Text.Json.Serialization;

namespace NDJH.Hypixel.API.Models.Resources;

public record Objective(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("integer")]
    int Integer);

public record Requirement(
    [property: JsonPropertyName("type")] string Type);

public record Quest(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("rewards")]
    IReadOnlyList<QuestsReward> Rewards,
    [property: JsonPropertyName("objectives")]
    IReadOnlyList<Objective> Objectives,
    [property: JsonPropertyName("requirements")]
    IReadOnlyList<Requirement> Requirements,
    [property: JsonPropertyName("description")]
    string Description);

public record QuestsResponse(
    [property: JsonPropertyName("quests")] IReadOnlyDictionary<string, IReadOnlyList<Quest>> Quests) : ResourcesBaseModel;

public record QuestsReward(
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("amount")] int Amount);