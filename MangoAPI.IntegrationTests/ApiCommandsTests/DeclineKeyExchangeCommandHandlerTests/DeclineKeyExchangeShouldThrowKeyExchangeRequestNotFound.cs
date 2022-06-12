using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.DeclineKeyExchangeCommandHandlerTests;

public class DeclineKeyExchangeShouldThrowKeyExchangeRequestNotFound : IntegrationTestBase
{
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task DeclineKeyExchangeShouldThrow_KeyExchangeRequestNotFound()
    {
        const string expectedMessage = ResponseMessageCodes.KeyExchangeRequestNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var requestedUser = 
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var command = new DeclineKeyExchangeCommand(
            RequestId: Guid.NewGuid(), 
            UserId: requestedUser.Response.UserId);

        var response = await MangoModule.RequestAsync(command, CancellationToken.None);
        
        _assert.Fail(response, expectedMessage, expectedDetails);
    }
}