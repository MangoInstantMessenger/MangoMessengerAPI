using MangoAPI.BusinessLogic;
using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.UpdateUserAccountInfoCommandHandlerTests;

public class UpdateUserAccountInfoTestSuccess : IntegrationTestBase
{
    private readonly Assert<UpdateUserAccountInfoResponse> assert = new();

    [Fact]
    public async Task UpdateUserAccountInfoTestSuccessAsync()
    {
        var petroCommand = CommandHelper.RegisterPetroCommand();
        var petroResult = await MangoModule.RequestAsync(petroCommand, CancellationToken.None);
        var petroId = petroResult.Response.Tokens.UserId;

        var command = new UpdateUserAccountInfoCommand(
            petroId,
            "PetroKolosov",
            "Petro Kolosov",
            "pkolosov.com",
            "Third year student of WSB at Poznan",
            "Poznan, Poland",
            new DateTime(1994, 6, 12));

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Pass(result);
    }
}