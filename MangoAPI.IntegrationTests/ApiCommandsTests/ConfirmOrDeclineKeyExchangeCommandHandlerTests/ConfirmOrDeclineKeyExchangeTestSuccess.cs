using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.ConfirmOrDeclineKeyExchangeCommandHandlerTests;

public class ConfirmOrDeclineKeyExchangeTestSuccess : IntegrationTestBase
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task ConfirmOrDeclineKeyExchangeTest_Success()
    {
        var sender = 
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var requestedUser = 
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var keyExchangeRequest =
            await MangoModule.RequestAsync(
                CommandHelper.CreateCngKeyExchangeCommand(sender.Response.UserId, requestedUser.Response.UserId),
                CancellationToken.None);
        var command = new CngConfirmOrDeclineKeyExchangeCommand
        {
            UserId = requestedUser.Response.UserId,
            RequestId = keyExchangeRequest.Response.RequestId,
            Confirmed = true,
            PublicKey = "Public Key"
        };

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);
            
        _assert.Pass(result);
    }
}