using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.UserChats;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.LeaveGroupCommandHandlerTests;

public class LeaveGroupTestShouldThrowChatNotFound : ITestable<LeaveGroupCommand, LeaveGroupResponse>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<LeaveGroupResponse> _assert = new();

    [Fact]
    public async Task LeaveGroupTestShouldThrow_UserNotFound()
    {
        Seed();
        using var mangoDbFixture = _mangoDbFixture;
        const string expectedMessage = ResponseMessageCodes.ChatNotFound;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var handler = CreateHandler();

        var result = await handler.Handle(_command, CancellationToken.None);
            
        _assert.Fail(result, expectedMessage, expectedDetails);
    }
        
    public bool Seed()
    {
        _mangoDbFixture.Context.Users.Add(_user);

        _mangoDbFixture.Context.SaveChanges();

        _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;
            
        return true;
    }

    public IRequestHandler<LeaveGroupCommand, Result<LeaveGroupResponse>> CreateHandler()
    {
        var responseFactory = new ResponseFactory<LeaveGroupResponse>();
        var handler = new LeaveGroupCommandHandler(_mangoDbFixture.Context, responseFactory);
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

    private readonly LeaveGroupCommand _command = new()
    {
        ChatId = SeedDataConstants.ExtremeCodeMainId,
        UserId = SeedDataConstants.RazumovskyId
    };
}