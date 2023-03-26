using System;
using FluentAssertions;
using FluentValidation.TestHelper;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.ChangePasswordCommandHandlerTests;

public class ChangePasswordValidatorTestShouldThrowNewPasswordErrors
{
    [Fact]
    public void ChangePasswordValidatorTestShouldThrowNewAndRepeatPasswordAreNotSame()
    {
        var validator = new ChangePasswordCommandValidator();
        var command = new ChangePasswordCommand(
            Guid.NewGuid(),
            "Bm3-`dPRv-/w#3)cw^97",
            "Gm3-`xPRr-/q#6)re^94",
            "Gm4-`xPRr-/q#6)re^92");

        var result = validator.TestValidate(command);

        result.ShouldHaveValidationErrorFor(x => x.NewPassword);
        result.Errors.Count.Should().Be(1);
        result.Errors[0].ErrorMessage.Should().Be("New password and repeat password should be same.");
    }
}