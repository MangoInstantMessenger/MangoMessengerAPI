using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetDhParametersQueryHandlerTests;

public class GetDhParametersTestShouldThrowDhParameterNotFound : IntegrationTestBase
{
    private readonly Assert<GetDhParametersResponse> assert = new();

    [Fact]
    public async Task DownloadPartnerPublicKeyTestShouldThrowDhParameterNotFoundAsync()
    {
        const string expectedMessage = ResponseMessageCodes.DhParameterNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        await RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var query = new GetDhParametersQuery();

        var response = await RequestAsync(query, CancellationToken.None);

        assert.Fail(response, expectedMessage, expectedDetails);
    }
}
