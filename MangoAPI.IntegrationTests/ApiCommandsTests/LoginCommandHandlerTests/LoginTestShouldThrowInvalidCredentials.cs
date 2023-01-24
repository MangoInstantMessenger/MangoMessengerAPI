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

        var result = await MangoModule.RequestAsync(
            request: CommandHelper.CreateLoginCommand("kolosovp95@gmail.com", "Bm3-`dPRv-/w#3)cw^97"),
            cancellationToken: CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
