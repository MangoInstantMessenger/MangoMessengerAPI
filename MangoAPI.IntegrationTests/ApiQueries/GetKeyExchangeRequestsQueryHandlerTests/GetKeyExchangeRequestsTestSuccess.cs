using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetKeyExchangeRequestsQueryHandlerTests;

public class GetKeyExchangeRequestsTestSuccess : IntegrationTestBase
{
    private readonly Assert<GetKeyExchangeRequestsResponse> assert = new();

    [Fact]
    public async Task GetKeyExchangeRequestsTestSuccessAsync()
    {
        var sender =
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var requestedUser =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var publicKey = MangoFilesHelper.GetTestImage();
        _ = await MangoModule.RequestAsync(
            request: CommandHelper.CreateOpenSslCreateKeyExchangeCommand(
                receiverId: sender.Response.Tokens.UserId,
                senderId: requestedUser.Response.Tokens.UserId,
                senderPublicKey: publicKey),
            cancellationToken: CancellationToken.None);
        var query = new GetKeyExchangeRequestsQuery(requestedUser.Response.Tokens.UserId);

        var response = await MangoModule.RequestAsync(query, CancellationToken.None);

        assert.Pass(response);
    }
}
