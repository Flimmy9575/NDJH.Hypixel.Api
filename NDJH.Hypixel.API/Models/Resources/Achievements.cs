using System.Text.Json.Serialization;

namespace NDJH.Hypixel.API.Models.Resources;

public record Tier(
    [property: JsonPropertyName("tier")] int TierValue,
    [property: JsonPropertyName("points")] int Points,
    [property: JsonPropertyName("amount")] int Amount);

public record TieredAchievement(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("description")]
    string Description,
    [property: JsonPropertyName("tiers")] IReadOnlyList<Tier> Tiers);

public record OneTimeAchievement(
    [property: JsonPropertyName("points")] int Points,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("description")]
    string Description,
    [property: JsonPropertyName("gamePercentUnlocked")]
    double GamePercentUnlocked,
    [property: JsonPropertyName("globalPercentUnlocked")]
    double GlobalPercentUnlocked);

public record ArcadeAchievements(
    [property: JsonPropertyName("one_time")]
    IReadOnlyDictionary<string, OneTimeAchievement> OneTime,
    [property: JsonPropertyName("tiered")] IReadOnlyDictionary<string, TieredAchievement> Tiered,
    [property: JsonPropertyName("total_points")]
    int TotalPoints,
    [property: JsonPropertyName("total_legacy_points")]
    int TotalLegacyPoints);

public record AchievementResponse(
    [property: JsonPropertyName("achievements")]
    IReadOnlyDictionary<string, ArcadeAchievements> Achievements) : ResourcesBaseModel;