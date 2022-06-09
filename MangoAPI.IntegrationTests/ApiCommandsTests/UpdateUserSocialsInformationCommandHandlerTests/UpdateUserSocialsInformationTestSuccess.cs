using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.UpdateUserSocialsInformationCommandHandlerTests;

public class UpdateUserSocialsInformationTestSuccess : IntegrationTestBase
{
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task UpdateUserSocialsInformationTest_Success()
    {
        var user = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var command = new UpdateUserSocialInformationCommand(UserId: user.Response.UserId, Instagram: "petro.kolosov",
            LinkedIn: "petro.kolosov", Facebook: "petro.kolosov", Twitter: "petro.kolosov");
        
        
        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        _assert.Pass(result);
    }
}