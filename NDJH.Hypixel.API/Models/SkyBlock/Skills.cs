using System.Text.Json.Serialization;
using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Models.SkyBlock;

public record Level(
    [property: JsonPropertyName("level")] int LevelValue,
    [property: JsonPropertyName("totalExpRequired")]
    double TotalExpRequired,
    [property: JsonPropertyName("unlocks")]
    IReadOnlyList<string> Unlocks);

public record Skill(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("description")]
    string Description,
    [property: JsonPropertyName("maxLevel")]
    int MaxLevel,
    [property: JsonPropertyName("levels")] IReadOnlyList<Level> Levels);

public record SkillsResponse(
    [property: JsonPropertyName("version")]
    string Version,
    [property: JsonPropertyName("skills")] IReadOnlyDictionary<string, Skill> Skills) : ResourcesBaseModel;