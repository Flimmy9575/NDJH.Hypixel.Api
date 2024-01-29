using System.Text.Json.Serialization;
using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Models.SkyBlock;

public record AuctionsResponse(
    [property: JsonPropertyName("page")] int Page,
    [property: JsonPropertyName("totalPages")]
    int TotalPages,
    [property: JsonPropertyName("totalAuctions")]
    int TotalAuctions,
    [property: JsonPropertyName("auctionsResult")]
    AuctionResponse AuctionResponse) : ResourcesBaseModel;