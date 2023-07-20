using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.DownloadPartnerPublicKeyQueryHandlerTests;

public class DownloadPartnerPublicKeyTestShouldThrowKeyExchangeDoesNotBelongToUser : IntegrationTestBase
{
    private readonly Assert<DownloadPartnerPublicKeyResponse> assert = new();

    [Fact]
    public async Task DownloadPartnerPublicKeyTestShouldThrowKeyExchangeDoesNotBelongToUserAsync()
    {
        const string expectedMessage = ResponseMessageCodes.KeyExchangeIsNotConfirmed;

        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var khachaturCommand = CommandHelper.RegisterKhachaturCommand();
        var senderResult = await RequestAsync(khachaturCommand, CancellationToken.None);

        var petroCommand = CommandHelper.RegisterPetroCommand();
        var receiverResult = await RequestAsync(petroCommand, CancellationToken.None);
        var publicKey = MangoFilesHelper.GetTestImage();

        var senderId = senderResult.Response.Tokens.UserId;
        var receiverId = receiverResult.Response.Tokens.UserId;

        var sslCommand = CommandHelper.CreateOpenSslCreateKeyExchangeCommand(receiverId, senderId, publicKey);
        var keyExchangeResult = await RequestAsync(sslCommand, CancellationToken.None);

        var query = new DownloadPartnerPublicKeyQuery(receiverId, keyExchangeResult.Response.RequestId);
        var downloadResult = await RequestAsync(query, CancellationToken.None);

        assert.Fail(downloadResult, expectedMessage, expectedDetails);
    }
}
