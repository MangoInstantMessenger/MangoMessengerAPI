using System.IO;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.DownloadPartnerPublicKeyQueryHandlerTests;

public class DownloadPartnerPublicKeyTestSuccess : IntegrationTestBase
{
    private readonly Assert<DownloadPartnerPublicKeyResponse> _assert = new();

    [Fact]
    public async Task OpenSslDownloadPartnerPublicKeyTest_Success()
    {
        var sender = 
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var receiver = 
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var publicKey = MangoFilesHelper.GetTestImage();
        var keyExchange = await MangoModule.RequestAsync(
            request: CommandHelper.CreateOpenSslCreateKeyExchangeCommand(
                receiverId: receiver.Response.UserId,
                senderId: sender.Response.UserId,
                senderPublicKey: publicKey), 
            cancellationToken: CancellationToken.None);
        await MangoModule.RequestAsync(
            request: CommandHelper.CreateOpenSslConfirmKeyExchangeCommand(
                requestId: keyExchange.Response.RequestId,
                userId: receiver.Response.UserId,
                receiverPublicKey: publicKey),
            cancellationToken: CancellationToken.None);
        var query = new DownloadPartnerPublicKeyQuery(receiver.Response.UserId, keyExchange.Response.RequestId);

        var response = 
            await MangoModule.RequestAsync(query, CancellationToken.None);
        
        _assert.Pass(response);
        await using var target = new MemoryStream();
        await publicKey.CopyToAsync(target, CancellationToken.None);
        var publicKeyBytes = target.ToArray();
        response.Response.PublicKey.Should().BeEquivalentTo(publicKeyBytes);
    }
}