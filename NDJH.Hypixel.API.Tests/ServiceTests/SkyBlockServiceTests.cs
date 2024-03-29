﻿using NDJH.Hypixel.API.Models.SkyBlock;
using NDJH.Hypixel.API.Services;
using NDJH.Hypixel.API.Services.Abstractions;
using NDJH.Hypixel.API.Tests.Shared;
using NSubstitute;

namespace NDJH.Hypixel.API.Tests.ServiceTests;

public class SkyBlockServiceTests
{
    private readonly IHttpDeserializerService _httpRequestAndDeserializer;
    private readonly SkyBlock _skyBlockService;

    public SkyBlockServiceTests()
    {
        _httpRequestAndDeserializer = Substitute.For<IHttpDeserializerService>();
        _skyBlockService = new SkyBlock(_httpRequestAndDeserializer);
    }

    [Fact]
    public async Task TestGetCollectionsAsync()
    {
        await _skyBlockService.GetCollectionsAsync();
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<CollectionResponse>("resources/skyblock/collections",
                CancellationToken.None);
    }

    [Fact]
    public async Task TestGetSkillsAsync()
    {
        await _skyBlockService.GetSkillsAsync();
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<SkillsResponse>("resources/skyblock/skills", CancellationToken.None);
    }

    [Fact]
    public async Task TestGetItemsAsync()
    {
        await _skyBlockService.GetItemsAsync();
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<ItemsResponse>("resources/skyblock/items", CancellationToken.None);
    }

    [Fact]
    public async Task TestGetElectionsAsync()
    {
        await _skyBlockService.GetElectionsAsync();
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<
                ElectionsResponse>("resources/skyblock/election", CancellationToken.None);
    }

    [Fact]
    public async Task TestGetBingoAsync()
    {
        await _skyBlockService.GetBingoAsync();
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<BingoResponse>("resources/skyblock/bingo", CancellationToken.None);
    }

    [Fact]
    public async Task TestGetNewsAsync()
    {
        await _skyBlockService.GetNewsAsync();
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<NewsResponse>("skyblock/news", CancellationToken.None);
    }

    [Fact]
    public async Task TestGetAuctionAsync()
    {
        const InputType inputType = InputType.Uuid;
        await _skyBlockService.GetAuctionAsync(TestConstants.Uuid.ToString(), inputType);
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<AuctionResponse>(
                $"skyblock/auction?{inputType.ToString().ToLower()}={TestConstants.Uuid.ToString()}",
                CancellationToken.None);
    }

    [Fact]
    public async Task TestGetActiveAuctionsAsync()
    {
        const int page = 1;
        await _skyBlockService.GetActiveAuctionsAsync(page);
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<AuctionsResponse>($"skyblock/auctions?page={page}",
                CancellationToken.None);
    }

    [Fact]
    public async Task TestGetAuctionsHistoryAsync()
    {
        await _skyBlockService.GetAuctionsHistoryAsync();
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<AuctionsHistoryResponse>("skyblock/auctions_ended",
                CancellationToken.None);
    }

    [Fact]
    public async Task TestGetBazaarAsync()
    {
        await _skyBlockService.GetBazaarAsync();
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<BazaarResponse>("skyblock/bazaar", CancellationToken.None);
    }

    [Fact]
    public async Task TestGetProfileAsync()
    {
        var profileId = "test-profile-id";
        await _skyBlockService.GetProfileAsync(profileId);
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<ProfileResponse>($"skyblock/profile?profile={profileId}",
                CancellationToken.None);
    }

    [Fact]
    public async Task TestGetProfilesAsync()
    {
        await _skyBlockService.GetProfilesAsync(TestConstants.Uuid.ToString());
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<ProfilesResponse>(
                $"skyblock/profiles?uuid={TestConstants.Uuid.ToString()}", CancellationToken.None);
    }

    [Fact]
    public async Task TestGetBingoCompletionsAsync()
    {
        await _skyBlockService.GetBingoCompletionsAsync(TestConstants.Uuid.ToString());
        await _httpRequestAndDeserializer.Received()
            .RequestAndSerializeResponseAsync<BingoCompletionsResponse>(
                $"skyblock/bingo?uuid={TestConstants.Uuid.ToString()}", CancellationToken.None);
    }
}