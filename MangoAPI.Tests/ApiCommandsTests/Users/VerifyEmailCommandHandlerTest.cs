namespace MangoAPI.Tests.ApiCommandsTests.Users
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using FluentAssertions;
    using MangoAPI.BusinessLogic.ApiCommands.Users;
    using MangoAPI.BusinessLogic.BusinessExceptions;
    using MangoAPI.Domain.Constants;
    using NUnit.Framework;

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
                UserId = "1",
                Email = "kolosovp94@gmail.com",
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
                UserId = "1",
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
                UserId = "24",
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
                UserId = "3",
                Email = "kolosovp95@gmail.com",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.EmailAlreadyVerified);
        }
    }
}
