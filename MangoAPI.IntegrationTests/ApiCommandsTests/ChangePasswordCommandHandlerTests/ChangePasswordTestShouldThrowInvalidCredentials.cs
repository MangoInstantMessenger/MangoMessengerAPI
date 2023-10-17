﻿using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.ChangePasswordCommandHandlerTests;

public class ChangePasswordTestShouldThrowInvalidCredentials : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task ChangePasswordTestShouldThrowInvalidCredentialsAsync()
    {
        const string expectedMessage = ResponseMessageCodes.InvalidCredentials;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var user = await RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var command = new ChangePasswordCommand(
            UserId: user.Response.Tokens.UserId,
            CurrentPassword: "Gm3-`xPRr-/q#6)rgf^925",
            NewPassword: "Gm3-`xPRr-/q#6)re^94",
            RepeatNewPassword: "Gm3-`xPRr-/q#6)re^94");

        var result = await RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
