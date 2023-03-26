using MangoAPI.BusinessLogic;
using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetKeyExchangeRequestByIdQueryHandlerTests;

public class GetKeyExchangeRequestByIdTestShouldThrowKeyExchangeDoesNotBelongToUser : IntegrationTestBase
{
    private readonly Assert<GetKeyExchangeRequestByIdResponse> assert = new();

    [Fact]
    public async Task OpenSslGetKeyExchangeRequestByIdTestShouldThrowKeyExchangeDoesNotBelongToUserAsync()
    {
        const string expectedMessage = ResponseMessageCodes.KeyExchangeDoesNotBelongToUser;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var sender =
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var requestedUser =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var publicKey = MangoFilesHelper.GetTestImage();
        var keyExchange = await MangoModule.RequestAsync(
            CommandHelper.CreateOpenSslCreateKeyExchangeCommand(
                sender.Response.Tokens.UserId,
                requestedUser.Response.Tokens.UserId,
                publicKey),
            CancellationToken.None);
        var query = new GetKeyExchangeRequestByIdQuery(Guid.NewGuid(), keyExchange.Response.RequestId);

        var response = await MangoModule.RequestAsync(query, CancellationToken.None);

        assert.Fail(response, expectedMessage, expectedDetails);
    }
}