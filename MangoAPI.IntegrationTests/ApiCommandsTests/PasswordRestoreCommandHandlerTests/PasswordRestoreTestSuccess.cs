using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.PasswordRestoreCommandHandlerTests;

public class PasswordRestoreTestSuccess : IntegrationTestBase
{
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task PasswordRestoreTest_Success()
    {
        await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var passwordRestoreRequest = await MangoModule.RequestAsync(
            request: CommandHelper.CreateRequestPasswordRestoreCommand("kolosovp95@gmail.com"),
            cancellationToken: CancellationToken.None);
        var command = new PasswordRestoreCommand(RequestId: passwordRestoreRequest.Response.RequestId,
            NewPassword: "Bm3-`dPRv-/w#3)cw^97", RepeatPassword: "Bm3-`dPRv-/w#3)cw^97");

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);
            
        _assert.Pass(result);
    }
}