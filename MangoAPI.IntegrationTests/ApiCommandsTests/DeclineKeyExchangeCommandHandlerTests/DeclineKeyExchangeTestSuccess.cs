using MangoAPI.BusinessLogic;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.DeclineKeyExchangeCommandHandlerTests;

public class DeclineKeyExchangeTestSuccess : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task DeclineKeyExchangeTestSuccessAsync()
    {
        var sender =
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var receiver =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var keyExchange = await MangoModule.RequestAsync(
            CommandHelper.CreateOpenSslCreateKeyExchangeCommand(
                receiver.Response.Tokens.UserId,
                sender.Response.Tokens.UserId,
                MangoFilesHelper.GetTestImage()),
            CancellationToken.None);
        var command = new DeclineKeyExchangeCommand(
            keyExchange.Response.RequestId,
            receiver.Response.Tokens.UserId);

        var response = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Pass(response);
    }
}