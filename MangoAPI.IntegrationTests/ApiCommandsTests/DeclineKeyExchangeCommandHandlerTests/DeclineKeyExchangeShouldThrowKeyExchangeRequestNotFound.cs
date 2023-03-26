using MangoAPI.BusinessLogic;
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
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task DeclineKeyExchangeShouldThrowKeyExchangeRequestNotFoundAsync()
    {
        const string expectedMessage = ResponseMessageCodes.KeyExchangeRequestNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var requestedUser =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var command = new DeclineKeyExchangeCommand(
            Guid.NewGuid(),
            requestedUser.Response.Tokens.UserId);

        var response = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(response, expectedMessage, expectedDetails);
    }
}