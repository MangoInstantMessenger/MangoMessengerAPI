using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Messages;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiQueries.SearchChatMessageQueryHandlerTests;

public class SearchChatMessageTestSuccess : ITestable<SearchChatMessagesQuery, SearchChatMessagesResponse>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<SearchChatMessagesResponse> _assert = new();

    [Fact]
    public async Task SearchChatMessageTest_Success()
    {
        Seed();
        var handler = CreateHandler();
        var query = new SearchChatMessagesQuery()
        {
            UserId = _user.Id,
            ChatId = _chat.Id,
            MessageText = "Hello"
        };

        var result = await handler.Handle(query, CancellationToken.None);
            
        _assert.Pass(result);
        result.Response.Messages.Count.Should().Be(2);
    }

    public bool Seed()
    {
        _mangoDbFixture.Context.Users.Add(_user);
        _mangoDbFixture.Context.Chats.Add(_chat);
        _mangoDbFixture.Context.UserChats.Add(_userChat);
        _mangoDbFixture.Context.Messages.AddRange(_message1, _message2);

        _mangoDbFixture.Context.SaveChanges();

        _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;
        _mangoDbFixture.Context.Entry(_chat).State = EntityState.Detached;
        _mangoDbFixture.Context.Entry(_userChat).State = EntityState.Detached;
        _mangoDbFixture.Context.Entry(_message1).State = EntityState.Detached;
        _mangoDbFixture.Context.Entry(_message2).State = EntityState.Detached;

        return true;
            
    }

    public IRequestHandler<SearchChatMessagesQuery, Result<SearchChatMessagesResponse>> CreateHandler()
    {
        var responseFactory = new ResponseFactory<SearchChatMessagesResponse>();
        var handler = new SearchChatMessageQueryHandler(_mangoDbFixture.Context, responseFactory);
        return handler;
    }
        
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

    private readonly MessageEntity _message1 = new()
    {
        Id = Guid.NewGuid(),
        UserId = SeedDataConstants.RazumovskyId,
        ChatId = SeedDataConstants.ExtremeCodeDotnetId,
        Content = "Hello World 1",
        CreatedAt = new DateTime(2021, 8, 1, 11, 36, 27),
    };
        
    private readonly MessageEntity _message2 = new()
    {
        Id = Guid.NewGuid(),
        UserId = SeedDataConstants.RazumovskyId,
        ChatId = SeedDataConstants.ExtremeCodeDotnetId,
        Content = "Hello World 2",
        CreatedAt = new DateTime(2021, 8, 1, 11, 36, 35),
    };

    private readonly ChatEntity _chat = new()
    {
        Id = SeedDataConstants.ExtremeCodeDotnetId,
        Title = "Extreme Code .NET",
        CommunityType = (int) CommunityType.PublicChannel,
        Description = "Extreme Code .NET Public Group",
        CreatedAt = new DateTime(2020, 5, 12),
        MembersCount = 4,
        Image = "extremecode_dotnet.png",
        UpdatedAt = DateTime.UtcNow,
        LastMessageAuthor = "Amelit",
        LastMessageText = "Hello world!",
        LastMessageTime = "6:45 PM"
    };

    private readonly UserChatEntity _userChat = new()
    {
        UserId = SeedDataConstants.RazumovskyId,
        ChatId = SeedDataConstants.ExtremeCodeDotnetId,
        RoleId = (int) UserRole.Owner,
    };
}