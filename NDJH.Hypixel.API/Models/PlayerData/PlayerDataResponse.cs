using System.Text.Json.Serialization;

namespace NDJH.Hypixel.API.Models.PlayerData;

public record _0533030fbac048fbb35f00161a1da045(
    [property: JsonPropertyName("profile_id")]
    string profile_id,
    
    [property: JsonPropertyName("cute_name")]
    string cute_name
);

public record _2022(
    
    [property: JsonPropertyName("levelling")]
    Levelling levelling
);

public record _2023(
    
    [property: JsonPropertyName("levelling")]
    Levelling levelling
);

public record AchievementRewardsNew(
    
    [property: JsonPropertyName("for_points_200")]
    long? for_points_200,
    
    [property: JsonPropertyName("for_points_300")]
    long? for_points_300
);

public record Achievements(
    
    [property: JsonPropertyName("bedwars_level")]
    int? bedwars_level,
    
    [property: JsonPropertyName("christmas2017_advent_2020")]
    int? christmas2017_advent_2020,
    
    [property: JsonPropertyName("bedwars_loot_box")]
    int? bedwars_loot_box,
    
    [property: JsonPropertyName("christmas2017_present_collector")]
    int? christmas2017_present_collector,
    
    [property: JsonPropertyName("general_challenger")]
    int? general_challenger,
    
    [property: JsonPropertyName("bedwars_collectors_edition")]
    int? bedwars_collectors_edition,
    
    [property: JsonPropertyName("bedwars_beds")]
    int? bedwars_beds,
    
    [property: JsonPropertyName("bedwars_bedwars_killer")]
    int? bedwars_bedwars_killer,
    
    [property: JsonPropertyName("bedwars_wins")]
    int? bedwars_wins,
    
    [property: JsonPropertyName("skyblock_minion_lover")]
    int? skyblock_minion_lover,
    
    [property: JsonPropertyName("general_quest_master")]
    int? general_quest_master,
    
    [property: JsonPropertyName("halloween2017_pumpkinator")]
    int? halloween2017_pumpkinator,
    
    [property: JsonPropertyName("skyblock_treasury")]
    int? skyblock_treasury,
    
    [property: JsonPropertyName("skyblock_harvester")]
    int? skyblock_harvester,
    
    [property: JsonPropertyName("skyblock_gatherer")]
    int? skyblock_gatherer,
    
    [property: JsonPropertyName("skyblock_sb_levels")]
    int? skyblock_sb_levels,
    
    [property: JsonPropertyName("skyblock_concoctor")]
    int? skyblock_concoctor,
    
    [property: JsonPropertyName("skyblock_combat")]
    int? skyblock_combat,
    
    [property: JsonPropertyName("skyblock_domesticator")]
    int? skyblock_domesticator,
    
    [property: JsonPropertyName("skyblock_excavator")]
    int? skyblock_excavator
);

public record Active(
    
    [property: JsonPropertyName("objectives")]
    Objectives objectives,
    
    [property: JsonPropertyName("started")]
    long? started
);

public record AdventRewards2020(
    
    [property: JsonPropertyName("day19")]
    long? day19
);

public record AllTime(
    
    [property: JsonPropertyName("BEDWARS__support")]
    int? BEDWARS__support,
    
    [property: JsonPropertyName("BEDWARS__offensive")]
    int? BEDWARS__offensive
);

public record Arcade(
    
    [property: JsonPropertyName("coins")]
    int? coins,
    
    [property: JsonPropertyName("lastTourneyAd")]
    long? lastTourneyAd
);

public record Arena(
    
    [property: JsonPropertyName("coins")]
    int? coins
);

public record Battleground(
    
    [property: JsonPropertyName("coins")]
    int? coins
);

