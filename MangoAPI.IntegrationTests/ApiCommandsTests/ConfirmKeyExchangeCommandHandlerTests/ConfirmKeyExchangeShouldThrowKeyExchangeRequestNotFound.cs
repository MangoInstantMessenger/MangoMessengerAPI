using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.ConfirmKeyExchangeCommandHandlerTests;

public class ConfirmKeyExchangeShouldThrowKeyExchangeRequestNotFound : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task ConfirmKeyExchange_ShouldThrowKeyExchangeRequestNotFound()
    {
        const string expectedMessage = ResponseMessageCodes.KeyExchangeRequestNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var requestedUser =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var command = new ConfirmKeyExchangeCommand(
            RequestId: Guid.NewGuid(),
            UserId: requestedUser.Response.UserId,
            ReceiverPublicKey: MangoFilesHelper.GetTestImage());

        var response = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(response, expectedMessage, expectedDetails);
    }
}
