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

namespace MangoAPI.IntegrationTests.ApiCommandsTests.EditMessageCommandHandlerTests;

public class EditMessageShouldThrowMessageNotFound : ITestable<EditMessageCommand, ResponseBase>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task EditMessageTestShouldThrow_MessageNotFound()
    {
        Seed();
        const string expectedMessage = ResponseMessageCodes.MessageNotFound;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var handler = CreateHandler();

        var result = await handler.Handle(_command, CancellationToken.None);
            
        _assert.Fail(result, expectedMessage, expectedDetails);
    }
        
    public bool Seed()
    {
        _mangoDbFixture.Context.Users.Add(_user);
        _mangoDbFixture.Context.Chats.Add(_chat);
        _mangoDbFixture.Context.UserChats.Add(_userChat);
            
        _mangoDbFixture.Context.SaveChanges();

        _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;
        _mangoDbFixture.Context.Entry(_chat).State = EntityState.Detached;
        _mangoDbFixture.Context.Entry(_userChat).State = EntityState.Detached;
            
        return true;
    }

    public IRequestHandler<EditMessageCommand, Result<ResponseBase>> CreateHandler()
    {
        var hubContext = MockedObjects.GetHubContextMock();
        var responseFactory = new ResponseFactory<ResponseBase>();
        var handler = new EditMessageCommandHandler(_mangoDbFixture.Context, hubContext, responseFactory);
            
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
        LastMessageTime = DateTime.Parse("6:45 PM")
    };

    private readonly UserChatEntity _userChat = new()
    {
        UserId = SeedDataConstants.RazumovskyId,
        ChatId = SeedDataConstants.ExtremeCodeDotnetId,
        RoleId = (int) UserRole.Owner,
    };

    private readonly EditMessageCommand _command = new()
    {
        UserId = SeedDataConstants.RazumovskyId,
        ChatId = SeedDataConstants.ExtremeCodeDotnetId,
        MessageId = Guid.NewGuid(),
        ModifiedText = "Hello world"
    };
}