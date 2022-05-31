using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MediatR;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.RequestPasswordRestoreCommandHandlerTests;

public class RequestPasswordRestoreTestShouldThrowUserNotFound : ITestable<RequestPasswordRestoreCommand, ResponseBase>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task RequestPasswordRestoreTestShouldThrow_UserNotFound()
    {
        Seed();
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var handler = CreateHandler();
        var command = new RequestPasswordRestoreCommand
        {
            Email = "email"
        };

        var result = await handler.Handle(command, CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    }
        
    public bool Seed()
    {
        return true;
    }

    public IRequestHandler<RequestPasswordRestoreCommand, Result<ResponseBase>> CreateHandler()
    {
        var emailSenderService = MockedObjects.GetEmailSenderServiceMock();
        var responseFactory = new ResponseFactory<ResponseBase>();

        var handler =
            new RequestPasswordRestoreCommandHandler(_mangoDbFixture.Context, emailSenderService, responseFactory);

        return handler;
    }
}