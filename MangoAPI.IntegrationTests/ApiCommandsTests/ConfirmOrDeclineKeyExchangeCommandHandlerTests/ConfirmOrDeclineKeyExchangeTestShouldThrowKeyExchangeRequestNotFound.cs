using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.ConfirmOrDeclineKeyExchangeCommandHandlerTests;

public class ConfirmOrDeclineKeyExchangeTestShouldThrowKeyExchangeRequestNotFound : IntegrationTestBase
{
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task ConfirmOrDeclineKeyExchangeTest_Success()
    {
        const string expectedMessage = ResponseMessageCodes.KeyExchangeRequestNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new CngConfirmOrDeclineKeyExchangeCommand
        {
            UserId = Guid.NewGuid(),
            RequestId = Guid.NewGuid(),
            Confirmed = true,
            PublicKey = "Public Key"
        };

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);
            
        _assert.Fail(result, expectedMessage, expectedDetails);
    }
}