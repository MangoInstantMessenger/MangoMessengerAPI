using MangoAPI.BusinessLogic;
using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.DownloadPartnerPublicKeyQueryHandlerTests;

public class DownloadPartnerPublicKeyTestShouldThrowKeyExchangeRequestNotFound : IntegrationTestBase
{
    private readonly Assert<DownloadPartnerPublicKeyResponse> assert = new();

    [Fact]
    public async Task OpenSslDownloadPartnerPublicKeyTestShouldThrowKeyExchangeRequestNotFoundAsync()
    {
        const string expectedMessage = ResponseMessageCodes.KeyExchangeRequestNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var requestedUser =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var query = new DownloadPartnerPublicKeyQuery(requestedUser.Response.Tokens.UserId, Guid.NewGuid());

        var response =
            await MangoModule.RequestAsync(query, CancellationToken.None);

        assert.Fail(response, expectedMessage, expectedDetails);
    }
}