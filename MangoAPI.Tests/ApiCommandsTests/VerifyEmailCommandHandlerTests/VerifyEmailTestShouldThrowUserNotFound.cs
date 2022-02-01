using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MediatR;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.VerifyEmailCommandHandlerTests;

public class VerifyEmailTestShouldThrowUserNotFound : ITestable<VerifyEmailCommand, ResponseBase>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task VerifyEmailTestShouldThrow_UserNotFound()
    {
        Seed();
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var handler = CreateHandler();
        var command = new VerifyEmailCommand
        {
            Email = "test@gmail.com",
            EmailCode = Guid.NewGuid()
        };

        var result = await handler.Handle(command, CancellationToken.None);
            
        _assert.Fail(result, expectedMessage, expectedDetails);
    }

    public bool Seed()
    {
        return true;
    }

    public IRequestHandler<VerifyEmailCommand, Result<ResponseBase>> CreateHandler()
    {
        var context = _mangoDbFixture.Context;
        var responseFactory = new ResponseFactory<ResponseBase>();
        var handler = new VerifyEmailCommandHandler(context, responseFactory);
        return handler;
    }
}