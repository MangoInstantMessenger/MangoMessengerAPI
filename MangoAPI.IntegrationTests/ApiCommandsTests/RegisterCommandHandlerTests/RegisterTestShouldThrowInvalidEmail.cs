using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.Domain.Constants;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.RegisterCommandHandlerTests;

public class RegisterTestShouldThrowInvalidEmail : IntegrationTestBase
{
    private readonly Assert<RegisterResponse> assert = new();

    [Fact]
    public async Task RegisterTestShouldThrow_InvalidEmail()
    {
        const string expectedMessage = ResponseMessageCodes.InvalidEmailAddress;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new RegisterCommand(
            Email: MockedObjects.GetMailgunSettings().NotificationEmail,
            DisplayName: "Test account",
            Password: "Bm3-`dPRv-/w#3)cw^97",
            TermsAccepted: true);

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
