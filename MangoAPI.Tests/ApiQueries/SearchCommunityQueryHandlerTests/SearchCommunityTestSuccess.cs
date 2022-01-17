using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Communities;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiQueries.SearchCommunityQueryHandlerTests;

public class SearchCommunityTestSuccess : ITestable<SearchCommunityQuery, SearchCommunityResponse>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<SearchCommunityResponse> _assert = new();

    [Fact]
    public async Task SearchCommunityTest_Success()
    {
        Seed();
        var query = new SearchCommunityQuery
        {
            UserId = SeedDataConstants.RazumovskyId,
            DisplayName = "Extreme"
        };
        var handler = CreateHandler();

        var result = await handler.Handle(query, CancellationToken.None);
            
        _assert.Pass(result);
        result.Response.Chats.Count.Should().Be(1);
        result.Response.Chats[0].ChatId.Should().Be(SeedDataConstants.ExtremeCodeMainId);
    }
        
    public bool Seed()
    {
        _mangoDbFixture.Context.Users.Add(_user);
        _mangoDbFixture.Context.Chats.Add(_chat);

        _mangoDbFixture.Context.SaveChanges();

        _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;
        _mangoDbFixture.Context.Entry(_chat).State = EntityState.Detached;

        return true;
    }

    public IRequestHandler<SearchCommunityQuery, Result<SearchCommunityResponse>> CreateHandler()
    {
        var responseFactory = new ResponseFactory<SearchCommunityResponse>();
        var handler = new SearchCommunityQueryHandler(_mangoDbFixture.Context, responseFactory);
        return handler;
    }
        
    private readonly ChatEntity _chat = new()
    {
        Id = SeedDataConstants.ExtremeCodeMainId,
        Title = "Extreme Code Main",
        CommunityType = (int) CommunityType.PublicChannel,
        Description = "Extreme Code Main Public Group",
        CreatedAt = new DateTime(2020, 2, 4),
        MembersCount = 4,
        Image = "extreme_code_main.jpg",
        UpdatedAt = DateTime.UtcNow,
        LastMessageAuthor = "Amelit",
        LastMessageText = "TypeScript The Best",
        LastMessageTime = "2:32 PM"
    };

    private readonly UserEntity _user = new()
    {
        DisplayName = "razumovsky r",
        Bio = "11011 y.o Dotnet Developer from $\"{cityName}\"",
        Id = SeedDataConstants.RazumovskyId,
        UserName = "razumovsky_r",
        Email = "kolosovp95@gmail.com",
        NormalizedEmail = "KOLOSOVP94@GMAIL.COM",
        EmailConfirmed = true,
        PhoneNumberConfirmed = true,
        Image = "razumovsky_picture.jpg"
    };
}