using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.LogoutCommandHandlerTests;

public class LogoutTestShouldThrowUserNotFound : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task LogoutTestShouldThrowUserNotFoundAsync()
    {
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var user1 = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterKhachaturCommand(),
            cancellationToken: CancellationToken.None);
        var userId1 = user1.Response.Tokens.UserId;
        var session = await MangoModule.RequestAsync(
            request: CommandHelper.CreateLoginCommand("kolosovp95@gmail.com", "Bm3-`dPRv-/w#3)cw^97"),
            cancellationToken: CancellationToken.None);
        var command = new LogoutCommand(RefreshToken: session.Response.Tokens.RefreshToken, UserId: userId1);

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
