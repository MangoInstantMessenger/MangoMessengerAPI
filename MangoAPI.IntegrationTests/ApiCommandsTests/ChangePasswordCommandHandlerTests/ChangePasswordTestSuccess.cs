﻿using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.ChangePasswordCommandHandlerTests;

public class ChangePasswordTestSuccess : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task ChangePasswordTestSuccessAsync()
    {
        var user = await RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var command = new ChangePasswordCommand(
            UserId: user.Response.Tokens.UserId,
            CurrentPassword: "Bm3-`dPRv-/w#3)cw^97",
            NewPassword: "Gm3-`xPRr-/q#6)re^94",
            RepeatNewPassword: "Gm3-`xPRr-/q#6)re^94");

        var result = await RequestAsync(command, CancellationToken.None);

        assert.Pass(result);
    }
}
