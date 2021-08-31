using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.BusinessExceptions;
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
                UserId = "2",
                ConfirmationCode = 524675,
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
        }

        [Test]
        public async Task VerifyPhoneCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new VerifyPhoneCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new VerifyPhoneCommand
            {
                UserId = "24",
                ConfirmationCode = 524675,
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }

        [Test]
        public async Task VerifyPhoneCommandHandlerTest_ShouldThrowPhoneAlreadyVerified()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new VerifyPhoneCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new VerifyPhoneCommand
            {
                UserId = "1",
                ConfirmationCode = 524675,
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.PhoneAlreadyVerified);
        }

        [Test]
        public async Task VerifyPhoneCommandHandlerTest_ShouldThrowInvalidPhoneCode()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new VerifyPhoneCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new VerifyPhoneCommand
            {
                UserId = "3",
                ConfirmationCode = 543178,
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.InvalidPhoneCode);
        }
    }
}
