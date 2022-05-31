using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.SendMessageCommandHandlerTests;

public class SendMessageShouldThrowLimit100 : ITestable<SendMessageCommand, SendMessageResponse>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<SendMessageResponse> _assert = new();

    [Fact]
    public async Task SendMessage_ShouldThrow_ExceedLimit100Per5Minutes()
    {
        Seed();
        const string expectedMessage = ResponseMessageCodes.MaximumMessageCountInLast5MinutesExceeded100;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var handler = CreateHandler();
        var command = new SendMessageCommand
        {
            ChatId = SeedDataConstants.ExtremeCodeMainId,
            UserId = SeedDataConstants.RazumovskyId,
            MessageText = "This is test message"
        };

        var result = await handler.Handle(command, CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    }

    public bool Seed()
    {
        _mangoDbFixture.Context.Users.Add(_user);
        _mangoDbFixture.Context.Chats.Add(_chat);
        _mangoDbFixture.Context.UserChats.Add(_userChatEntity);

        for (var i = 0; i < 100; i++)
        {
            _mangoDbFixture.Context.Messages.Add(new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.ExtremeCodeMainId,
                Content = $"Message # {i + 1}",
                CreatedAt = DateTime.UtcNow
            });
        }

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
        PhoneNumber = "48743615532",
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
        RoleId = (int) UserRole.User,
    };
}