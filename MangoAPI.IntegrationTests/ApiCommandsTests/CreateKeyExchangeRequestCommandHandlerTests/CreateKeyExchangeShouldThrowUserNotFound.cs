using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.CreateKeyExchangeRequestCommandHandlerTests;

public class CreateKeyExchangeShouldThrowUserNotFound : IntegrationTestBase
{
    private readonly Assert<CngCreateKeyExchangeResponse> _assert = new();

    [Fact]
    public async Task CreateKeyExchangeRequestCommandHandlerTest_ShouldThrow_UserNotFound()
    {
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var sender =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);

        var result = 
            await MangoModule.RequestAsync(
                CommandHelper.CreateCngKeyExchangeCommand(sender.Response.UserId, Guid.NewGuid()),
                CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    }
}