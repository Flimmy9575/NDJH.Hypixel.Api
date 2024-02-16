using System.Text.Json.Serialization;

namespace NDJH.Hypixel.API.Models;

public record BaseResponse
{
    [JsonPropertyName("success")] public bool Success { get; set; }

    [JsonPropertyName("uuid")] public string Uuid { get; set; }
};