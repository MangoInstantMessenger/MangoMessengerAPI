using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.Users
{
    [TestFixture]
    public class RegisterCommandHandlerTest
    {
        [Test]
        public async Task RegisterCommandHandler_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var store = new Mock<IUserStore<UserEntity>>();
            var options = new Mock<IOptions<IdentityOptions>>();
            var idOptions = new IdentityOptions { Lockout = { AllowedForNewUsers = false } };
            options.Setup(o => o.Value).Returns(idOptions);
            var userValidators = new List<IUserValidator<UserEntity>>();
            var validator = new Mock<IUserValidator<UserEntity>>();
            userValidators.Add(validator.Object);
            var pwdValidators = new List<PasswordValidator<UserEntity>> { new PasswordValidator<UserEntity>() };
            var userManager = new Mock<UserManager<UserEntity>>(store.Object, options.Object,
                new PasswordHasher<UserEntity>(),
                userValidators, pwdValidators, new UpperInvariantLookupNormalizer(),
                new IdentityErrorDescriber(), null,
                new Mock<ILogger<UserManager<UserEntity>>>().Object);
            validator.Setup(v => v.ValidateAsync(userManager.Object, It.IsAny<UserEntity>()))
                .Returns(Task.FromResult(IdentityResult.Success)).Verifiable();
            userManager.Setup(x => x.CreateAsync(It.IsAny<UserEntity>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success)
                .Callback<UserEntity, string>((x, _) => dbContextFixture.PostgresDbContext.Users.Add(x));

            var jwtGenerator = new Mock<IJwtGenerator>();
            jwtGenerator.Setup(x =>
                    x.GenerateJwtToken(It.IsAny<Guid>(), It.IsAny<List<string>>()))
                .Returns("Token");

            var emailSender = new Mock<IEmailSenderService>();
            emailSender.Setup(x =>
                x.SendVerificationEmailAsync(It.IsAny<UserEntity>(), It.IsAny<CancellationToken>()));

            var handler = new RegisterCommandHandler(userManager.Object, dbContextFixture.PostgresDbContext,
                emailSender.Object, jwtGenerator.Object);
            var command = new RegisterCommand
            {
                PhoneNumber = "+1 234 567 89",
                Email = "test@mail.com",
                DisplayName = "Test User",
                Password = "WzLxl12{#@>?24",
                TermsAccepted = true,
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
        }

        [Test]
        public async Task RegisterCommandHandler_ShouldThrowInvalidEmail()
        {
            using var dbContextFixture = new DbContextFixture();
            var store = new Mock<IUserStore<UserEntity>>();
            var options = new Mock<IOptions<IdentityOptions>>();
            var idOptions = new IdentityOptions { Lockout = { AllowedForNewUsers = false } };
            options.Setup(o => o.Value).Returns(idOptions);
            var userValidators = new List<IUserValidator<UserEntity>>();
            var validator = new Mock<IUserValidator<UserEntity>>();
            userValidators.Add(validator.Object);
            var pwdValidators = new List<PasswordValidator<UserEntity>> { new PasswordValidator<UserEntity>() };
            var userManager = new Mock<UserManager<UserEntity>>(store.Object, options.Object,
                new PasswordHasher<UserEntity>(),
                userValidators, pwdValidators, new UpperInvariantLookupNormalizer(),
                new IdentityErrorDescriber(), null,
                new Mock<ILogger<UserManager<UserEntity>>>().Object);
            validator.Setup(v => v.ValidateAsync(userManager.Object, It.IsAny<UserEntity>()))
                .Returns(Task.FromResult(IdentityResult.Success)).Verifiable();
            userManager.Setup(x => x.CreateAsync(It.IsAny<UserEntity>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success)
                .Callback<UserEntity, string>((x, _) => dbContextFixture.PostgresDbContext.Users.Add(x));

            var jwtGenerator = new Mock<IJwtGenerator>();
            jwtGenerator.Setup(x =>
                    x.GenerateJwtToken(It.IsAny<Guid>(), It.IsAny<List<string>>()))
                .Returns("Token");

            var emailSender = new Mock<IEmailSenderService>();
            emailSender.Setup(x =>
                x.SendVerificationEmailAsync(It.IsAny<UserEntity>(), It.IsAny<CancellationToken>()));

            var handler = new RegisterCommandHandler(userManager.Object, dbContextFixture.PostgresDbContext,
                emailSender.Object, jwtGenerator.Object);
            var command = new RegisterCommand
            {
                PhoneNumber = "+1 234 567 89",
                Email = EnvironmentConstants.EmailSenderAddress,
                DisplayName = "Test User",
                Password = "WzLxl12{#@>?24",
                TermsAccepted = true,
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.InvalidEmail);
        }

        [Test]
        public async Task RegisterCommandHandler_ShouldThrowEmailOccupied()
        {
            using var dbContextFixture = new DbContextFixture();
            var store = new Mock<IUserStore<UserEntity>>();
            var options = new Mock<IOptions<IdentityOptions>>();
            var idOptions = new IdentityOptions { Lockout = { AllowedForNewUsers = false } };
            options.Setup(o => o.Value).Returns(idOptions);
            var userValidators = new List<IUserValidator<UserEntity>>();
            var validator = new Mock<IUserValidator<UserEntity>>();
            userValidators.Add(validator.Object);
            var pwdValidators = new List<PasswordValidator<UserEntity>> { new PasswordValidator<UserEntity>() };
            var userManager = new Mock<UserManager<UserEntity>>(store.Object,
                options.Object,
                new PasswordHasher<UserEntity>(),
                userValidators, pwdValidators, new UpperInvariantLookupNormalizer(),
                new IdentityErrorDescriber(), null,
                new Mock<ILogger<UserManager<UserEntity>>>().Object);
            validator.Setup(v => v.ValidateAsync(userManager.Object, It.IsAny<UserEntity>()))
                .Returns(Task.FromResult(IdentityResult.Success)).Verifiable();
            userManager.Setup(x => x.CreateAsync(It.IsAny<UserEntity>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success)
                .Callback<UserEntity, string>((x, _) => dbContextFixture.PostgresDbContext.Users.Add(x));

            var jwtGenerator = new Mock<IJwtGenerator>();
            jwtGenerator.Setup(x =>
                    x.GenerateJwtToken(It.IsAny<Guid>(), It.IsAny<List<string>>()))
                .Returns("Token");

            var emailSender = new Mock<IEmailSenderService>();
            emailSender.Setup(x =>
                x.SendVerificationEmailAsync(It.IsAny<UserEntity>(), It.IsAny<CancellationToken>()));

            var handler = new RegisterCommandHandler(userManager.Object, dbContextFixture.PostgresDbContext,
                emailSender.Object, jwtGenerator.Object);
            var command = new RegisterCommand
            {
                PhoneNumber = "+1 234 567 89",
                Email = "kolosovp95@gmail.com",
                DisplayName = "Test User",
                Password = "WzLxl12{#@>?24",
                TermsAccepted = true,
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserAlreadyExists);
        }

        //[Test]
        //public async Task RegisterCommandHandler_ShouldThrowPhoneOccupied()
        //{
        //    using var dbContextFixture = new DbContextFixture();
        //    var store = new Mock<IUserStore<UserEntity>>();
        //    var options = new Mock<IOptions<IdentityOptions>>();
        //    var idOptions = new IdentityOptions { Lockout = { AllowedForNewUsers = false } };
        //    options.Setup(o => o.Value).Returns(idOptions);
        //    var userValidators = new List<IUserValidator<UserEntity>>();
        //    var validator = new Mock<IUserValidator<UserEntity>>();
        //    userValidators.Add(validator.Object);
        //    var pwdValidators = new List<PasswordValidator<UserEntity>> { new PasswordValidator<UserEntity>() };
        //    var userManager = new Mock<UserManager<UserEntity>>(store.Object,
        //        options.Object,
        //        new PasswordHasher<UserEntity>(),
        //        userValidators, pwdValidators, new UpperInvariantLookupNormalizer(),
        //        new IdentityErrorDescriber(), null,
        //        new Mock<ILogger<UserManager<UserEntity>>>().Object);
        //    validator.Setup(v => v.ValidateAsync(userManager.Object, It.IsAny<UserEntity>()))
        //        .Returns(Task.FromResult(IdentityResult.Success)).Verifiable();
        //    userManager.Setup(x => x.CreateAsync(It.IsAny<UserEntity>(), It.IsAny<string>()))
        //        .ReturnsAsync(IdentityResult.Success)
        //        .Callback<UserEntity, string>((x, _) => dbContextFixture.PostgresDbContext.Users.Add(x));

        //    var jwtGenerator = new Mock<IJwtGenerator>();
        //    jwtGenerator.Setup(x =>
        //            x.GenerateJwtToken(It.IsAny<Guid>(), It.IsAny<List<string>>()))
        //        .Returns("Token");

        //    var emailSender = new Mock<IEmailSenderService>();
        //    emailSender.Setup(x =>
        //        x.SendVerificationEmailAsync(It.IsAny<UserEntity>(), It.IsAny<CancellationToken>()));

        //    var handler = new RegisterCommandHandler(userManager.Object, dbContextFixture.PostgresDbContext,
        //        emailSender.Object, jwtGenerator.Object);
        //    var command = new RegisterCommand
        //    {
        //        PhoneNumber = "48743615532",
        //        Email = "test@mail.com",
        //        DisplayName = "Test User",
        //        Password = "WzLxl12{#@>?24",
        //        TermsAccepted = true,
        //    };

        //    Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

        //    await result.Should().ThrowAsync<BusinessException>()
        //        .WithMessage(ResponseMessageCodes.PhoneOccupied);
        //}

        //[Test]
        //public async Task RegisterCommandHandlerTest_ShouldThrowWeakPassword()
        //{
        //    using var dbContextFixture = new DbContextFixture();
        //    var store = new Mock<IUserStore<UserEntity>>();
        //    var options = new Mock<IOptions<IdentityOptions>>();
        //    var idOptions = new IdentityOptions { Lockout = {AllowedForNewUsers = false} };
        //    options.Setup(o => o.Value).Returns(idOptions);
        //    var userValidators = new List<IUserValidator<UserEntity>>();
        //    var validator = new Mock<IUserValidator<UserEntity>>();
        //    userValidators.Add(validator.Object);
        //    var identityErrorDescriber = new IdentityErrorDescriber();
        //    var passwordValidator = new PasswordValidator<UserEntity>(identityErrorDescriber);
        //    var pwdValidators = new List<IPasswordValidator<UserEntity>> { passwordValidator };
        //    var userManager = new Mock<UserManager<UserEntity>>(store.Object,
        //        options.Object,
        //        new PasswordHasher<UserEntity>(),
        //        userValidators, pwdValidators, new UpperInvariantLookupNormalizer(),
        //        identityErrorDescriber, null,
        //        new Mock<ILogger<UserManager<UserEntity>>>().Object);
        //    validator.Setup(v => v.ValidateAsync(userManager.Object, It.IsAny<UserEntity>()))
        //        .Returns(Task.FromResult(IdentityResult.Success)).Verifiable();
        //    userManager.Setup(x => x.CreateAsync(It.IsAny<UserEntity>(), It.IsAny<string>())).ReturnsAsync(IdentityResult.Success)
        //        .Callback<UserEntity, string>((x, y) => dbContextFixture.PostgresDbContext.Users.Add(x));

        //    var jwtGenerator = new Mock<IJwtGenerator>();
        //    jwtGenerator.Setup(x =>
        //        x.GenerateJwtToken(It.IsAny<UserEntity>(), It.IsAny<List<string>>()))
        //        .Returns("Token");

        //    var emailSender = new Mock<IEmailSenderService>();
        //    emailSender.Setup(x =>
        //        x.SendVerificationEmailAsync(It.IsAny<UserEntity>(), It.IsAny<CancellationToken>()));

        //    var handler = new RegisterCommandHandler(userManager.Object, dbContextFixture.PostgresDbContext,
        //        emailSender.Object, jwtGenerator.Object);
        //    var command = new RegisterCommand
        //    {
        //        PhoneNumber = "+1 987 65 43 22",
        //        Email = "test@mail.com",
        //        DisplayName = "Test User",
        //        Password = "a",
        //        TermsAccepted = true,
        //    };

        //    Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

        //    await result.Should().ThrowAsync<BusinessException>()
        //        .WithMessage(ResponseMessageCodes.WeakPassword);
        //}
    }
}