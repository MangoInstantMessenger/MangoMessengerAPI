using System;
using FluentValidation.TestHelper;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.ChangePasswordCommandHandlerTests;

public class ChangePasswordValidatorTestSuccess
{
    [Fact]
    public void ChangePasswordValidatorTest_Success()
    {
        var passwordValidator = new PasswordValidatorService();
        var validator = new ChangePasswordCommandValidator(passwordValidator);
        var command = new ChangePasswordCommand
        {
            UserId = Guid.NewGuid(),
            CurrentPassword = "Bm3-`dPRv-/w#3)cw^97",
            NewPassword = "Gm3-`xPRr-/q#6)re^94",
            RepeatNewPassword = "Gm3-`xPRr-/q#6)re^94"
        };
            
        var result = validator.TestValidate(command);

        result.ShouldNotHaveAnyValidationErrors();
    }
}