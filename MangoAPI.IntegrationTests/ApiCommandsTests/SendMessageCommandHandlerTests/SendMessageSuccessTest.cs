using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.SendMessageCommandHandlerTests;

public class SendMessageSuccessTest : ITestable<SendMessageCommand, SendMessageResponse>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<SendMessageResponse> _assert = new();

    [Fact]
    public async Task SendMessage_Test_Success()
    {
        await using var context = _mangoDbFixture.Context;
        Seed();
        var handler = CreateHandler();

        var result = await handler.Handle(_command, CancellationToken.None);

        _assert.Pass(result);
        var chat = context.Chats.AsNoTracking().First(x => x.Id == _chat.Id);
        chat.LastMessageText.Should().Be(_command.MessageText);
        chat.LastMessageId.Should().Be(result.Response.MessageId);
        chat.LastMessageAuthor.Should().Be(_user.DisplayName);
    }

    public bool Seed()
    {
        _mangoDbFixture.Context.Users.Add(_user);
        _mangoDbFixture.Context.Chats.Add(_chat);
        _mangoDbFixture.Context.UserChats.Add(_userChatEntity);

        _mangoDbFixture.Context.SaveChanges();

        _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;
        _mangoDbFixture.Context.Entry(_chat).State = EntityState.Detached;
        _mangoDbFixture.Context.Entry(_userChatEntity).State = EntityState.Detached;

        return true;
    }

    public IRequestHandler<SendMessageCommand, Result<SendMessageResponse>> CreateHandler()
    {
        var hubContext = MockedObjects.GetHubContextMock();
        var responseFactory = new ResponseFactory<SendMessageResponse>();
        var blobSettings = MockedObjects.GetBlobServiceSettingsMock();
        var handler = new SendMessageCommandHandler(_mangoDbFixture.Context, hubContext, responseFactory, blobSettings);
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
        LastMessageTime = DateTime.Parse("2:32 PM")
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

    private readonly UserChatEntity _userChatEntity = new()
    {
        UserId = SeedDataConstants.RazumovskyId,
        ChatId = SeedDataConstants.ExtremeCodeMainId,
        RoleId = (int) UserRole.Admin,
    };

    private readonly SendMessageCommand _command = new()
    {
        ChatId = SeedDataConstants.ExtremeCodeMainId,
        UserId = SeedDataConstants.RazumovskyId,
        MessageText = "This is test message"
    };
}