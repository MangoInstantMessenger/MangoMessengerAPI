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
    public class VerifyEmailCommandHandlerTest
    {
        [Test]
        public async Task VerifyEmailCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new VerifyEmailCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new VerifyEmailCommand
            {
                UserId = SeedDataConstants.AmelitId,
                Email = "amelit@gmail.com",
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
        }

        [Test]
        public async Task VerifyEmailCommandHandlerTest_ShouldThrowInvalidEmail()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new VerifyEmailCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new VerifyEmailCommand
            {
                UserId = SeedDataConstants.RazumovskyId,
                Email = "kolosovp@gmail.com",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.InvalidEmail);
        }

        [Test]
        public async Task VerifyEmailCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new VerifyEmailCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new VerifyEmailCommand
            {
                UserId = Guid.NewGuid(),
                Email = "kolosovp94@gmail.com",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }

        [Test]
        public async Task VerifyEmailCommandHandlerTest_ShouldThrowEmailAlreadyVerified()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new VerifyEmailCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new VerifyEmailCommand
            {
                UserId = SeedDataConstants.RazumovskyId,
                Email = "kolosovp95@gmail.com",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.EmailAlreadyVerified);
        }
    }
}