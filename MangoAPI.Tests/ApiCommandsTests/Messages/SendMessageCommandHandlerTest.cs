using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.Messages
{
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
                UserId = SeedDataConstants.SzymonId,
                ChatId = SeedDataConstants.WsbId,
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
                UserId = Guid.NewGuid(),
                ChatId = Guid.NewGuid(),
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
                UserId = SeedDataConstants.SzymonId,
                ChatId = Guid.Empty,
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
                UserId = SeedDataConstants.KolbasatorId,
                ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                MessageText = "hello world",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.PermissionDenied);
        }
    }
}