using System;
using FluentAssertions;
using FluentValidation.TestHelper;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.ChangePasswordCommandHandlerTests;

public class ChangePasswordValidatorTestShouldThrowNewPasswordErrors
{

    [Fact]
    public void ChangePasswordValidatorTest_ShouldThrowNewAndRepeatPasswordAreNotSame()
    {
        var validator = new ChangePasswordCommandValidator();
        var command = new ChangePasswordCommand
        {
            UserId = Guid.NewGuid(),
            CurrentPassword = "Bm3-`dPRv-/w#3)cw^97",
            NewPassword = "Gm3-`xPRr-/q#6)re^94",
            RepeatNewPassword = "Gm4-`xPRr-/q#6)re^92"
        };
            
        var result = validator.TestValidate(command);

        result.ShouldHaveValidationErrorFor(x => x.NewPassword);
        result.Errors.Count.Should().Be(1);
        result.Errors[0].ErrorMessage.Should().Be("New password and repeat password should be same.");
    }
    
    [Fact]
    public void ChangePasswordValidatorTest_ShouldThrowWeakPassword()
    {
        var validator = new ChangePasswordCommandValidator();
        var command = new ChangePasswordCommand
        {
            UserId = Guid.NewGuid(),
            CurrentPassword = "Bm3-`dPRv-/w#3)cw^97",
            NewPassword = "12345678",
            RepeatNewPassword = "12345678"
        };
            
        var result = validator.TestValidate(command);

        result.ShouldHaveValidationErrorFor(x => x.NewPassword);
        result.Errors.Count.Should().Be(1);
        result.Errors[0].ErrorMessage.Should().Be("Password must be at least 8 characters with: " +
                                                  "1 uppercase, 1 lowercase, 1 digit, 1 symbol.");
    }

}