using System.IO;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic;
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
        var sender =
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var receiver =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var publicKey = MangoFilesHelper.GetTestImage();
        var keyExchange = await MangoModule.RequestAsync(
            CommandHelper.CreateOpenSslCreateKeyExchangeCommand(
                receiver.Response.Tokens.UserId,
                sender.Response.Tokens.UserId,
                publicKey),
            CancellationToken.None);
        await MangoModule.RequestAsync(
            CommandHelper.CreateOpenSslConfirmKeyExchangeCommand(
                keyExchange.Response.RequestId,
                receiver.Response.Tokens.UserId,
                publicKey),
            CancellationToken.None);
        var query = new DownloadPartnerPublicKeyQuery(receiver.Response.Tokens.UserId, keyExchange.Response.RequestId);

        var response =
            await MangoModule.RequestAsync(query, CancellationToken.None);

        assert.Pass(response);
        await using var target = new MemoryStream();
        await publicKey.CopyToAsync(target, CancellationToken.None);
        var publicKeyBytes = target.ToArray();
        response.Response.PublicKey.Should().BeEquivalentTo(publicKeyBytes);
    }
}