public record Bedwars(
    
    [property: JsonPropertyName("timeStart")]
    long? timeStart,
    
    [property: JsonPropertyName("timeTook")]
    int? timeTook,
    
    [property: JsonPropertyName("Experience")]
    int? Experience,
    
    [property: JsonPropertyName("bedwars_christmas_boxes")]
    int? bedwars_christmas_boxes,
    
    [property: JsonPropertyName("first_join_7")]
    bool? first_join_7,
    
    [property: JsonPropertyName("free_event_key_bedwars_christmas_boxes_2020")]
    bool? free_event_key_bedwars_christmas_boxes_2020,
    
    [property: JsonPropertyName("packages")]
    IReadOnlyList<string> packages,
    
    [property: JsonPropertyName("Bedwars_openedChests")]
    int? Bedwars_openedChests,
    
    [property: JsonPropertyName("Bedwars_openedCommons")]
    int? Bedwars_openedCommons,
    
    [property: JsonPropertyName("Bedwars_openedRares")]
    int? Bedwars_openedRares,
    
    [property: JsonPropertyName("chest_history_new")]
    IReadOnlyList<string> chest_history_new,
    
    [property: JsonPropertyName("games_played_bedwars_1")]
    int? games_played_bedwars_1,
    
    [property: JsonPropertyName("favourites_2")]
    string favourites_2,
    
    [property: JsonPropertyName("four_three_winstreak")]
    int? four_three_winstreak,
    
    [property: JsonPropertyName("_items_purchased_bedwars")]
    int? _items_purchased_bedwars,
    
    [property: JsonPropertyName("beds_broken_bedwars")]
    int? beds_broken_bedwars,
    
    [property: JsonPropertyName("beds_lost_bedwars")]
    int? beds_lost_bedwars,
    
    [property: JsonPropertyName("coins")]
    int? coins,
    
    [property: JsonPropertyName("deaths_bedwars")]
    int? deaths_bedwars,
    
    [property: JsonPropertyName("diamond_resources_collected_bedwars")]
    int? diamond_resources_collected_bedwars,
    
    [property: JsonPropertyName("emerald_resources_collected_bedwars")]
    int? emerald_resources_collected_bedwars,
    
    [property: JsonPropertyName("entity_attack_final_deaths_bedwars")]
    int? entity_attack_final_deaths_bedwars,
    
    [property: JsonPropertyName("entity_attack_kills_bedwars")]
    int? entity_attack_kills_bedwars,
    
    [property: JsonPropertyName("final_deaths_bedwars")]
    int? final_deaths_bedwars,
    
    [property: JsonPropertyName("four_three__items_purchased_bedwars")]
    int? four_three__items_purchased_bedwars,
    
    [property: JsonPropertyName("four_three_beds_broken_bedwars")]
    int? four_three_beds_broken_bedwars,
    
    [property: JsonPropertyName("four_three_beds_lost_bedwars")]
    int? four_three_beds_lost_bedwars,
    
    [property: JsonPropertyName("four_three_deaths_bedwars")]
    int? four_three_deaths_bedwars,
    
    [property: JsonPropertyName("four_three_diamond_resources_collected_bedwars")]
    int? four_three_diamond_resources_collected_bedwars,
    
    [property: JsonPropertyName("four_three_emerald_resources_collected_bedwars")]
    int? four_three_emerald_resources_collected_bedwars,
    
    [property: JsonPropertyName("four_three_entity_attack_final_deaths_bedwars")]
    int? four_three_entity_attack_final_deaths_bedwars,
    
    [property: JsonPropertyName("four_three_entity_attack_kills_bedwars")]
    int? four_three_entity_attack_kills_bedwars,
    
    [property: JsonPropertyName("four_three_final_deaths_bedwars")]
    int? four_three_final_deaths_bedwars,
    
    [property: JsonPropertyName("four_three_games_played_bedwars")]
    int? four_three_games_played_bedwars,
    
    [property: JsonPropertyName("four_three_gold_resources_collected_bedwars")]
    int? four_three_gold_resources_collected_bedwars,
    
    [property: JsonPropertyName("four_three_iron_resources_collected_bedwars")]
    int? four_three_iron_resources_collected_bedwars,
    
    [property: JsonPropertyName("four_three_items_purchased_bedwars")]
    int? four_three_items_purchased_bedwars,
    
    [property: JsonPropertyName("four_three_kills_bedwars")]
    int? four_three_kills_bedwars,
    
    [property: JsonPropertyName("four_three_losses_bedwars")]
    int? four_three_losses_bedwars,
    
    [property: JsonPropertyName("four_three_permanent_items_purchased_bedwars")]
    int? four_three_permanent_items_purchased_bedwars,
    
    [property: JsonPropertyName("four_three_resources_collected_bedwars")]
    int? four_three_resources_collected_bedwars,
    
    [property: JsonPropertyName("four_three_void_deaths_bedwars")]
    int? four_three_void_deaths_bedwars,
    
    [property: JsonPropertyName("four_three_void_kills_bedwars")]
    int? four_three_void_kills_bedwars,
    
    [property: JsonPropertyName("games_played_bedwars")]
    int? games_played_bedwars,
    
    [property: JsonPropertyName("gold_resources_collected_bedwars")]
    int? gold_resources_collected_bedwars,
    
    [property: JsonPropertyName("iron_resources_collected_bedwars")]
    int? iron_resources_collected_bedwars,
    
    [property: JsonPropertyName("items_purchased_bedwars")]
    int? items_purchased_bedwars,
    
    [property: JsonPropertyName("kills_bedwars")]
    int? kills_bedwars,
    
    [property: JsonPropertyName("losses_bedwars")]
    int? losses_bedwars,
    
    [property: JsonPropertyName("permanent_items_purchased_bedwars")]
    int? permanent_items_purchased_bedwars,
    
    [property: JsonPropertyName("resources_collected_bedwars")]
    int? resources_collected_bedwars,
    
    [property: JsonPropertyName("void_deaths_bedwars")]
    int? void_deaths_bedwars,
    
    [property: JsonPropertyName("void_kills_bedwars")]
    int? void_kills_bedwars,
    
    [property: JsonPropertyName("entity_attack_deaths_bedwars")]
    int? entity_attack_deaths_bedwars,
    
    [property: JsonPropertyName("entity_attack_final_kills_bedwars")]
    int? entity_attack_final_kills_bedwars,
    
    [property: JsonPropertyName("fall_deaths_bedwars")]
    int? fall_deaths_bedwars,
    
    [property: JsonPropertyName("final_kills_bedwars")]
    int? final_kills_bedwars,
    
    [property: JsonPropertyName("four_three_entity_attack_deaths_bedwars")]
    int? four_three_entity_attack_deaths_bedwars,
    
    [property: JsonPropertyName("four_three_entity_attack_final_kills_bedwars")]
    int? four_three_entity_attack_final_kills_bedwars,
    
    [property: JsonPropertyName("four_three_fall_deaths_bedwars")]
    int? four_three_fall_deaths_bedwars,
    
    [property: JsonPropertyName("four_three_final_kills_bedwars")]
    int? four_three_final_kills_bedwars,
    
    [property: JsonPropertyName("four_three_void_final_deaths_bedwars")]
    int? four_three_void_final_deaths_bedwars,
    
    [property: JsonPropertyName("void_final_deaths_bedwars")]
    int? void_final_deaths_bedwars,
    
    [property: JsonPropertyName("four_three_void_final_kills_bedwars")]
    int? four_three_void_final_kills_bedwars,
    
    [property: JsonPropertyName("void_final_kills_bedwars")]
    int? void_final_kills_bedwars,
    
    [property: JsonPropertyName("eight_two_winstreak")]
    int? eight_two_winstreak,
    
    [property: JsonPropertyName("winstreak")]
    int? winstreak,
    
    [property: JsonPropertyName("eight_two__items_purchased_bedwars")]
    int? eight_two__items_purchased_bedwars,
    
    [property: JsonPropertyName("eight_two_beds_broken_bedwars")]
    int? eight_two_beds_broken_bedwars,
    
    [property: JsonPropertyName("eight_two_beds_lost_bedwars")]
    int? eight_two_beds_lost_bedwars,
    
    [property: JsonPropertyName("eight_two_deaths_bedwars")]
    int? eight_two_deaths_bedwars,
    
    [property: JsonPropertyName("eight_two_diamond_resources_collected_bedwars")]
    int? eight_two_diamond_resources_collected_bedwars,
    
    [property: JsonPropertyName("eight_two_emerald_resources_collected_bedwars")]
    int? eight_two_emerald_resources_collected_bedwars,
    
    [property: JsonPropertyName("eight_two_entity_attack_deaths_bedwars")]
    int? eight_two_entity_attack_deaths_bedwars,
    
    [property: JsonPropertyName("eight_two_entity_attack_kills_bedwars")]
    int? eight_two_entity_attack_kills_bedwars,
    
    [property: JsonPropertyName("eight_two_final_kills_bedwars")]
    int? eight_two_final_kills_bedwars,
    
    [property: JsonPropertyName("eight_two_games_played_bedwars")]
    int? eight_two_games_played_bedwars,
    
    [property: JsonPropertyName("eight_two_gold_resources_collected_bedwars")]
    int? eight_two_gold_resources_collected_bedwars,
    
    [property: JsonPropertyName("eight_two_iron_resources_collected_bedwars")]
    int? eight_two_iron_resources_collected_bedwars,
    
    [property: JsonPropertyName("eight_two_items_purchased_bedwars")]
    int? eight_two_items_purchased_bedwars,
    
    [property: JsonPropertyName("eight_two_kills_bedwars")]
    int? eight_two_kills_bedwars,
    
    [property: JsonPropertyName("eight_two_permanent_items_purchased_bedwars")]
    int? eight_two_permanent_items_purchased_bedwars,
    
    [property: JsonPropertyName("eight_two_resources_collected_bedwars")]
    int? eight_two_resources_collected_bedwars,
    
    [property: JsonPropertyName("eight_two_void_deaths_bedwars")]
    int? eight_two_void_deaths_bedwars,
    
    [property: JsonPropertyName("eight_two_void_final_kills_bedwars")]
    int? eight_two_void_final_kills_bedwars,
    
    [property: JsonPropertyName("eight_two_void_kills_bedwars")]
    int? eight_two_void_kills_bedwars,
    
    [property: JsonPropertyName("eight_two_wins_bedwars")]
    int? eight_two_wins_bedwars,
    
    [property: JsonPropertyName("wins_bedwars")]
    int? wins_bedwars,
    
    [property: JsonPropertyName("four_three_wins_bedwars")]
    int? four_three_wins_bedwars,
    
    [property: JsonPropertyName("four_four_winstreak")]
    int? four_four_winstreak,
    
    [property: JsonPropertyName("four_four__items_purchased_bedwars")]
    int? four_four__items_purchased_bedwars,
    
    [property: JsonPropertyName("four_four_deaths_bedwars")]
    int? four_four_deaths_bedwars,
    
    [property: JsonPropertyName("four_four_entity_attack_deaths_bedwars")]
    int? four_four_entity_attack_deaths_bedwars,
    
    [property: JsonPropertyName("four_four_games_played_bedwars")]
    int? four_four_games_played_bedwars,
    
    [property: JsonPropertyName("four_four_gold_resources_collected_bedwars")]
    int? four_four_gold_resources_collected_bedwars,
    
    [property: JsonPropertyName("four_four_iron_resources_collected_bedwars")]
    int? four_four_iron_resources_collected_bedwars,
    
    [property: JsonPropertyName("four_four_items_purchased_bedwars")]
    int? four_four_items_purchased_bedwars,
    
    [property: JsonPropertyName("four_four_losses_bedwars")]
    int? four_four_losses_bedwars,
    
    [property: JsonPropertyName("four_four_magic_deaths_bedwars")]
    int? four_four_magic_deaths_bedwars,
    
    [property: JsonPropertyName("four_four_permanent_items_purchased_bedwars")]
    int? four_four_permanent_items_purchased_bedwars,
    
    [property: JsonPropertyName("four_four_resources_collected_bedwars")]
    int? four_four_resources_collected_bedwars,
    
    [property: JsonPropertyName("magic_deaths_bedwars")]
    int? magic_deaths_bedwars,
    
    [property: JsonPropertyName("Bedwars_openedEpics")]
    int? Bedwars_openedEpics,
    
    [property: JsonPropertyName("practice")]
    Practice practice,
    
    [property: JsonPropertyName("selected_ultimate")]
    string selected_ultimate,
    
    [property: JsonPropertyName("eight_two_ultimate_winstreak")]
    int? eight_two_ultimate_winstreak,
    
    [property: JsonPropertyName("eight_two_ultimate__items_purchased_bedwars")]
    int? eight_two_ultimate__items_purchased_bedwars,
    
    [property: JsonPropertyName("eight_two_ultimate_deaths_bedwars")]
    int? eight_two_ultimate_deaths_bedwars,
    
    [property: JsonPropertyName("eight_two_ultimate_emerald_resources_collected_bedwars")]
    int? eight_two_ultimate_emerald_resources_collected_bedwars,
    
    [property: JsonPropertyName("eight_two_ultimate_entity_attack_deaths_bedwars")]
    int? eight_two_ultimate_entity_attack_deaths_bedwars,
    
    [property: JsonPropertyName("eight_two_ultimate_entity_attack_final_kills_bedwars")]
    int? eight_two_ultimate_entity_attack_final_kills_bedwars,
    
    [property: JsonPropertyName("eight_two_ultimate_final_kills_bedwars")]
    int? eight_two_ultimate_final_kills_bedwars,
    
    [property: JsonPropertyName("eight_two_ultimate_games_played_bedwars")]
    int? eight_two_ultimate_games_played_bedwars,
    
    [property: JsonPropertyName("eight_two_ultimate_gold_resources_collected_bedwars")]
    int? eight_two_ultimate_gold_resources_collected_bedwars,
    
    [property: JsonPropertyName("eight_two_ultimate_iron_resources_collected_bedwars")]
    int? eight_two_ultimate_iron_resources_collected_bedwars,
    
    [property: JsonPropertyName("eight_two_ultimate_items_purchased_bedwars")]
    int? eight_two_ultimate_items_purchased_bedwars,
    
    [property: JsonPropertyName("eight_two_ultimate_permanent_items_purchased_bedwars")]
    int? eight_two_ultimate_permanent_items_purchased_bedwars,
    
    [property: JsonPropertyName("eight_two_ultimate_resources_collected_bedwars")]
    int? eight_two_ultimate_resources_collected_bedwars,
    
    [property: JsonPropertyName("eight_two_ultimate_void_deaths_bedwars")]
    int? eight_two_ultimate_void_deaths_bedwars,
    
    [property: JsonPropertyName("eight_two_ultimate_void_final_kills_bedwars")]
    int? eight_two_ultimate_void_final_kills_bedwars,
    
    [property: JsonPropertyName("eight_two_ultimate_wins_bedwars")]
    int? eight_two_ultimate_wins_bedwars,
    
    [property: JsonPropertyName("eight_two_fall_final_deaths_bedwars")]
    int? eight_two_fall_final_deaths_bedwars,
    
    [property: JsonPropertyName("eight_two_final_deaths_bedwars")]
    int? eight_two_final_deaths_bedwars,
    
    [property: JsonPropertyName("eight_two_losses_bedwars")]
    int? eight_two_losses_bedwars,
    
    [property: JsonPropertyName("fall_final_deaths_bedwars")]
    int? fall_final_deaths_bedwars,
    
    [property: JsonPropertyName("eight_two_entity_attack_final_kills_bedwars")]
    int? eight_two_entity_attack_final_kills_bedwars,
    
    [property: JsonPropertyName("eight_two_void_final_deaths_bedwars")]
    int? eight_two_void_final_deaths_bedwars,
    
    [property: JsonPropertyName("eight_two_fall_deaths_bedwars")]
    int? eight_two_fall_deaths_bedwars,
    
    [property: JsonPropertyName("eight_two_entity_attack_final_deaths_bedwars")]
    int? eight_two_entity_attack_final_deaths_bedwars,
    
    [property: JsonPropertyName("four_four_beds_broken_bedwars")]
    int? four_four_beds_broken_bedwars,
    
    [property: JsonPropertyName("four_four_entity_attack_kills_bedwars")]
    int? four_four_entity_attack_kills_bedwars,
    
    [property: JsonPropertyName("four_four_kills_bedwars")]
    int? four_four_kills_bedwars,
    
    [property: JsonPropertyName("four_four_void_deaths_bedwars")]
    int? four_four_void_deaths_bedwars,
    
    [property: JsonPropertyName("four_four_void_kills_bedwars")]
    int? four_four_void_kills_bedwars,
    
    [property: JsonPropertyName("four_four_wins_bedwars")]
    int? four_four_wins_bedwars,
    
    [property: JsonPropertyName("four_four_diamond_resources_collected_bedwars")]
    int? four_four_diamond_resources_collected_bedwars,
    
    [property: JsonPropertyName("four_four_entity_attack_final_kills_bedwars")]
    int? four_four_entity_attack_final_kills_bedwars,
    
    [property: JsonPropertyName("four_four_final_kills_bedwars")]
    int? four_four_final_kills_bedwars,
    
    [property: JsonPropertyName("four_four_magic_final_kills_bedwars")]
    int? four_four_magic_final_kills_bedwars,
    
    [property: JsonPropertyName("four_four_void_final_kills_bedwars")]
    int? four_four_void_final_kills_bedwars,
    
    [property: JsonPropertyName("magic_final_kills_bedwars")]
    int? magic_final_kills_bedwars,
    
    [property: JsonPropertyName("fall_kills_bedwars")]
    int? fall_kills_bedwars,
    
    [property: JsonPropertyName("four_four_fall_kills_bedwars")]
    int? four_four_fall_kills_bedwars,
    
    [property: JsonPropertyName("fall_final_kills_bedwars")]
    int? fall_final_kills_bedwars,
    
    [property: JsonPropertyName("four_four_emerald_resources_collected_bedwars")]
    int? four_four_emerald_resources_collected_bedwars,
    
    [property: JsonPropertyName("four_four_fall_deaths_bedwars")]
    int? four_four_fall_deaths_bedwars,
    
    [property: JsonPropertyName("four_four_fall_final_kills_bedwars")]
    int? four_four_fall_final_kills_bedwars,
    
    [property: JsonPropertyName("four_four_beds_lost_bedwars")]
    int? four_four_beds_lost_bedwars,
    
    [property: JsonPropertyName("four_four_entity_attack_final_deaths_bedwars")]
    int? four_four_entity_attack_final_deaths_bedwars,
    
    [property: JsonPropertyName("four_four_final_deaths_bedwars")]
    int? four_four_final_deaths_bedwars,
    
    [property: JsonPropertyName("eight_two_fall_kills_bedwars")]
    int? eight_two_fall_kills_bedwars,
    
    [property: JsonPropertyName("eight_two_magic_final_deaths_bedwars")]
    int? eight_two_magic_final_deaths_bedwars,
    
    [property: JsonPropertyName("magic_final_deaths_bedwars")]
    int? magic_final_deaths_bedwars,
    
    [property: JsonPropertyName("understands_resource_bank")]
    bool? understands_resource_bank,
    
    [property: JsonPropertyName("castle__items_purchased_bedwars")]
    int? castle__items_purchased_bedwars,
    
    [property: JsonPropertyName("castle_deaths_bedwars")]
    int? castle_deaths_bedwars,
    
    [property: JsonPropertyName("castle_diamond_resources_collected_bedwars")]
    int? castle_diamond_resources_collected_bedwars,
    
    [property: JsonPropertyName("castle_entity_attack_final_kills_bedwars")]
    int? castle_entity_attack_final_kills_bedwars,
    
    [property: JsonPropertyName("castle_final_kills_bedwars")]
    int? castle_final_kills_bedwars,
    
    [property: JsonPropertyName("castle_games_played_bedwars")]
    int? castle_games_played_bedwars,
    
    [property: JsonPropertyName("castle_gold_resources_collected_bedwars")]
    int? castle_gold_resources_collected_bedwars,
    
    [property: JsonPropertyName("castle_iron_resources_collected_bedwars")]
    int? castle_iron_resources_collected_bedwars,
    
    [property: JsonPropertyName("castle_items_purchased_bedwars")]
    int? castle_items_purchased_bedwars,
    
    [property: JsonPropertyName("castle_kills_bedwars")]
    int? castle_kills_bedwars,
    
    [property: JsonPropertyName("castle_permanent_items_purchased_bedwars")]
    int? castle_permanent_items_purchased_bedwars,
    
    [property: JsonPropertyName("castle_resources_collected_bedwars")]
    int? castle_resources_collected_bedwars,
    
    [property: JsonPropertyName("castle_void_deaths_bedwars")]
    int? castle_void_deaths_bedwars,
    
    [property: JsonPropertyName("castle_void_kills_bedwars")]
    int? castle_void_kills_bedwars,
    
    [property: JsonPropertyName("castle_wins_bedwars")]
    int? castle_wins_bedwars,
    
    [property: JsonPropertyName("castle_winstreak")]
    int? castle_winstreak,
    
    [property: JsonPropertyName("bedwars_boxes")]
    int? bedwars_boxes,
    
    [property: JsonPropertyName("castle_beds_lost_bedwars")]
    int? castle_beds_lost_bedwars,
    
    [property: JsonPropertyName("castle_final_deaths_bedwars")]
    int? castle_final_deaths_bedwars,
    
    [property: JsonPropertyName("castle_losses_bedwars")]
    int? castle_losses_bedwars,
    
    [property: JsonPropertyName("castle_void_final_deaths_bedwars")]
    int? castle_void_final_deaths_bedwars,
    
    [property: JsonPropertyName("eight_two_magic_deaths_bedwars")]
    int? eight_two_magic_deaths_bedwars,
    
    [property: JsonPropertyName("castle_entity_attack_deaths_bedwars")]
    int? castle_entity_attack_deaths_bedwars,
    
    [property: JsonPropertyName("castle_entity_attack_final_deaths_bedwars")]
    int? castle_entity_attack_final_deaths_bedwars,
    
    [property: JsonPropertyName("castle_entity_attack_kills_bedwars")]
    int? castle_entity_attack_kills_bedwars,
    
    [property: JsonPropertyName("castle_emerald_resources_collected_bedwars")]
    int? castle_emerald_resources_collected_bedwars,
    
    [property: JsonPropertyName("castle_void_final_kills_bedwars")]
    int? castle_void_final_kills_bedwars,
    
    [property: JsonPropertyName("castle_entity_explosion_final_deaths_bedwars")]
    int? castle_entity_explosion_final_deaths_bedwars,
    
    [property: JsonPropertyName("entity_explosion_deaths_bedwars")]
    int? entity_explosion_deaths_bedwars,
    
    [property: JsonPropertyName("four_four_entity_explosion_deaths_bedwars")]
    int? four_four_entity_explosion_deaths_bedwars,
    
    [property: JsonPropertyName("four_four_magic_kills_bedwars")]
    int? four_four_magic_kills_bedwars,
    
    [property: JsonPropertyName("magic_kills_bedwars")]
    int? magic_kills_bedwars,
    
    [property: JsonPropertyName("four_four_void_final_deaths_bedwars")]
    int? four_four_void_final_deaths_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_winstreak")]
    int? four_four_voidless_winstreak,
    
    [property: JsonPropertyName("four_four_voidless__items_purchased_bedwars")]
    int? four_four_voidless__items_purchased_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_beds_lost_bedwars")]
    int? four_four_voidless_beds_lost_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_deaths_bedwars")]
    int? four_four_voidless_deaths_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_entity_attack_deaths_bedwars")]
    int? four_four_voidless_entity_attack_deaths_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_entity_attack_final_deaths_bedwars")]
    int? four_four_voidless_entity_attack_final_deaths_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_entity_attack_final_kills_bedwars")]
    int? four_four_voidless_entity_attack_final_kills_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_entity_attack_kills_bedwars")]
    int? four_four_voidless_entity_attack_kills_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_final_deaths_bedwars")]
    int? four_four_voidless_final_deaths_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_final_kills_bedwars")]
    int? four_four_voidless_final_kills_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_games_played_bedwars")]
    int? four_four_voidless_games_played_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_gold_resources_collected_bedwars")]
    int? four_four_voidless_gold_resources_collected_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_iron_resources_collected_bedwars")]
    int? four_four_voidless_iron_resources_collected_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_items_purchased_bedwars")]
    int? four_four_voidless_items_purchased_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_kills_bedwars")]
    int? four_four_voidless_kills_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_losses_bedwars")]
    int? four_four_voidless_losses_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_permanent_items_purchased_bedwars")]
    int? four_four_voidless_permanent_items_purchased_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_resources_collected_bedwars")]
    int? four_four_voidless_resources_collected_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_fall_kills_bedwars")]
    int? four_four_voidless_fall_kills_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_wins_bedwars")]
    int? four_four_voidless_wins_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_diamond_resources_collected_bedwars")]
    int? four_four_voidless_diamond_resources_collected_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_emerald_resources_collected_bedwars")]
    int? four_four_voidless_emerald_resources_collected_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_fall_deaths_bedwars")]
    int? four_four_voidless_fall_deaths_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_fall_final_kills_bedwars")]
    int? four_four_voidless_fall_final_kills_bedwars,
    
    [property: JsonPropertyName("four_four_voidless_beds_broken_bedwars")]
    int? four_four_voidless_beds_broken_bedwars,
    
    [property: JsonPropertyName("entity_explosion_final_deaths_bedwars")]
    int? entity_explosion_final_deaths_bedwars,
    
    [property: JsonPropertyName("four_four_entity_explosion_final_deaths_bedwars")]
    int? four_four_entity_explosion_final_deaths_bedwars,
    
    [property: JsonPropertyName("selected_challenge_type")]
    string selected_challenge_type,
    
    [property: JsonPropertyName("lastTourneyAd")]
    long? lastTourneyAd,
    
    [property: JsonPropertyName("0")]
    int? _0,
    
    [property: JsonPropertyName("1")]
    int? _1,
    
    [property: JsonPropertyName("2")]
    int? _2,
    
    [property: JsonPropertyName("3")]
    int? _3
);

