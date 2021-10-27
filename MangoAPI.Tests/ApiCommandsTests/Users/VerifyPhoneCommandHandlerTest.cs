using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.Users
{
    [TestFixture]
    public class VerifyPhoneCommandHandlerTest
    {
        [Test]
        public async Task VerifyPhoneCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new VerifyPhoneCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new VerifyPhoneCommand
            {
                UserId = SeedDataConstants.AmelitId,
                ConfirmationCode = 555555,
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
            result.Error.Should().BeNull();
        }

        [Test]
        public async Task VerifyPhoneCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new VerifyPhoneCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new VerifyPhoneCommand
            {
                UserId = Guid.NewGuid(),
                ConfirmationCode = 524675,
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.UserNotFound);
            result.Response.Should().BeNull();
        }

        [Test]
        public async Task VerifyPhoneCommandHandlerTest_ShouldThrowPhoneAlreadyVerified()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new VerifyPhoneCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new VerifyPhoneCommand
            {
                UserId = SeedDataConstants.RazumovskyId,
                ConfirmationCode = 524675,
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.PhoneAlreadyVerified);
            result.Response.Should().BeNull();
        }

        [Test]
        public async Task VerifyPhoneCommandHandlerTest_ShouldThrowInvalidPhoneCode()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new VerifyPhoneCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new VerifyPhoneCommand
            {
                UserId = SeedDataConstants.AmelitId,
                ConfirmationCode = 555553,
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.InvalidPhoneCode);
            result.Response.Should().BeNull();
        }
    }
}
