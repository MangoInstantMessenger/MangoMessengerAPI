using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.LoginCommandHandlerTests;

public class LoginTestShouldThrowEmailNotConfirmed : IntegrationTestBase
{
    private readonly Assert<TokensResponse> _assert = new();

    [Fact]
    public async Task LoginTestShouldThrow_EmailNotConfirmed()
    {
        const string expectedMessage = ResponseMessageCodes.EmailIsNotVerified;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var command = new LoginCommand
        {
            Email = "kolosovp95@gmail.com",
            Password = "Bm3-`dPRv-/w#3)cw^97"
        };

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    }
}