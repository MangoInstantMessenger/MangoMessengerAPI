using System;
using FluentAssertions;
using FluentValidation.TestHelper;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.ChangePasswordCommandHandlerTests;

public class ChangePasswordValidatorTestShouldThrowCurrentPasswordError
{
    [Fact]
    public void ChangePasswordValidatorTestShouldThrowCurrentPasswordErrorTest()
    {
        var validator = new ChangePasswordCommandValidator();
        var command = new ChangePasswordCommand(
            UserId: Guid.NewGuid(),
            CurrentPassword: "Gm3-`xPRr-/q#6)re^94",
            NewPassword: "Gm3-`xPRr-/q#6)re^94",
            RepeatNewPassword: "Gm3-`xPRr-/q#6)re^94");

        var result = validator.TestValidate(command);

        _ = result.ShouldHaveValidationErrorFor(x => x.CurrentPassword);
        _ = result.Errors.Count.Should().Be(1);
        _ = result.Errors[0].ErrorMessage.Should().Be("New and old passwords cannot be same");
    }
}
