﻿using System;
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
            Guid.NewGuid(),
            "Gm3-`xPRr-/q#6)re^94",
            "Gm3-`xPRr-/q#6)re^94",
            "Gm3-`xPRr-/q#6)re^94");

        var result = validator.TestValidate(command);

        result.ShouldHaveValidationErrorFor(x => x.CurrentPassword);
        result.Errors.Count.Should().Be(1);
        result.Errors[0].ErrorMessage.Should().Be("New and old passwords cannot be same");
    }
}