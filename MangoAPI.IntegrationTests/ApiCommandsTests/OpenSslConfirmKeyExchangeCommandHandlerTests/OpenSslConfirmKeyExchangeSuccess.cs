using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.OpenSslConfirmKeyExchangeCommandHandlerTests;

public class OpenSslConfirmKeyExchangeSuccess : IntegrationTestBase
{
    private readonly Assert<ResponseBase> _assert = new();
    
    [Fact]
    public async Task OpenSslConfirmKeyExchange_Success()
    {
        var sender = 
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var requestedUser = 
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var keyExchange = await MangoModule.RequestAsync(
            request: CommandHelper.CreateOpenSslCreateKeyExchangeCommand(
                userId: sender.Response.UserId,
                receiverId: requestedUser.Response.UserId,
                senderPublicKey: MangoFilesHelper.GetTestImage()), 
            cancellationToken: CancellationToken.None);
        var command = new OpenSslConfirmKeyExchangeCommand(
            RequestId: keyExchange.Response.RequestId,
            UserId: requestedUser.Response.UserId,
            ReceiverPublicKey: MangoFilesHelper.GetTestImage());

        var response = await MangoModule.RequestAsync(command, CancellationToken.None);
        
        _assert.Pass(response);
    }
}