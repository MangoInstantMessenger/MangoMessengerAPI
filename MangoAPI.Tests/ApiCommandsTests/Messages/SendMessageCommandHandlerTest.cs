namespace MangoAPI.Tests.ApiCommandsTests.Messages
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using FluentAssertions;
    using MangoAPI.BusinessLogic.ApiCommands.Messages;
    using BusinessLogic.BusinessExceptions;
    using Domain.Constants;
    using NUnit.Framework;

    [TestFixture]
    public class SendMessageCommandHandlerTest
    {
        [Test]
        public async Task SendMessageCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new SendMessageCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new SendMessageCommand
            {
                UserId = "1",
                ChatId = "4",
                MessageText = "hello world",
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
        }

        [Test]
        public async Task SendMessageCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new SendMessageCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new SendMessageCommand
            {
                UserId = "15",
                ChatId = "3",
                MessageText = "hello world",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }

        [Test]
        public async Task SendMessageCommandHandlerTest_ShouldThrowChatNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new SendMessageCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new SendMessageCommand
            {
                UserId = "1",
                ChatId = "24",
                MessageText = "hello world",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.ChatNotFound);
        }

        [Test]
        public async Task SendMessageCommandHandlerTest_ShouldThrowPermissionDenied()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new SendMessageCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new SendMessageCommand
            {
                UserId = "1",
                ChatId = "2",
                MessageText = "hello world",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.PermissionDenied);
        }
    }
}
