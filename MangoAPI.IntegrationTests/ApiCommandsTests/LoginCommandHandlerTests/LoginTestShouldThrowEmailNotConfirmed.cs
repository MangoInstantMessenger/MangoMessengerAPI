using System.Threading;
using System.Threading.Tasks;
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
        
        var result = await MangoModule.RequestAsync(
            request: CommandHelper.CreateLoginCommand("kolosovp95@gmail.com", "Bm3-`dPRv-/w#3)cw^97"),
            cancellationToken: CancellationToken.None);
        
        _assert.Fail(result, expectedMessage, expectedDetails);
    }
}