using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.CreateKeyExchangeRequestCommandHandlerTests;

public class CreateKeyExchangeSuccess : IntegrationTestBase
{
    private readonly Assert<CngCreateKeyExchangeResponse> _assert = new();

    [Fact]
    public async Task CreateKeyExchangeRequestCommandHandlerTest_Success()
    {
        var sender =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var requestedUser =
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);

        var result = 
                await MangoModule.RequestAsync(
                    CommandHelper.CreateCngKeyExchangeCommand(
                        userId: sender.Response.UserId, 
                        requestedUserId: requestedUser.Response.UserId),
                        CancellationToken.None);

        _assert.Pass(result);
    }
}