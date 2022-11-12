using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.ConfirmKeyExchangeCommandHandlerTests;

public class ConfirmKeyExchangeSuccess : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task ConfirmKeyExchange_Success()
    {
        var sender =
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var receiver =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var keyExchange = await MangoModule.RequestAsync(
            request: CommandHelper.CreateOpenSslCreateKeyExchangeCommand(
                receiver.Response.Tokens.UserId,
                sender.Response.Tokens.UserId,
                MangoFilesHelper.GetTestImage()),
            cancellationToken: CancellationToken.None);
        var command = new ConfirmKeyExchangeCommand(
            RequestId: keyExchange.Response.RequestId,
            UserId: receiver.Response.Tokens.UserId,
            ReceiverPublicKey: MangoFilesHelper.GetTestImage());

        var response = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Pass(response);
    }
}
