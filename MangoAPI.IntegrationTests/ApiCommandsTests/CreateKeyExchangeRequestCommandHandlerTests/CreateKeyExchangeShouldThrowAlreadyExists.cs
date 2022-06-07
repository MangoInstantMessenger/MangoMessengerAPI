using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.CreateKeyExchangeRequestCommandHandlerTests;

public class CreateKeyExchangeShouldThrowAlreadyExists : IntegrationTestBase
{
    private readonly Assert<CngCreateKeyExchangeResponse> _assert = new();

    [Fact]
    public async Task CreateKeyExchangeRequestCommandHandlerTest_ShouldThrow_AlreadyExists()
    {
        const string expectedMessage = ResponseMessageCodes.KeyExchangeRequestAlreadyExists;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var sender =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var requestedUser =
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        await MangoModule.RequestAsync(
            CommandHelper.CreateCngKeyExchangeCommand(sender.Response.UserId, requestedUser.Response.UserId),
            CancellationToken.None);
        
        var result = 
            await MangoModule.RequestAsync(
                CommandHelper.CreateCngKeyExchangeCommand(sender.Response.UserId, requestedUser.Response.UserId),
                CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    }
}