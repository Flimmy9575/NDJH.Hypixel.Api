using System.Text.Json.Serialization;
using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Models.SkyBlock;

public record AuctionsPageResult(
    [property: JsonPropertyName("page")] int Page,
    [property: JsonPropertyName("totalPages")]
    int TotalPages,
    [property: JsonPropertyName("totalAuctions")]
    int TotalAuctions,
    [property: JsonPropertyName("auctionsResult")]
    AuctionsResponse AuctionsResponse) : ResourcesBaseModel;