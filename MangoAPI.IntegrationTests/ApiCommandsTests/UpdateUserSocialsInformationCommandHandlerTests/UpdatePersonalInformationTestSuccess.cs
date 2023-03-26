using MangoAPI.BusinessLogic;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.UpdateUserSocialsInformationCommandHandlerTests;

public class UpdatePersonalInformationTestSuccess : IntegrationTestBase
{
    private readonly Assert<UpdatePersonalInformationResponse> assert = new();

    [Fact]
    public async Task UpdatePersonalInformationTestSuccessAsync()
    {
        var user = await MangoModule.RequestAsync(
            CommandHelper.RegisterPetroCommand(),
            CancellationToken.None);
        var command = new UpdatePersonalInformationCommand(
            user.Response.Tokens.UserId,
            "petro.kolosov",
            "petro.kolosov",
            "petro.kolosov",
            "petro.kolosov");

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Pass(result);
    }
}