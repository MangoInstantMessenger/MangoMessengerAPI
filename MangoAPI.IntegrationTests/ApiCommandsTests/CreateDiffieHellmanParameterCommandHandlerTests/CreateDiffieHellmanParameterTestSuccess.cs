using MangoAPI.BusinessLogic;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.CreateDiffieHellmanParameterCommandHandlerTests;

public class CreateDiffieHellmanParameterTestSuccess : IntegrationTestBase
{
    private readonly Assert<CreateDiffieHellmanParameterResponse> assert = new();

    [Fact]
    public async Task CreateDiffieHellmanParameterTestSuccessAsync()
    {
        var user = await MangoModule.RequestAsync(
            CommandHelper.RegisterPetroCommand(),
            CancellationToken.None);
        var command = new CreateDiffieHellmanParameterCommand(
            MangoFilesHelper.GetTestImage(),
            user.Response.Tokens.UserId);

        var response = await MangoModule.RequestAsync(
            command, CancellationToken.None);

        assert.Pass(response);
    }
}