using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.OpenSslCreateKeyExchangeCommandHandlerTests;

public class OpenSslCreateKeyExchangeTestShouldThrowKeyExchangeRequestAlreadyExists : IntegrationTestBase
{
    private readonly Assert<CreateKeyExchangeResponse> _assert = new();
    
    [Fact]
    public async Task OpenSslCreateKeyExchangeTest_ShouldThrowKeyExchangeRequestAlreadyExists()
    {
        const string expectedMessage = ResponseMessageCodes.KeyExchangeRequestAlreadyExists;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var sender = 
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var requestedUser = 
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var command = CommandHelper.CreateOpenSslCreateKeyExchangeCommand(
            userId: sender.Response.UserId,
            receiverId: requestedUser.Response.UserId,
            senderPublicKey: MangoFilesHelper.GetTestImage());
        await MangoModule.RequestAsync(command, CancellationToken.None);
        
        var response = await MangoModule.RequestAsync(command, CancellationToken.None);
        
        _assert.Fail(response, expectedMessage, expectedDetails);
    }
}