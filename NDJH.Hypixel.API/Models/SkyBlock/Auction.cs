using System.Text.Json.Serialization;
using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Models.SkyBlock;

public record ItemBytes(
    [property: JsonPropertyName("type")] double Type,
    [property: JsonPropertyName("data")] string Data); //TODO: Translate Data

public record Bid(
    [property: JsonPropertyName("auction_id")]
    string AuctionId,
    [property: JsonPropertyName("bidder")] string Bidder,
    [property: JsonPropertyName("profile_id")]
    string ProfileId,
    [property: JsonPropertyName("amount")] double Amount,
    [property: JsonPropertyName("timestamp"), JsonConverter(typeof(UnixTimestampJsonConverter))]
    DateTime Timestamp);

public record Auction(
    [property: JsonPropertyName("uuid")] string Uuid,
    [property: JsonPropertyName("auctioneer")]
    string Auctioneer,
    [property: JsonPropertyName("profile_id")]
    string ProfileId,
    [property: JsonPropertyName("coop")] IReadOnlyList<string> Coop,
    [property: JsonPropertyName("start"), JsonConverter(typeof(UnixTimestampJsonConverter))]
    DateTime Start,
    [property: JsonPropertyName("end"), JsonConverter(typeof(UnixTimestampJsonConverter))]
    DateTime End,
    [property: JsonPropertyName("item_name")]
    string ItemName,
    [property: JsonPropertyName("item_lore")]
    string ItemLore,
    [property: JsonPropertyName("extra")] string Extra,
    [property: JsonPropertyName("category")]
    string Category,
    [property: JsonPropertyName("tier")] string Tier,
    [property: JsonPropertyName("starting_bid")]
    double StartingBid,
    [property: JsonPropertyName("item_bytes")]
    ItemBytes ItemBytes,
    [property: JsonPropertyName("claimed")]
    bool Claimed,
    [property: JsonPropertyName("claimed_bidders")]
    IReadOnlyList<string> ClaimedBidders,
    [property: JsonPropertyName("highest_bid_amount")]
    double HighestBidAmount,
    [property: JsonPropertyName("bids")] IReadOnlyList<Bid> Bids);

public record AuctionResponse(
    [property: JsonPropertyName("auctions")]
    IReadOnlyList<Auction> Auctions) : ResourcesBaseModel;