using MangoAPI.BusinessLogic;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.CreateKeyExchangeCommandHandlerTests;

public class CreateKeyExchangeTestSuccess : IntegrationTestBase
{
    private readonly Assert<CreateKeyExchangeResponse> assert = new();

    [Fact]
    public async Task OpenSslCreateKeyExchangeTestSuccessAsync()
    {
        var sender =
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var requestedUser =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var command = CommandHelper.CreateOpenSslCreateKeyExchangeCommand(
            sender.Response.Tokens.UserId,
            requestedUser.Response.Tokens.UserId,
            MangoFilesHelper.GetTestImage());

        var response = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Pass(response);
    }
}