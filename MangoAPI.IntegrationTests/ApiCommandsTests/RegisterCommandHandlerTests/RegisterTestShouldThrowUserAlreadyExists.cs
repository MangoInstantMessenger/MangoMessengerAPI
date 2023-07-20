using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.RegisterCommandHandlerTests;

public class RegisterTestShouldThrowUserAlreadyExists : IntegrationTestBase
{
    private readonly Assert<TokensResponse> assert = new();

    [Fact]
    public async Task RegisterTestShouldThrowUserAlreadyExistsAsync()
    {
        const string expectedMessage = ResponseMessageCodes.UserAlreadyExists;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = CommandHelper.RegisterPetroCommand();
        await RequestAsync(command, CancellationToken.None);

        var registrationsResult = await RequestAsync(command, CancellationToken.None);

        assert.Fail(registrationsResult, expectedMessage, expectedDetails);
    }
}
