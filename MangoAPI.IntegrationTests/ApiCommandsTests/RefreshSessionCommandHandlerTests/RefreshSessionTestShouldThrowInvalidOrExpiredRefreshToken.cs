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
    private readonly Assert<TokensResponse> assert = new();

    [Fact]
    public async Task RefreshSessionTestShouldThrowInvalidOrExpiredRefreshTokenAsync()
    {
        const string expectedMessage = ResponseMessageCodes.InvalidOrExpiredRefreshToken;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new RefreshSessionCommand(RefreshToken: Guid.NewGuid());

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
