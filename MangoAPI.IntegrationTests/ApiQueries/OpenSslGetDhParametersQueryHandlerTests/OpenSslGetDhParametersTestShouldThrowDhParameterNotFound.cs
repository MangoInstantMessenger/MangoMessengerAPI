using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.OpenSslGetDhParametersQueryHandlerTests;

public class OpenSslGetDhParametersTestShouldThrowDhParameterNotFound : IntegrationTestBase
{
    private readonly Assert<OpenSslGetDhParametersResponse> _assert = new();

    [Fact]
    public async Task OpenSslDownloadPartnerPublicKeyTest_Success()
    {
        const string expectedMessage = ResponseMessageCodes.DhParameterNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var query = new OpenSslGetDhParametersQuery();

        var response = await MangoModule.RequestAsync(query, CancellationToken.None);
        
        _assert.Fail(response, expectedMessage, expectedDetails);
    }
}