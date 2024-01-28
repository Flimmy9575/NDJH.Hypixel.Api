using System.Text.Json.Serialization;
using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Models.SkyBlock;

public record AuctionEntry(
    [property: JsonPropertyName("auction_id")]
    string AuctionId,
    [property: JsonPropertyName("seller")] string Seller,
    [property: JsonPropertyName("seller_profile")]
    string SellerProfile,
    [property: JsonPropertyName("buyer")] string Buyer,
    [property: JsonPropertyName("timestamp")]
    long Timestamp,
    [property: JsonPropertyName("price")] int Price,
    [property: JsonPropertyName("bin")] bool Bin,
    [property: JsonPropertyName("item_bytes")]
    string ItemBytes);

public record AuctionsHistoryResponse(
    [property: JsonPropertyName("auctions")]
    IReadOnlyList<AuctionEntry> Auctions) : ResourcesBaseModel;