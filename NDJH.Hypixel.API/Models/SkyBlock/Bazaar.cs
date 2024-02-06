using System.Text.Json.Serialization;
using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Models.SkyBlock;

public record SummaryEntry(
    [property: JsonPropertyName("amount")] int Amount,
    [property: JsonPropertyName("pricePerUnit")]
    double PricePerUnit,
    [property: JsonPropertyName("orders")] int Orders);

public record QuickStatus(
    [property: JsonPropertyName("productId")]
    string ProductId,
    [property: JsonPropertyName("sellPrice")]
    double SellPrice,
    [property: JsonPropertyName("sellVolume")]
    int SellVolume,
    [property: JsonPropertyName("sellMovingWeek")]
    int SellMovingWeek,
    [property: JsonPropertyName("sellOrders")]
    int SellOrders,
    [property: JsonPropertyName("buyPrice")]
    double BuyPrice,
    [property: JsonPropertyName("buyVolume")]
    int BuyVolume,
    [property: JsonPropertyName("buyMovingWeek")]
    int BuyMovingWeek,
    [property: JsonPropertyName("buyOrders")]
    int BuyOrders);

public record Product(
    [property: JsonPropertyName("product_id")]
    string ProductId,
    [property: JsonPropertyName("sell_summary")]
    IReadOnlyList<SummaryEntry> SellSummary,
    [property: JsonPropertyName("buy_summary")]
    IReadOnlyList<SummaryEntry> BuySummary,
    [property: JsonPropertyName("quick_status")]
    QuickStatus QuickStatus);

public record BazaarResponse(
    [property: JsonPropertyName("products")]
    Dictionary<string, Product> Products) : ResourcesBaseModel;