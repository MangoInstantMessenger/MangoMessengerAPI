using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.CreateDiffieHellmanParameterCommandHandlerTests;

public class CreateDiffieHellmanParameterTestSuccess : IntegrationTestBase
{
    private readonly Assert<CreateDiffieHellmanParameterResponse> _assert = new();

    [Fact]
    public async Task CreateDiffieHellmanParameterTest_Success()
    {
        var user = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var command = new CreateDiffieHellmanParameterCommand(
            DiffieHellmanParameter: MangoFilesHelper.GetTestImage(),
            UserId: user.Response.UserId);

        var response = await MangoModule.RequestAsync(
            request: command, cancellationToken: CancellationToken.None);
        
        _assert.Pass(response);
    }
}