public record BedwarsDailyOneMore(
    
    [property: JsonPropertyName("completions")]
    IReadOnlyList<Completion> completions
);

public record BedwarsDailyWin(
    
    [property: JsonPropertyName("completions")]
    IReadOnlyList<Completion> completions
);

public record BedwarsWeeklyBedElims(
    
    [property: JsonPropertyName("active")]
    Active active
);

public record BedwarsWeeklyDreamWin(
    
    [property: JsonPropertyName("active")]
    Active active
);

public record Bfdc54f84ff64123b1bb11c2340db55e(
    
    [property: JsonPropertyName("profile_id")]
    string profile_id,
    
    [property: JsonPropertyName("cute_name")]
    string cute_name
);

public record Bridging(
    
    [property: JsonPropertyName("blocks_placed")]
    int? blocks_placed,
    
    [property: JsonPropertyName("failed_attempts")]
    int? failed_attempts
);

public record Challenges(
    
    [property: JsonPropertyName("all_time")]
    AllTime all_time
);

public record Christmas(
    
    [property: JsonPropertyName("2022")]
    _2022 _2022
);

public record Completion(
    
    [property: JsonPropertyName("time")]
    long? time
);

public record Duels(
    
    [property: JsonPropertyName("show_lb_option")]
    string show_lb_option,
    
    [property: JsonPropertyName("games_played_duels")]
    int? games_played_duels,
    
    [property: JsonPropertyName("chat_enabled")]
    string chat_enabled,
    
    [property: JsonPropertyName("blocks_placed")]
    int? blocks_placed,
    
    [property: JsonPropertyName("damage_dealt")]
    int? damage_dealt,
    
    [property: JsonPropertyName("golden_apples_eaten")]
    int? golden_apples_eaten,
    
    [property: JsonPropertyName("health_regenerated")]
    int? health_regenerated,
    
    [property: JsonPropertyName("melee_hits")]
    int? melee_hits,
    
    [property: JsonPropertyName("melee_swings")]
    int? melee_swings,
    
    [property: JsonPropertyName("rounds_played")]
    int? rounds_played,
    
    [property: JsonPropertyName("uhc_duel_blocks_placed")]
    int? uhc_duel_blocks_placed,
    
    [property: JsonPropertyName("uhc_duel_damage_dealt")]
    int? uhc_duel_damage_dealt,
    
    [property: JsonPropertyName("uhc_duel_golden_apples_eaten")]
    int? uhc_duel_golden_apples_eaten,
    
    [property: JsonPropertyName("uhc_duel_health_regenerated")]
    int? uhc_duel_health_regenerated,
    
    [property: JsonPropertyName("uhc_duel_melee_hits")]
    int? uhc_duel_melee_hits,
    
    [property: JsonPropertyName("uhc_duel_melee_swings")]
    int? uhc_duel_melee_swings,
    
    [property: JsonPropertyName("uhc_duel_rounds_played")]
    int? uhc_duel_rounds_played
);

