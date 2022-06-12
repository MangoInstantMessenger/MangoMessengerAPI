using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.OpenSslGetKeyExchangeRequestByIdQueryHandlerTests;

public class OpenSslGetKeyExchangeRequestByIdTestShouldThrowKeyExchangeDoesNotBelongToUser : IntegrationTestBase
{
    private readonly Assert<OpenSslGetKeyExchangeRequestByIdResponse> _assert = new();

    [Fact]
    public async Task OpenSslGetKeyExchangeRequestByIdTest_ShouldThrowKeyExchangeDoesNotBelongToUser()
    {
        const string expectedMessage = ResponseMessageCodes.KeyExchangeDoesNotBelongToUser;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var sender = 
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var requestedUser = 
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var publicKey = MangoFilesHelper.GetTestImage();
        var keyExchange = await MangoModule.RequestAsync(
            request: CommandHelper.CreateOpenSslCreateKeyExchangeCommand(
                userId: sender.Response.UserId,
                receiverId: requestedUser.Response.UserId,
                senderPublicKey: publicKey), 
            cancellationToken: CancellationToken.None);
        var query = new OpenSslGetKeyExchangeRequestByIdQuery(Guid.NewGuid(), keyExchange.Response.RequestId);

        var response = await MangoModule.RequestAsync(query, CancellationToken.None);
        
        _assert.Fail(response, expectedMessage, expectedDetails);
    }
}