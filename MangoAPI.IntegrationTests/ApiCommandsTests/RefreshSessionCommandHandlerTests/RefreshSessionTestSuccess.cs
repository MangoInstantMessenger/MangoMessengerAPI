using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.IntegrationTests.Helpers;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.RefreshSessionCommandHandlerTests;

public class RefreshSessionTestSuccess : IntegrationTestBase
{
    private readonly Assert<TokensResponse> _assert = new();

    [Fact]
    public async Task RefreshSessionTest_Success()
    {
        var user = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var userId = user.Response.UserId;
        var userEntity = await DbContextFixture.Users.FirstAsync(x => x.Id == userId);
        await MangoModule.RequestAsync(
            request: CommandHelper.CreateVerifyEmailCommand(userEntity.Email, userEntity.EmailCode),
            cancellationToken: CancellationToken.None);
        var login = await MangoModule.RequestAsync(
            request: CommandHelper.CreateLoginCommand("kolosovp95@gmail.com", "Bm3-`dPRv-/w#3)cw^97"),
            cancellationToken: CancellationToken.None);
        var command = new RefreshSessionCommand
        {
            RefreshToken = login.Response.Tokens.RefreshToken
        };

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        _assert.Pass(result);
    }
}