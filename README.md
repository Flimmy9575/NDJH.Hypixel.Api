# NDJH.Hypixel.API

An implementation of the Hypixel API v2 created in C#.

This project is not affiliated or endorsed by Hypixel Inc.

### Supported Endpoints

Below are the current supported endpoints.

- ✅ Stands for full support
- 🏷️ Stands for half support(No serialization to an object)
- ❌ Stands for not implemented yet

[//]: # (Emojis: ✅❌🏷️)

| EndpointName              | Method                                 | Support |
|---------------------------|----------------------------------------|:-------:|
| Player                    | PlayerData.GetPlayerAsync              |    ❌    |
| RecentGames               | PlayerData.GetRecentGamesAsync         |    ✅    |
| Status                    | PlayerData.GetStatusAsync              |    ✅    |
| Guild                     | PlayerData.GetGuildAsync               |    ✅    |
| Games                     | None                                   |    ❌    |
| Achievements              | Resource.GetAchievementsAsync          |    ✅    |
| Challenges                | Resource.GetChallengesAsync            |    ✅    |
| Quests                    | Resource.GetQuestsAsync                |    ✅    |
| Guild Achievements        | Resource.GetGuildAchievements          |    ✅    |
| Vanity Pets               | Resource.GetVanityPetsInformationAsync |    ✅    |
| Companions                | Resource.GetCompanionInformationAsync  |    ✅    |
| SkyBlock Collections Info | SkyBlock.GetCollectionsAsync           |    ✅    |
| SkyBlock Skills Info      | SkyBlock.GetSkillsAsync                |    ✅    |
| SkyBlock Items Info       | SkyBlock.GetItemsAsync                 |    ✅    |
| SkyBlock Elections Info   | SkyBlock.GetElectionsAsync             |    ✅    |
| SkyBlock Bingo Info       | SkyBlock.GetBingoAsync                 |    ✅    |
| SkyBlock News             | SkyBlock.GetNewsAsync                  |    ✅    |
| SkyBlock Auction          | SkyBlock.GetAuctionAsync               |    ✅    |
| SkyBlock Active Auctions  | SkyBlock.GetActiveAuctionsAsync        |    ✅    |
| SkyBlock Ended Auctions   | SkyBlock.GetAuctionsHistoryAsync       |    ✅    |
| SkyBlock Bazaar           | SkyBlock.GetBazaarAsync                |    ✅    |
| SkyBlock Profile          | SkyBlock.GetProfileAsync               |    ✅    |
| SkyBlock Profiles         | SkyBlock.GetProfilesAsync              |    ✅    |
| SkyBlock Museum           | None                                   |    ❌    |
| SkyBlock Bingo User Info  | SkyBlock.GetBingoCompletionsAsync      |    ✅    |
| SkyBlock Fire Sales       | None                                   |    ❌    |
| Active Network Boosters   | None                                   |    ❌    |
| Player Counts             | None                                   |    ❌    |
| Leaderboards              | None                                   |    ❌    |
| Punishment Stats          | None                                   |    ❌    |

## Installation

### From Nuget

### From Source

## Configuration

#### Using Dependency Injection

To utilize dependency injection in your project, ensure that you install the `NDJH.Hpixel.API.DependencyInjection`
package first. This package enables automatic dependency injection of Hypixel API services.

You'll have to add a `Hypixel` section to your application's configuration file as demonstrated below:

```json
{
  "Hypixel": {
    "BaseUrl": "",
    "ApiKey": ""
  }
}
```

**Note:** It's not necessary to include a base URL in your configuration. The program will automatically read the
configuration and load it into your application.
The configuration will automatically be read and loaded into your application.

The `BaseUrl` is the base URL for Hypixel API services and `ApiKey` is your personal API key that authorizes you to
access the Hypixel API services.

Ensure that this configuration file is located in the root of your project unless your application's logic specifies a
different location.

## Examples

# License

This project is licensed under the GNU LGPLv3 License. See [LICENSE](https://github.com/Flimmy9575/NDJH.Hypixel.Api/blob/master/LICENSE)