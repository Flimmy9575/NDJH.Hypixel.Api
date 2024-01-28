using System.Text.Json.Serialization;

namespace NDJH.Hypixel.API.Models;

public record BaseResponse
{
    [JsonPropertyName("success")] public bool Success { get; set; }

    [JsonPropertyName("uuid")] public Guid Guid { get; set; }
};