using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.CngPublicKeys;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetPublicKeysQueryHandlerTests;

public class GetPublicKeysTestSuccess : IntegrationTestBase
{
    private readonly Assert<CngGetPublicKeysResponse> _assert = new();

    [Fact]
    public async Task GetPublicKeysTest_Success()
    {
        var sender =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var requestedUser =
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var keyExchangeRequest = await MangoModule.RequestAsync(
            request: CommandHelper.CreateCngKeyExchangeCommand(sender.Response.UserId,
                receiverId: requestedUser.Response.UserId),
            cancellationToken: CancellationToken.None);
        await MangoModule.RequestAsync(
            request: CommandHelper.CreateCngConfirmOrDeclineKeyExchangeCommand(
                userId: requestedUser.Response.UserId,
                requestId: keyExchangeRequest.Response.RequestId,
                confirmed: true,
                publicKey: "Public key"),
            cancellationToken: CancellationToken.None);
        var query = new CngGetPublicKeysQuery(UserId: sender.Response.UserId);

        var result = await MangoModule.RequestAsync(query, CancellationToken.None);

        _assert.Pass(result);
        result.Response.PublicKeys.Count.Should().Be(1);
        result.Response.PublicKeys[0].PartnerId.Should().Be(requestedUser.Response.UserId);
    }
}