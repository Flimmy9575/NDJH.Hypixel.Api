﻿using System.Text.Json.Serialization;
using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Models.SkyBlock;

public record ItemBytes(
    [property: JsonPropertyName("type")] int Type,
    [property: JsonPropertyName("data")] string Data); //TODO: Translate Data

public record Bid(
    [property: JsonPropertyName("auction_id")]
    string AuctionId,
    [property: JsonPropertyName("bidder")] string Bidder,
    [property: JsonPropertyName("profile_id")]
    string ProfileId,
    [property: JsonPropertyName("amount")] int Amount,
    [property: JsonPropertyName("timestamp")]
    long Timestamp);

public record Auction(
    [property: JsonPropertyName("uuid")] string Uuid,
    [property: JsonPropertyName("auctioneer")]
    string Auctioneer,
    [property: JsonPropertyName("profile_id")]
    string ProfileId,
    [property: JsonPropertyName("coop")] IReadOnlyList<string> Coop,
    [property: JsonPropertyName("start")] long Start,
    [property: JsonPropertyName("end")] long End,
    [property: JsonPropertyName("item_name")]
    string ItemName,
    [property: JsonPropertyName("item_lore")]
    string ItemLore,
    [property: JsonPropertyName("extra")] string Extra,
    [property: JsonPropertyName("category")]
    string Category,
    [property: JsonPropertyName("tier")] string Tier,
    [property: JsonPropertyName("starting_bid")]
    int StartingBid,
    [property: JsonPropertyName("item_bytes")]
    ItemBytes ItemBytes,
    [property: JsonPropertyName("claimed")]
    bool Claimed,
    [property: JsonPropertyName("claimed_bidders")]
    IReadOnlyList<string> ClaimedBidders,
    [property: JsonPropertyName("highest_bid_amount")]
    int HighestBidAmount,
    [property: JsonPropertyName("bids")] IReadOnlyList<Bid> Bids);

public record AuctionsResponse(
    [property: JsonPropertyName("auctions")]
    IReadOnlyList<Auction> Auctions) : ResourcesBaseModel;