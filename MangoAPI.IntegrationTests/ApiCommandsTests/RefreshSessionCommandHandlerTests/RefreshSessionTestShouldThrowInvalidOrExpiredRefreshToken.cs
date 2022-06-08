using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.RefreshSessionCommandHandlerTests;

public class RefreshSessionTestShouldThrowInvalidOrExpiredRefreshToken : IntegrationTestBase
{
    private readonly Assert<TokensResponse> _assert = new();

    [Fact]
    public async Task RefreshSessionTestShouldThrow_InvalidOrExpiredRefreshToken()
    {
        const string expectedMessage = ResponseMessageCodes.InvalidOrExpiredRefreshToken;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new RefreshSessionCommand(RefreshToken: Guid.NewGuid());

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    }
}