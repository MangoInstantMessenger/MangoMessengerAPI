using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.VerifyEmailCommandHandlerTests;

public class VerifyEmailTestShouldThrowEmailAlreadyVerified : IntegrationTestBase
{
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task VerifyEmailTestShouldThrow_EmailAlreadyVerified()
    {
        const string expectedMessage = ResponseMessageCodes.EmailAlreadyVerified;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var user = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var userId = user.Response.UserId;
        var userEntity = await DbContextFixture.Users.FirstAsync(x => x.Id == userId);
        await MangoModule.RequestAsync(
            request: CommandHelper.CreateVerifyEmailCommand(userEntity.Email, userEntity.EmailCode),
            cancellationToken: CancellationToken.None);

        var result = await MangoModule.RequestAsync(
            request: CommandHelper.CreateVerifyEmailCommand(userEntity.Email, userEntity.EmailCode),
            cancellationToken: CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    }
}