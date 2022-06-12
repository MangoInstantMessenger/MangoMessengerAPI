using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.OpenSslGetKeyExchangeRequestByIdQueryHandlerTests;

public class OpenSslGetKeyExchangeRequestByIdTestShouldThrowKeyExchangeRequestNotFound : IntegrationTestBase
{
    private readonly Assert<OpenSslGetKeyExchangeRequestByIdResponse> _assert = new();

    [Fact]
    public async Task OpenSslGetKeyExchangeRequestByIdTest_Success()
    {
        const string expectedMessage = ResponseMessageCodes.KeyExchangeRequestNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var query = new OpenSslGetKeyExchangeRequestByIdQuery(Guid.NewGuid(), Guid.NewGuid());

        var response = await MangoModule.RequestAsync(query, CancellationToken.None);
        
        _assert.Fail(response, expectedMessage, expectedDetails);
    }
}