public record Easter(
    
    [property: JsonPropertyName("2023")]
    _2023 _2023
);

public record Easter2021Cooldowns2(
    
    [property: JsonPropertyName("NORMAL3")]
    bool? NORMAL3,
    
    [property: JsonPropertyName("NORMAL2")]
    bool? NORMAL2,
    
    [property: JsonPropertyName("NORMAL1")]
    bool? NORMAL1,
    
    [property: JsonPropertyName("NORMAL0")]
    bool? NORMAL0
);

public record Eugene(
    
    [property: JsonPropertyName("dailyTwoKExp")]
    long? dailyTwoKExp
);

public record GingerBread(
    
    [property: JsonPropertyName("coins")]
    int? coins,
    
    [property: JsonPropertyName("lastTourneyAd")]
    long? lastTourneyAd
);

public record HungerGames(
    
    [property: JsonPropertyName("coins")]
    int? coins
);

public record Leveling(
    
    [property: JsonPropertyName("claimedRewards")]
    IReadOnlyList<int?> claimedRewards
);

public record Levelling(
    
    [property: JsonPropertyName("experience")]
    int? experience
);

public record MCGO(
    
    [property: JsonPropertyName("coins")]
    int? coins
);

public record MurderMystery(
    
    [property: JsonPropertyName("mm_christmas_chests")]
    int? mm_christmas_chests,
    
    [property: JsonPropertyName("packages")]
    IReadOnlyList<string> packages,
    
    [property: JsonPropertyName("coins")]
    int? coins
);

