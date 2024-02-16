using NDJH.Hypixel.API.Models.SkyBlock;
using NDJH.Hypixel.API.Services;
using NDJH.Hypixel.API.Tests.Shared;
using NSubstitute;

namespace NDJH.Hypixel.API.IntegrationTests.ServiceTests;

public class SkyBlockTests
{
    [Fact]
    public async Task GetCollectionsAsync_ReturnsCollectionResponse()
    {
        // Arrange
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<CollectionResponse>("TestsData/SkyBlock/Collections.json");
        var resourceData = new SkyBlock(mockService);

        // Act
        var actual = await resourceData.GetCollectionsAsync();

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<CollectionResponse>($"resources/skyblock/collections",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task GetSkillsAsync_ReturnsSkillsResponse()
    {
        // Arrange
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<SkillsResponse>("TestsData/SkyBlock/Skills.json");
        var resourceData = new SkyBlock(mockService);

        // Act
        var actual = await resourceData.GetSkillsAsync();

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<SkillsResponse>($"resources/skyblock/skills",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task GetItemsAsync_ReturnsItemsResponse()
    {
        // Arrange
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<ItemsResponse>("TestsData/SkyBlock/Items.json");
        var resourceData = new SkyBlock(mockService);

        // Act
        var actual = await resourceData.GetItemsAsync();

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<ItemsResponse>($"resources/skyblock/items",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task GetElectionAsync_ReturnsElectionResponse()
    {
        // Arrange
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<ElectionsResponse>("TestsData/SkyBlock/Election.json");
        var resourceData = new SkyBlock(mockService);

        // Act
        var actual = await resourceData.GetElectionsAsync();

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<ElectionsResponse>($"resources/skyblock/election",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task GetBingoAsync_ReturnsBingoResponse()
    {
        // Arrange
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<BingoResponse>("TestsData/SkyBlock/Bingo.json");
        var resourceData = new SkyBlock(mockService);

        // Act
        var actual = await resourceData.GetBingoAsync();

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<BingoResponse>($"resources/skyblock/bingo",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task GetNewsAsync_ReturnsNewsResponse()
    {
        // Arrange
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<NewsResponse>("TestsData/SkyBlock/News.json");
        var resourceData = new SkyBlock(mockService);

        // Act
        var actual = await resourceData.GetNewsAsync();

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<NewsResponse>($"skyblock/news",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task GetAuctionAsync_ReturnsAuctionResponse()
    {
        // Arrange
        var uuid = TestConstants.Uuid.ToString();
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<AuctionResponse>("TestsData/SkyBlock/Auction.json");
        var resourceData = new SkyBlock(mockService);

        // Act
        var actual = await resourceData.GetAuctionAsync(uuid, InputType.Player);

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<AuctionResponse>($"skyblock/auction?player={uuid}",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task GetAuctionsAsync_ReturnsAuctionsResponse()
    {
        // Arrange
        const int page = 0;
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<AuctionsResponse>("TestsData/SkyBlock/Auctions.json");
        var resourceData = new SkyBlock(mockService);

        // Act
        var actual = await resourceData.GetActiveAuctionsAsync(page);

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<AuctionsResponse>($"skyblock/auctions?page={page}",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task GetEndedAuctionsAsync_ReturnsEndedAuctionsResponse()
    {
        // Arrange
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<AuctionsHistoryResponse>("TestsData/SkyBlock/Auctions.json");
        var resourceData = new SkyBlock(mockService);

        // Act
        var actual = await resourceData.GetAuctionsHistoryAsync();

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<AuctionsHistoryResponse>($"skyblock/auctions_ended",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task GetBazaarAsync_ReturnsBazaarResponse()
    {
        // Arrange
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<BazaarResponse>("TestsData/SkyBlock/Bazaar.json");
        var resourceData = new SkyBlock(mockService);

        // Act
        var actual = await resourceData.GetBazaarAsync();

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<BazaarResponse>($"skyblock/bazaar",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task GetProfileAsync_ReturnsProfileResponse()
    {
        // Arrange
        var uuid = TestConstants.Uuid.ToString();
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<ProfileResponse>("TestsData/SkyBlock/Profile.json");
        var resourceData = new SkyBlock(mockService);

        // Act
        var actual = await resourceData.GetProfileAsync(uuid);

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<ProfileResponse>($"skyblock/profile?profile={uuid}",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task GetProfilesAsync_ReturnsProfilesResponse()
    {
        // Arrange
        var uuid = TestConstants.Uuid.ToString();
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<ProfilesResponse>("TestsData/SkyBlock/Profiles.json");
        var resourceData = new SkyBlock(mockService);

        // Act
        var actual = await resourceData.GetProfilesAsync(uuid);

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<ProfilesResponse>($"skyblock/profiles?uuid={uuid}",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task GetAsync_ReturnsResponse()
    {
        // Arrange
        const string uuid = "5417cf1b-c668-48f7-a443-5ccc1d400451";
        var (mockService, expected) =
            await TestsUtility.SetupMockServiceAsync<BingoCompletionsResponse>(
                "TestsData/SkyBlock/BingoCompletions.json");
        var resourceData = new SkyBlock(mockService);

        // Act
        var actual = await resourceData.GetBingoCompletionsAsync(uuid);

        // Assert
        await mockService.Received()
            .RequestAndSerializeResponseAsync<BingoCompletionsResponse>($"skyblock/bingo?uuid={uuid}",
                Arg.Any<CancellationToken>());
        Assert.Equal(expected, actual);
    }
}