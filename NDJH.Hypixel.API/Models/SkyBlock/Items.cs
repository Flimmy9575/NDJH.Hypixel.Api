using System.Text.Json.Serialization;
using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Models.SkyBlock;

public record Stats(
    [property: JsonPropertyName("DEFENSE")]
    int Defense,
    [property: JsonPropertyName("HEALTH")] int Health);

public record SkyBlockItem(
    [property: JsonPropertyName("material")]
    string Material,
    [property: JsonPropertyName("color")] string Color,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("category")]
    string Category,
    [property: JsonPropertyName("tier")] string Tier,
    [property: JsonPropertyName("stats")] Stats Stats,
    [property: JsonPropertyName("npc_sell_price")]
    int NpcSellPrice,
    [property: JsonPropertyName("id")] string Id);

public record ItemsResponse(
    [property: JsonPropertyName("items")] IReadOnlyList<SkyBlockItem> Items) : ResourcesBaseModel;