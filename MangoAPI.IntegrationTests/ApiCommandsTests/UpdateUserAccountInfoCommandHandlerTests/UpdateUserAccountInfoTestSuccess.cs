using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.UpdateUserAccountInfoCommandHandlerTests;

public class UpdateUserAccountInfoTestSuccess : IntegrationTestBase
{
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task UpdateUserAccountInfoTest_Success()
    {
        var user = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var command = new UpdateUserAccountInfoCommand(UserId: user.Response.UserId, Username: "Petro_Kolosov",
            DisplayName: "Petro Kolosov", Website: "pkolosov.com", Bio: "Third year student of WSB at Poznan",
            Address: "Poznan, Poland", BirthdayDate: new DateTime(1994, 6, 12));

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        _assert.Pass(result);
    }
}