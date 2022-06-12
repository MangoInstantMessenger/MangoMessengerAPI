using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.OpenSslCreateDiffieHellmanParameterCommandHandlerTests;

public class OpenSslCreateDiffieHellmanParameterTestSuccess : IntegrationTestBase
{
    private readonly Assert<OpenSslCreateDiffieHellmanParameterResponse> _assert = new();

    [Fact]
    public async Task OpenSslCreateDiffieHellmanParameterTest_Success()
    {
        var user = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var command = new OpenSslCreateDiffieHellmanParameterCommand(
            DiffieHellmanParameter: MangoFilesHelper.GetTestImage(),
            UserId: user.Response.UserId);

        var response = await MangoModule.RequestAsync(
            request: command, cancellationToken: CancellationToken.None);
        
        _assert.Pass(response);
    }
}