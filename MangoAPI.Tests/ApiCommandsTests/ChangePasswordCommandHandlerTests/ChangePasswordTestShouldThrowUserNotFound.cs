using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.ChangePasswordCommandHandlerTests;

public class ChangePasswordTestShouldThrowUserNotFound: ITestable<ChangePasswordCommand, ResponseBase>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<ResponseBase> _assert = new();
    private readonly PasswordHashService _passwordHasher = new();

    [Fact]
    public async Task ChangePasswordTestShouldThrow_UserNotFound()
    {
        Seed();
        var handler = CreateHandler();
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new ChangePasswordCommand
        {
            UserId = Guid.NewGuid(),
            CurrentPassword = "Bm3-`dPRv-/w#3)cw^97",
            NewPassword = "Gm3-`xPRr-/q#6)re^94",
            RepeatNewPassword = "Gm3-`xPRr-/q#6)re^94"
        };

        var result = await handler.Handle(command, CancellationToken.None);
            
        _assert.Fail(result, expectedMessage, expectedDetails);
    }
        
    public bool Seed()
    {
        return true;
    }

    public IRequestHandler<ChangePasswordCommand, Result<ResponseBase>> CreateHandler()
    {
        var userManagerMock = MockedObjects.GetUserServiceMock("Bm3-`dPRv-/w#3)cw^97");
        var responseFactory = new ResponseFactory<ResponseBase>();
        var handler = new ChangePasswordCommandHandler(_mangoDbFixture.Context, userManagerMock, responseFactory);
        return handler;
    }
}