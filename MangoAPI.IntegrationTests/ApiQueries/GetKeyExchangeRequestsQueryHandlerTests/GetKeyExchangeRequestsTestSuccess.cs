using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetKeyExchangeRequestsQueryHandlerTests;

public class GetKeyExchangeRequestsTestSuccess : IntegrationTestBase
{
    private readonly Assert<CngGetKeyExchangeResponse> _assert = new ();

    [Fact]
    public async Task GetKeyExchangeRequestsTest_Success()
    {
        var sender = 
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var requestedUser = 
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var keyExchangeRequest =
            await MangoModule.RequestAsync(
                CommandHelper.CreateCngKeyExchangeCommand(sender.Response.UserId, requestedUser.Response.UserId),
                CancellationToken.None);
        var query = new CngGetKeyExchangeRequestsQuery
        {
            UserId = requestedUser.Response.UserId
        };

        var result = await MangoModule.RequestAsync(query, CancellationToken.None);
            
        _assert.Pass(result);
        result.Response.KeyExchangeRequests.Count.Should().Be(1);
        result.Response.KeyExchangeRequests[0].RequestId.Should().Be(keyExchangeRequest.Response.RequestId);
    }
}