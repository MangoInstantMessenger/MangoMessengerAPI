using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MediatR;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.RegisterCommandHandlerTests;

public class RegisterTestShouldThrowWeakPassword : ITestable<RegisterCommand, ResponseBase>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task RegisterTestShouldThrow_WeakPassword()
    {
        Seed();
        const string expectedMessage = ResponseMessageCodes.WeakPassword;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var handler = CreateHandler();

        var result = await handler.Handle(_command, CancellationToken.None);
            
        _assert.Fail(result, expectedMessage, expectedDetails);
    }
        
    public bool Seed()
    {
        return true;
    }

    public IRequestHandler<RegisterCommand, Result<ResponseBase>> CreateHandler()
    {
        var emailSenderServiceMock = MockedObjects.GetEmailSenderServiceMock();
        var userServiceMock = MockedObjects.GetUserServiceMock(_command.Password);
        var responseFactory = new ResponseFactory<ResponseBase>();
        var handler = new RegisterCommandHandler(userServiceMock, _mangoDbFixture.Context, emailSenderServiceMock,
            responseFactory);
        return handler;
    }
        
    private readonly RegisterCommand _command = new()
    {
        Email = "kolosovp95@gmail.com",
        DisplayName = "Petro Kolosov",
        Password = "123456",
        TermsAccepted = true
    };
}