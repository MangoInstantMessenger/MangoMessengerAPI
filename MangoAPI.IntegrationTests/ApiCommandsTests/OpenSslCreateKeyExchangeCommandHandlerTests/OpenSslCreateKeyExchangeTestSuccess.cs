using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.OpenSslCreateKeyExchangeCommandHandlerTests;

public class OpenSslCreateKeyExchangeTestSuccess : IntegrationTestBase
{
    private readonly Assert<OpenSslCreateKeyExchangeResponse> _assert = new();
    
    [Fact]
    public async Task OpenSslCreateKeyExchangeTest_Success()
    {
        var sender = 
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var requestedUser = 
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var command = CommandHelper.CreateOpenSslCreateKeyExchangeCommand(
            userId: sender.Response.UserId,
            receiverId: requestedUser.Response.UserId,
            senderPublicKey: MangoFilesHelper.GetTestImage());

        var response = await MangoModule.RequestAsync(command, CancellationToken.None);
        
        _assert.Pass(response);
    }
}