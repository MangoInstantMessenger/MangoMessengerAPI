using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.RegisterCommandHandlerTests;

public class RegisterTestSuccess : ITestable<RegisterCommand, ResponseBase>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task RegisterTest_Success()
    {
        Seed();
        var handler = CreateHandler();

        var result = await handler.Handle(_command, CancellationToken.None);
            
        _assert.Pass(result);
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
        var passwordValidator = new PasswordValidatorService();
        var handler = new RegisterCommandHandler(userServiceMock, _mangoDbFixture.Context, emailSenderServiceMock,
            responseFactory, passwordValidator);
        return handler;
    }

    private readonly RegisterCommand _command = new()
    {
        Email = "kolosovp95@gmail.com",
        DisplayName = "Petro Kolosov",
        Password = "Bm3-`dPRv-/w#3)cw^97",
        TermsAccepted = true
    };
}