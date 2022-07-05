using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.ChangePasswordCommandHandlerTests;

public class ChangePasswordTestShouldThrowUserNotFound : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task ChangePasswordTestShouldThrow_UserNotFound()
    {
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new ChangePasswordCommand(UserId: Guid.NewGuid(), CurrentPassword: "Bm3-`dPRv-/w#3)cw^97",
            NewPassword: "Gm3-`xPRr-/q#6)re^94", RepeatNewPassword: "Gm3-`xPRr-/q#6)re^94");

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
