using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.RegisterCommandHandlerTests;

public class RegisterTestSuccess : IntegrationTestBase
{
    private readonly Assert<RegisterResponse> _assert = new();

    [Fact]
    public async Task RegisterTest_Success()
    {
        var command = CommandHelper.RegisterPetroCommand();

        var regResult = await MangoModule.RequestAsync(command, CancellationToken.None);

        _assert.Pass(regResult);
    }
}