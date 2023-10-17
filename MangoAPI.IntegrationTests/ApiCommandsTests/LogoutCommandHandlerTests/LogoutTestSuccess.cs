using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.LogoutCommandHandlerTests;

public class LogoutTestSuccess : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task LogoutTestSuccessAsync()
    {
        var petroCommand = CommandHelper.RegisterPetroCommand();
        var petro = await RequestAsync(petroCommand, CancellationToken.None);

        var petroId = petro.Response.Tokens.UserId;
        var petroRefresh = petro.Response.Tokens.RefreshToken;

        var petroLogout = new LogoutCommand(petroId, petroRefresh);

        var result = await RequestAsync(petroLogout, CancellationToken.None);

        assert.Pass(result);
    }
}
