using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.UserChats;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.LeaveGroupCommandHandlerTests;

public class LeaveGroupTestSuccess : ITestable<LeaveGroupCommand, LeaveGroupResponse>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<LeaveGroupResponse> _assert = new();

    [Fact]
    public async Task LeaveGroupTest_Success()
    {
        Seed();
        using var mangoDbFixture = _mangoDbFixture;
        var handler = CreateHandler();

        var result = await handler.Handle(_command, CancellationToken.None);
        var chat = await _mangoDbFixture.Context.Chats.FirstAsync(x => x.Id == result.Response.ChatId);

        _assert.Pass(result);
        chat.MembersCount.Should().Be(1);
    }
        
    public bool Seed()
    {
        _mangoDbFixture.Context.Users.Add(_user1);
        _mangoDbFixture.Context.UserChats.Add(_userChatEntity1);
        _mangoDbFixture.Context.Chats.Add(_chat);

        _mangoDbFixture.Context.SaveChanges();

        _mangoDbFixture.Context.Entry(_user1).State = EntityState.Detached;
        _mangoDbFixture.Context.Entry(_userChatEntity1).State = EntityState.Detached;
        _mangoDbFixture.Context.Entry(_chat).State = EntityState.Detached;

        return true;
    }

    public IRequestHandler<LeaveGroupCommand, Result<LeaveGroupResponse>> CreateHandler()
    {
        var responseFactory = new ResponseFactory<LeaveGroupResponse>();
        var handler = new LeaveGroupCommandHandler(_mangoDbFixture.Context, responseFactory);
        return handler;
    }

        

    private readonly UserEntity _user1 = new()
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

    private readonly UserChatEntity _userChatEntity1 = new()
    {
        UserId = SeedDataConstants.RazumovskyId,
        ChatId = SeedDataConstants.ExtremeCodeMainId,
        RoleId = (int) UserRole.Admin,
    };
        
    private readonly ChatEntity _chat = new()
    {
        Id = SeedDataConstants.ExtremeCodeMainId,
        Title = "Extreme Code Main",
        CommunityType = (int) CommunityType.PublicChannel,
        Description = "Extreme Code Main Public Group",
        CreatedAt = new DateTime(2020, 2, 4),
        MembersCount = 2,
        Image = "extreme_code_main.jpg",
        UpdatedAt = DateTime.UtcNow,
        LastMessageAuthor = "Amelit",
        LastMessageText = "TypeScript The Best",
        LastMessageTime = DateTime.Parse("2:32 PM")
    };

    private readonly LeaveGroupCommand _command = new()
    {
        ChatId = SeedDataConstants.ExtremeCodeMainId,
        UserId = SeedDataConstants.RazumovskyId
    };
}