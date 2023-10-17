using FluentAssertions;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.DownloadPartnerPublicKeyQueryHandlerTests;

public class DownloadPartnerPublicKeyTestSuccess : IntegrationTestBase
{
    private readonly Assert<DownloadPartnerPublicKeyResponse> assert = new();

    [Fact]
    public async Task OpenSslDownloadPartnerPublicKeyTestSuccessAsync()
    {
        var sender = await RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var receiver = await RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var publicKey = MangoFilesHelper.GetTestImage();
        var keyExchange = await RequestAsync(
            request: CommandHelper.CreateOpenSslCreateKeyExchangeCommand(
                receiverId: receiver.Response.Tokens.UserId,
                senderId: sender.Response.Tokens.UserId,
                senderPublicKey: publicKey),
            cancellationToken: CancellationToken.None);
        await RequestAsync(
            request: CommandHelper.CreateOpenSslConfirmKeyExchangeCommand(
                requestId: keyExchange.Response.RequestId,
                userId: receiver.Response.Tokens.UserId,
                receiverPublicKey: publicKey),
            cancellationToken: CancellationToken.None);
        var query = new DownloadPartnerPublicKeyQuery(receiver.Response.Tokens.UserId, keyExchange.Response.RequestId);

        var response =
            await RequestAsync(query, CancellationToken.None);

        assert.Pass(response);
        await using var target = new MemoryStream();
        await publicKey.CopyToAsync(target, CancellationToken.None);
        var publicKeyBytes = target.ToArray();
        response.Response.PublicKey.Should().BeEquivalentTo(publicKeyBytes);
    }
}
