using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.DeclineKeyExchangeCommandHandlerTests;

public class DeclineKeyExchangeTestSuccess : IntegrationTestBase
{
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task DeclineKeyExchangeTest_Success()
    {
        var sender = 
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var receiver = 
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var keyExchange = await MangoModule.RequestAsync(
            request: CommandHelper.CreateOpenSslCreateKeyExchangeCommand(
                receiverId: receiver.Response.UserId,
                senderId: sender.Response.UserId,
                senderPublicKey: MangoFilesHelper.GetTestImage()), 
            cancellationToken: CancellationToken.None);
        var command = new DeclineKeyExchangeCommand(
            RequestId: keyExchange.Response.RequestId,
            UserId: receiver.Response.UserId);

        var response = await MangoModule.RequestAsync(command, CancellationToken.None);
        
        _assert.Pass(response);
    }
}