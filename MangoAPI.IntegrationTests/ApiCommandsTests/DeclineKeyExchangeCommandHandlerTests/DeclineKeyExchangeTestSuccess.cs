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
        var sender = await RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var receiver = await RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var keyExchange = await RequestAsync(
            request: CommandHelper.CreateOpenSslCreateKeyExchangeCommand(
                receiverId: receiver.Response.Tokens.UserId,
                senderId: sender.Response.Tokens.UserId,
                senderPublicKey: MangoFilesHelper.GetTestImage()),
            cancellationToken: CancellationToken.None);
        var command = new DeclineKeyExchangeCommand(
            RequestId: keyExchange.Response.RequestId,
            UserId: receiver.Response.Tokens.UserId);

        var response = await RequestAsync(command, CancellationToken.None);

        assert.Pass(response);
    }
}
