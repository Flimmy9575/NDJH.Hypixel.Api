using System.Text.Json.Serialization;
using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Models.SkyBlock;

public record Item(
    [property: JsonPropertyName("material")]
    string Material);

public record NewsItem(
    [property: JsonPropertyName("item")] Item Item,
    [property: JsonPropertyName("link")] string Link,
    [property: JsonPropertyName("title")] string Title,
    [property: JsonPropertyName("text")] string Text);

public record NewsResponse(
    [property: JsonPropertyName("items")] IReadOnlyList<NewsItem> Items) : ResourcesBaseModel;