using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MediatR;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.RegisterCommandHandlerTests;

public class RegisterTestShouldThrowInvalidEmail : ITestable<RegisterCommand, RegisterResponse>
{
    private readonly MangoDbFixture _mangoDbFixture;
    private readonly Assert<RegisterResponse> _assert;
    private readonly RegisterCommand _command;

    public RegisterTestShouldThrowInvalidEmail()
    {
        var email = MockedObjects.GetMailgunSettings().NotificationEmail;

        _mangoDbFixture = new MangoDbFixture();
        _assert = new Assert<RegisterResponse>();
        _command = new RegisterCommand
        {
            Email = email,
            DisplayName = "Petro Kolosov",
            Password = "Bm3-`dPRv-/w#3)cw^97",
            TermsAccepted = true
        };
    }

    [Fact]
    public async Task RegisterTestShouldThrow_WeakPassword()
    {
        Seed();
        const string expectedMessage = ResponseMessageCodes.InvalidEmailAddress;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var handler = CreateHandler();

        var result = await handler.Handle(_command, CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    }

    public bool Seed()
    {
        return true;
    }

    public IRequestHandler<RegisterCommand, Result<RegisterResponse>> CreateHandler()
    {
        var emailSenderServiceMock = MockedObjects.GetEmailSenderServiceMock();
        var userServiceMock = MockedObjects.GetUserServiceMock(_command.Password);
        var responseFactory = new ResponseFactory<RegisterResponse>();
        var mailSettings = MockedObjects.GetMailgunSettings();

        var handler = new RegisterCommandHandler(
            userServiceMock,
            _mangoDbFixture.Context,
            emailSenderServiceMock,
            responseFactory,
            mailSettings);

        return handler;
    }
}