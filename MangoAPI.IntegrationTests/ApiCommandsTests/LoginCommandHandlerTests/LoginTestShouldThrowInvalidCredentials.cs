using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.LoginCommandHandlerTests;

public class LoginTestShouldThrowInvalidCredentials : IntegrationTestBase
{
    private readonly Assert<TokensResponse> assert = new();

    [Fact]
    public async Task LoginTestShouldThrowInvalidCredentialsAsync()
    {
        const string expectedMessage = ResponseMessageCodes.InvalidCredentials;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = CommandHelper.CreateLoginCommand("PetroKolosov337", "Bm3-`dPRv-/w#3)cw^97");

        var result = await RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}