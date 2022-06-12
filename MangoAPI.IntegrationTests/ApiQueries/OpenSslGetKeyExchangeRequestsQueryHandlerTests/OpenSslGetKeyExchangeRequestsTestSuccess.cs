using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.OpenSslGetKeyExchangeRequestsQueryHandlerTests;

public class OpenSslGetKeyExchangeRequestsTestSuccess : IntegrationTestBase
{
    private readonly Assert<OpenSslGetKeyExchangeRequestsResponse> _assert = new();

    [Fact]
    public async Task OpenSslGetKeyExchangeRequestsTest_Success()
    {
        var sender = 
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var requestedUser = 
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var publicKey = MangoFilesHelper.GetTestImage();
        await MangoModule.RequestAsync(
            request: CommandHelper.CreateOpenSslCreateKeyExchangeCommand(
                userId: sender.Response.UserId,
                receiverId: requestedUser.Response.UserId,
                senderPublicKey: publicKey), 
            cancellationToken: CancellationToken.None);
        var query = new OpenSslGetKeyExchangeRequestsQuery(requestedUser.Response.UserId);

        var response = await MangoModule.RequestAsync(query, CancellationToken.None);
        
        _assert.Pass(response);
    }
}