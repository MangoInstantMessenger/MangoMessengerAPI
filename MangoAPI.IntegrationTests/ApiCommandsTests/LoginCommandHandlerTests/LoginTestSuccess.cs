using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.IntegrationTests.Helpers;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.LoginCommandHandlerTests;

public class LoginTestSuccess : IntegrationTestBase
{
    private readonly Assert<TokensResponse> _assert = new();

    [Fact]
    public async Task LoginTest_Success()
    {
        var user = await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var userId = user.Response.UserId;
        var userEntity = await DbContextFixture.Users.FirstOrDefaultAsync(x => x.Id == userId);
        await MangoModule.RequestAsync(
            request: CommandHelper.CreateVerifyEmailCommand(userEntity.Email, userEntity.EmailCode),
            cancellationToken: CancellationToken.None);
        var command = new LoginCommand
        {
            Email = "kolosovp95@gmail.com",
            Password = "Bm3-`dPRv-/w#3)cw^97"
        };

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);
            
        _assert.Pass(result);
    }
}