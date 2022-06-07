using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.LoginCommandHandlerTests;

public class LoginTestShouldThrowInvalidCredentials : IntegrationTestBase
{
    private readonly Assert<TokensResponse> _assert = new();
        
    [Fact]
    public async Task LoginTestShouldThrow_InvalidCredentials()
    {
        const string expectedMessage = ResponseMessageCodes.InvalidCredentials;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new LoginCommand
        {
            Email = "kolosovp95@gmail.com",
            Password = "Bm3-`dPRv-/w#3)cw^97"
        };

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);
            
        _assert.Fail(result, expectedMessage, expectedDetails);
    }
}