public record Objectives(
    
    [property: JsonPropertyName("bedwars_dream_wins")]
    int? bedwars_dream_wins,
    
    [property: JsonPropertyName("bedwars_bed_elims")]
    int? bedwars_bed_elims
);

public record Paintball(
    
    [property: JsonPropertyName("coins")]
    int? coins
);

public record ParkourCheckpointBests(
    
    [property: JsonPropertyName("Bedwars")]
    Bedwars Bedwars
);

public record ParkourCompletions(
    
    [property: JsonPropertyName("Bedwars")]
    IReadOnlyList<Bedwars> Bedwars
);

public record Player(
    
    [property: JsonPropertyName("_id")]
    string _id,
    
    [property: JsonPropertyName("uuid")]
    string uuid,
    
    [property: JsonPropertyName("displayname")]
    string displayname,
    
    [property: JsonPropertyName("firstLogin")]
    long? firstLogin,
    
    [property: JsonPropertyName("lastLogin")]
    long? lastLogin,
    
    [property: JsonPropertyName("playername")]
    string playername,
    
    [property: JsonPropertyName("achievementsOneTime")]
    IReadOnlyList<string> achievementsOneTime,
    
    [property: JsonPropertyName("lastLogout")]
    long? lastLogout,
    
    [property: JsonPropertyName("networkExp")]
    double? networkExp,
    
    [property: JsonPropertyName("karma")]
    int? karma,
    
    [property: JsonPropertyName("stats")]
    Stats stats,
    
    [property: JsonPropertyName("achievementPoints")]
    int? achievementPoints,
    
    [property: JsonPropertyName("achievements")]
    Achievements achievements,
    
    [property: JsonPropertyName("adventRewards2020")]
    AdventRewards2020 adventRewards2020,
    
    [property: JsonPropertyName("achievementTracking")]
    IReadOnlyList<object> achievementTracking,
    
    [property: JsonPropertyName("eugene")]
    Eugene eugene,
    
    [property: JsonPropertyName("channel")]
    string channel,
    
    [property: JsonPropertyName("challenges")]
    Challenges challenges,
    
    [property: JsonPropertyName("easter2021Cooldowns2")]
    Easter2021Cooldowns2 easter2021Cooldowns2,
    
    [property: JsonPropertyName("achievementRewardsNew")]
    AchievementRewardsNew achievementRewardsNew,
    
    [property: JsonPropertyName("quests")]
    Quests quests,
    
    [property: JsonPropertyName("parkourCheckpointBests")]
    ParkourCheckpointBests parkourCheckpointBests,
    
    [property: JsonPropertyName("parkourCompletions")]
    ParkourCompletions parkourCompletions,
    
    [property: JsonPropertyName("claimed_century_cake200")]
    long? claimed_century_cake200,
    
    [property: JsonPropertyName("leveling")]
    Leveling leveling,
    
    [property: JsonPropertyName("mostRecentGameType")]
    string mostRecentGameType
);

