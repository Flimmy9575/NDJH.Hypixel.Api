using System.Text.Json.Serialization;

namespace NDJH.Hypixel.API.Models.Resources;

public record GuildTier(
    [property: JsonPropertyName("tier")] int TierValue,
    [property: JsonPropertyName("amount")] int Amount);

public record GuildTieredAchievement(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("description")]
    string Description,
    [property: JsonPropertyName("tiers")] IReadOnlyList<GuildTier> Tiers);

public record GuildAchievementResponse(
    [property: JsonPropertyName("one_time")]
    IReadOnlyDictionary<string, object> OneTime,
    [property: JsonPropertyName("tiered")] IReadOnlyDictionary<string, GuildTieredAchievement> Tiered) : ResourcesBaseModel;