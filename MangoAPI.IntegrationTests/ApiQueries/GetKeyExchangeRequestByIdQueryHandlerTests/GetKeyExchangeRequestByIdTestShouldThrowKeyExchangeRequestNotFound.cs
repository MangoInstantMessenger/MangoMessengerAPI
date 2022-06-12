using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;
using MangoAPI.Domain.Constants;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetKeyExchangeRequestByIdQueryHandlerTests;

public class GetKeyExchangeRequestByIdTestShouldThrowKeyExchangeRequestNotFound : IntegrationTestBase
{
    private readonly Assert<GetKeyExchangeRequestByIdResponse> _assert = new();

    [Fact]
    public async Task OpenSslGetKeyExchangeRequestByIdTest_ShouldThrow_KeyExchangeRequestNotFound()
    {
        const string expectedMessage = ResponseMessageCodes.KeyExchangeRequestNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var query = new GetKeyExchangeRequestByIdQuery(Guid.NewGuid(), Guid.NewGuid());

        var response = await MangoModule.RequestAsync(query, CancellationToken.None);
        
        _assert.Fail(response, expectedMessage, expectedDetails);
    }
}