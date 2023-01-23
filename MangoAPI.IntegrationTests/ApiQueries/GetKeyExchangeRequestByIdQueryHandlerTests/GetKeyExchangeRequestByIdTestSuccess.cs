using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetKeyExchangeRequestByIdQueryHandlerTests;

public class GetKeyExchangeRequestByIdTestSuccess : IntegrationTestBase
{
    private readonly Assert<GetKeyExchangeRequestByIdResponse> assert = new();

    [Fact]
    public async Task GetKeyExchangeRequestByIdTestSuccessAsync()
    {
        var sender =
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var requestedUser =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var publicKey = MangoFilesHelper.GetTestImage();
        var keyExchange = await MangoModule.RequestAsync(
            request: CommandHelper.CreateOpenSslCreateKeyExchangeCommand(
                receiverId: sender.Response.Tokens.UserId,
                senderId: requestedUser.Response.Tokens.UserId,
                senderPublicKey: publicKey),
            cancellationToken: CancellationToken.None);
        var query = new GetKeyExchangeRequestByIdQuery(sender.Response.Tokens.UserId, keyExchange.Response.RequestId);

        var response = await MangoModule.RequestAsync(query, CancellationToken.None);

        assert.Pass(response);
    }
}
