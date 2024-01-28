using System.Text.Json.Serialization;
using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Models.SkyBlock;

public record ProfilesResponse(
    [property: JsonPropertyName("profiles")]
    IReadOnlyList<Profile> Profiles) : ResourcesBaseModel;