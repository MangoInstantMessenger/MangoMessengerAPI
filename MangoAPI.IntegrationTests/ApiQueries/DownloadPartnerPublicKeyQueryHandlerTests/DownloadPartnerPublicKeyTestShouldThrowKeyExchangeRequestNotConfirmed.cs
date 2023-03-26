using MangoAPI.BusinessLogic;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.DownloadPartnerPublicKeyQueryHandlerTests;

public class DownloadPartnerPublicKeyTestShouldThrowKeyExchangeRequestNotConfirmed : IntegrationTestBase
{
    private readonly Assert<DownloadPartnerPublicKeyResponse> assert = new();

    [Fact]
    public async Task OpenSslDownloadPartnerPublicKeyTestShouldThrowKeyExchangeRequestNotConfirmedAsync()
    {
        const string expectedMessage = ResponseMessageCodes.KeyExchangeIsNotConfirmed;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var sender =
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var requestedUser =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var publicKey = MangoFilesHelper.GetTestImage();
        var keyExchange = await MangoModule.RequestAsync(
            CommandHelper.CreateOpenSslCreateKeyExchangeCommand(
                sender.Response.Tokens.UserId,
                requestedUser.Response.Tokens.UserId,
                publicKey),
            CancellationToken.None);
        var query = new DownloadPartnerPublicKeyQuery(requestedUser.Response.Tokens.UserId,
            keyExchange.Response.RequestId);

        var response =
            await MangoModule.RequestAsync(query, CancellationToken.None);

        assert.Fail(response, expectedMessage, expectedDetails);
    }
}