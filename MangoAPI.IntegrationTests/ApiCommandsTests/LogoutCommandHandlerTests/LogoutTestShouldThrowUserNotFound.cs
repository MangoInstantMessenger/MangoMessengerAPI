using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.LogoutCommandHandlerTests;

public class LogoutTestShouldThrowUserNotFound : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task LogoutTestShouldThrowUserNotFoundAsync()
    {
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var petroCommand = CommandHelper.RegisterPetroCommand();
        var khachaturCommand = CommandHelper.RegisterKhachaturCommand();

        var petro = await RequestAsync(petroCommand, CancellationToken.None);

        var khachatur = await RequestAsync(khachaturCommand, CancellationToken.None);

        var khachaturId = khachatur.Response.Tokens.UserId;
        var petroRefresh = petro.Response.Tokens.RefreshToken;

        var command = new LogoutCommand(khachaturId, petroRefresh);

        var result = await RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}