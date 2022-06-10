using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.OpenSslConfirmKeyExchangeCommandHandlerTests;

public class OpenSslConfirmKeyExchangeShouldThrowKeyExchangeRequestNotFound : IntegrationTestBase
{
    private readonly Assert<ResponseBase> _assert = new();
    
    [Fact]
    public async Task OpenSslConfirmKeyExchange_ShouldThrowKeyExchangeRequestNotFound()
    {
        const string expectedMessage = ResponseMessageCodes.KeyExchangeRequestNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var requestedUser = 
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var command = new OpenSslConfirmKeyExchangeCommand(
            RequestId: Guid.NewGuid(), 
            UserId: requestedUser.Response.UserId,
            ReceiverPublicKey: MangoFilesHelper.GetTestImage());

        var response = await MangoModule.RequestAsync(command, CancellationToken.None);
        
        _assert.Fail(response, expectedMessage, expectedDetails);
    }
}