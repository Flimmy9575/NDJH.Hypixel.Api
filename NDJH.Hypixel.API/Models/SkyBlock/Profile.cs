using System.Text.Json.Serialization;
using NDJH.Hypixel.API.Models.Resources;

namespace NDJH.Hypixel.API.Models.SkyBlock;

public record DeletionNotice(
    [property: JsonPropertyName("timestamp")]
    long Timestamp);

public record ProfileMember(
    [property: JsonPropertyName("deletion_notice")]
    DeletionNotice DeletionNotice);

public record Transaction(
    [property: JsonPropertyName("timestamp")]
    long Timestamp,
    [property: JsonPropertyName("action")] string Action,
    [property: JsonPropertyName("initiator_name")]
    string InitiatorName,
    [property: JsonPropertyName("amount")] double Amount);

public record Banking(
    [property: JsonPropertyName("balance")]
    double Balance,
    [property: JsonPropertyName("transactions")]
    IReadOnlyList<Transaction> Transactions);

public record Profile(
    [property: JsonPropertyName("profile_id")]
    string ProfileId,
    [property: JsonPropertyName("members")]
    Dictionary<string, ProfileMember> Members,
    [property: JsonPropertyName("cute_name")]
    string CuteName,
    [property: JsonPropertyName("selected")]
    bool Selected,
    [property: JsonPropertyName("community_upgrades")]
    Dictionary<string, object> CommunityUpgrades,
    [property: JsonPropertyName("banking")]
    Banking Banking,
    [property: JsonPropertyName("game_mode")]
    string GameMode);

public record ProfileResponse(
    [property: JsonPropertyName("profile")]
    Profile Profile) : ResourcesBaseModel;