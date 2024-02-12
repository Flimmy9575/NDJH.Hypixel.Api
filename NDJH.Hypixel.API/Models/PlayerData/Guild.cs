using System.Text.Json.Serialization;

namespace NDJH.Hypixel.API.Models.PlayerData;

public record Member(
    [property: JsonPropertyName("uuid")] string Uuid,
    [property: JsonPropertyName("rank")] string Rank,
    [property: JsonPropertyName("joined")] long Joined,
    [property: JsonPropertyName("questParticipation")]
    int QuestParticipation,
    [property: JsonPropertyName("expHistory")]
    IReadOnlyDictionary<string, long> ExpHistory);

public record Rank(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("default")]
    bool Default,
    [property: JsonPropertyName("tag")] string Tag,
    [property: JsonPropertyName("created")]
    long Created,
    [property: JsonPropertyName("priority")]
    int Priority);

public record Guild(
    [property: JsonPropertyName("_id")] string Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("name_lower")]
    string NameLowerCase,
    [property: JsonPropertyName("coins")] int Coins,
    [property: JsonPropertyName("coinsEver")]
    int CoinsEver,
    [property: JsonPropertyName("created")]
    long Created,
    [property: JsonPropertyName("members")]
    IReadOnlyList<Member> Members,
    [property: JsonPropertyName("ranks")] IReadOnlyList<Rank> Ranks,
    [property: JsonPropertyName("achievements")]
    IReadOnlyDictionary<string, int> Achievements,
    [property: JsonPropertyName("exp")] int Exp,
    [property: JsonPropertyName("publiclyListed")]
    bool PubliclyListed,
    [property: JsonPropertyName("description")]
    string Description,
    [property: JsonPropertyName("preferredGames")]
    IReadOnlyList<string> PreferredGames,
    [property: JsonPropertyName("tagColor")]
    string TagColor,
    [property: JsonPropertyName("tag")] string Tag,
    [property: JsonPropertyName("guildExpByGameType")]
    IReadOnlyDictionary<string, long> GuildExpByGameType);

public record GuildResponse([property: JsonPropertyName("guild")] Guild Guild) : BaseResponse;