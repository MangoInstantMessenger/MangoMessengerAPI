using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.LogoutCommandHandlerTests;

public class LogoutTestShouldThrowInvalidOrExpiredRefreshToken : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task LogoutTestShouldThrow_InvalidOrExpiredRefreshToken()
    {
        const string expectedMessage = ResponseMessageCodes.InvalidOrExpiredRefreshToken;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new LogoutCommand(RefreshToken: Guid.NewGuid(), UserId: Guid.NewGuid());

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
