using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MediatR;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.PasswordRestoreCommandHandlerTests;

public class PasswordRestoreTestShouldThrowInvalidOrExpired: ITestable<PasswordRestoreCommand, ResponseBase>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task PasswordRestoreTestShouldThrow_InvalidOrExpired()
    {
        Seed();
        var handler = CreateHandler();
        const string expectedMessage = ResponseMessageCodes.InvalidOrExpiredRestorePasswordRequest;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new PasswordRestoreCommand
        {
            RequestId = Guid.NewGuid(),
            NewPassword = "Bm3-`dPRv-/w#3)cw^97"
        };

        var result = await handler.Handle(command, CancellationToken.None);
            
        _assert.Fail(result, expectedMessage, expectedDetails);
    }
        
    public bool Seed()
    {
        return true;
    }

    public IRequestHandler<PasswordRestoreCommand, Result<ResponseBase>> CreateHandler()
    {
        var userManagerMock = MockedObjects.GetUserServiceMock("Bm3-`dPRv-/w#3)cw^97");
        var responseFactory = new ResponseFactory<ResponseBase>();
        var handler = new PasswordRestoreCommandHandler(_mangoDbFixture.Context, userManagerMock, responseFactory);
        return handler;
    }
}