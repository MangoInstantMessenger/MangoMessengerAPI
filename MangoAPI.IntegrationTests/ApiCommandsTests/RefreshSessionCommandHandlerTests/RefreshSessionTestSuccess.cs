using MangoAPI.BusinessLogic;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.RefreshSessionCommandHandlerTests;

public class RefreshSessionTestSuccess : IntegrationTestBase
{
    private readonly Assert<TokensResponse> assert = new();

    [Fact]
    public async Task RefreshSessionTestSuccessAsync()
    {
        var petroCommand = CommandHelper.RegisterPetroCommand();
        var petro = await MangoModule.RequestAsync(petroCommand, CancellationToken.None);
        var petroRefresh = petro.Response.Tokens.RefreshToken;

        var command = new RefreshSessionCommand(petroRefresh);
        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Pass(result);
    }
}