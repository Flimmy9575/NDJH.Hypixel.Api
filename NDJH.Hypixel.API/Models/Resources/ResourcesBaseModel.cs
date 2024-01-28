using System.Text.Json.Serialization;

namespace NDJH.Hypixel.API.Models.Resources;

public record ResourcesBaseModel{
    [JsonPropertyName("success")] public bool Success { get; set; }

    [JsonPropertyName("uuid")] public DateTime LastUpdated { get; set; }
};