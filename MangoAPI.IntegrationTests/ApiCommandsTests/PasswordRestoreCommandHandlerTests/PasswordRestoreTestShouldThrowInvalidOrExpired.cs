using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.PasswordRestoreCommandHandlerTests;

public class PasswordRestoreTestShouldThrowInvalidOrExpired: IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task PasswordRestoreTestShouldThrow_InvalidOrExpired()
    {
        const string expectedMessage = ResponseMessageCodes.InvalidOrExpiredRestorePasswordRequest;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new PasswordRestoreCommand(RequestId: Guid.NewGuid(), NewPassword: "Bm3-`dPRv-/w#3)cw^97",
            RepeatPassword: "Bm3-`dPRv-/w#3)cw^97");

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
