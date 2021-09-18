using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.Domain.Constants;
using Microsoft.AspNetCore.SignalR;
using NUnit.Framework;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Tests.ApiCommandsTests.Messages
{
    [TestFixture]
    public class SendMessageCommandHandlerTest
    {
        private static readonly IHubContext<ChatHub, IHubClient> Hub = MockedObjects.GetHubContext();

        [Test]
        public async Task SendMessageCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new SendMessageCommandHandler(dbContextFixture.PostgresDbContext, Hub);
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
            var handler = new SendMessageCommandHandler(dbContextFixture.PostgresDbContext, Hub);
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
            var handler = new SendMessageCommandHandler(dbContextFixture.PostgresDbContext, Hub);
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
            var handler = new SendMessageCommandHandler(dbContextFixture.PostgresDbContext, Hub);
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