public record Practice(
    
    [property: JsonPropertyName("selected")]
    string selected,
    
    [property: JsonPropertyName("bridging")]
    Bridging bridging
);

public record Profiles(
    
    [property: JsonPropertyName("0533030fbac048fbb35f00161a1da045")]
    _0533030fbac048fbb35f00161a1da045 _0533030fbac048fbb35f00161a1da045,
    
    [property: JsonPropertyName("bfdc54f84ff64123b1bb11c2340db55e")]
    Bfdc54f84ff64123b1bb11c2340db55e bfdc54f84ff64123b1bb11c2340db55e
);

public record Quake(
    
    [property: JsonPropertyName("coins")]
    int? coins,
    
    [property: JsonPropertyName("lastTourneyAd")]
    long? lastTourneyAd
);

public record Quests(
    
    [property: JsonPropertyName("bedwars_weekly_dream_win")]
    BedwarsWeeklyDreamWin bedwars_weekly_dream_win,
    
    [property: JsonPropertyName("bedwars_weekly_bed_elims")]
    BedwarsWeeklyBedElims bedwars_weekly_bed_elims,
    
    [property: JsonPropertyName("bedwars_daily_win")]
    BedwarsDailyWin bedwars_daily_win,
    
    [property: JsonPropertyName("bedwars_daily_one_more")]
    BedwarsDailyOneMore bedwars_daily_one_more
);

