using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.IntegrationTests.Helpers;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.VerifyEmailCommandHandlerTests;

public class VerifyEmailTestSuccess : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task VerifyEmailTest_Success()
    {
        var user = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var userId = user.Response.UserId;
        var userEntity = await DbContextFixture.Users.FirstAsync(x => x.Id == userId);

        var result = await MangoModule.RequestAsync(
            request: CommandHelper.CreateVerifyEmailCommand(userEntity.Email, userEntity.EmailCode),
            cancellationToken: CancellationToken.None);

        assert.Pass(result);
    }
}
