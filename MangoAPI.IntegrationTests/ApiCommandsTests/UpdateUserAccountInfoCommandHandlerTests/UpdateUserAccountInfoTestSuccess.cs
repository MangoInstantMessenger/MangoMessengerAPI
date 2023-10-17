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
        var petroResult = await RequestAsync(petroCommand, CancellationToken.None);
        var petroId = petroResult.Response.Tokens.UserId;

        var command = new UpdateUserAccountInfoCommand(
            petroId,
            Username: "PetroKolosov",
            DisplayName: "Petro Kolosov",
            Website: "pkolosov.com",
            Bio: "Third year student of WSB at Poznan",
            Address: "Poznan, Poland",
            Birthday: new DateTime(1994, 6, 12));

        var result = await RequestAsync(command, CancellationToken.None);

        assert.Pass(result);
    }
}