public record Root(
    
    [property: JsonPropertyName("success")]
    bool? success,
    
    [property: JsonPropertyName("player")]
    Player player
);


public record SkyBlock(
    
    [property: JsonPropertyName("profiles")]
    Profiles profiles
);

public record SkyWars(
    
    [property: JsonPropertyName("coins")]
    int? coins,
    
    [property: JsonPropertyName("lastTourneyAd")]
    long? lastTourneyAd
);

public record SpeedUHC(
    
    [property: JsonPropertyName("coins")]
    int? coins
);

public record Stats(
    
    [property: JsonPropertyName("Arena")]
    Arena Arena,
    
    [property: JsonPropertyName("GingerBread")]
    GingerBread GingerBread,
    
    [property: JsonPropertyName("Paintball")]
    Paintball Paintball,
    
    [property: JsonPropertyName("Quake")]
    Quake Quake,
    
    [property: JsonPropertyName("VampireZ")]
    VampireZ VampireZ,
    
    [property: JsonPropertyName("Walls")]
    Walls Walls,
    
    [property: JsonPropertyName("Walls3")]
    Walls3 Walls3,
    
    [property: JsonPropertyName("MCGO")]
    MCGO MCGO,
    
    [property: JsonPropertyName("Battleground")]
    Battleground Battleground,
    
    [property: JsonPropertyName("HungerGames")]
    HungerGames HungerGames,
    
    [property: JsonPropertyName("SkyWars")]
    SkyWars SkyWars,
    
    [property: JsonPropertyName("UHC")]
    UHC UHC,
    
    [property: JsonPropertyName("TNTGames")]
    TNTGames TNTGames,
    
    [property: JsonPropertyName("SuperSmash")]
    SuperSmash SuperSmash,
    
    [property: JsonPropertyName("Arcade")]
    Arcade Arcade,
    
    [property: JsonPropertyName("Bedwars")]
    Bedwars Bedwars,
    
    [property: JsonPropertyName("MurderMystery")]
    MurderMystery MurderMystery,
    
    [property: JsonPropertyName("SkyBlock")]
    SkyBlock SkyBlock,
    
    [property: JsonPropertyName("SpeedUHC")]
    SpeedUHC SpeedUHC,
    
    [property: JsonPropertyName("Duels")]
    Duels Duels,
    
    [property: JsonPropertyName("WoolGames")]
    WoolGames WoolGames
);

public record PlayerStats(Dictionary<string, YearData> Seasonal);

public record YearData(Dictionary<string, Levelling> Levelling);

public record Profile(string ProfileId, string CuteName);

public record SuperSmash(
    
    [property: JsonPropertyName("coins")]
    int? coins
);

public record TNTGames(
    
    [property: JsonPropertyName("coins")]
    int? coins
);

public record UHC(
    
    [property: JsonPropertyName("coins")]
    int? coins
);

public record VampireZ(
    
    [property: JsonPropertyName("coins")]
    int? coins
);

public record Walls(
    
    [property: JsonPropertyName("coins")]
    int? coins
);

public record Walls3(
    
    [property: JsonPropertyName("coins")]
    int? coins
);

public record WoolGames(
    
    [property: JsonPropertyName("lastTourneyAd")]
    long? lastTourneyAd
);