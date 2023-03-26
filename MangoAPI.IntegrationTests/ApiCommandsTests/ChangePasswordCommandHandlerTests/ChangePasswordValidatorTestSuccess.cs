using System;
using FluentValidation.TestHelper;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.ChangePasswordCommandHandlerTests;

public class ChangePasswordValidatorTestSuccess
{
    [Fact]
    public void ChangePasswordValidatorTestSuccessTest()
    {
        var validator = new ChangePasswordCommandValidator();
        var command = new ChangePasswordCommand(
            Guid.NewGuid(),
            "Bm3-`dPRv-/w#3)cw^97",
            "Gm3-`xPRr-/q#6)re^94",
            "Gm3-`xPRr-/q#6)re^94");

        var result = validator.TestValidate(command);

        result.ShouldNotHaveAnyValidationErrors();
    }
}