using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommandHandlers.Chats;
using MangoAPI.BusinessLogic.ApiCommands.Chats;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.CommandHandlerTests.Chats
{
    [TestFixture]
    public class JoinChatCommandHandlerTest
    {
        [Test]
        public async Task JoinChatCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new JoinChatCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new JoinChatCommand
            {
                UserId = "2",
                ChatId = "1"
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
        }
        
        [Test]
        public async Task JoinChatCommandHandlerTest_ShouldThrowAlreadyJoined()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new JoinChatCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new JoinChatCommand
            {
                UserId = "2",
                ChatId = "1"
            };

            await handler.Handle(command, CancellationToken.None);
            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage("USER_ALREADY_JOINED_GROUP");
        }

        [Test]
        public async Task JoinChatCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new JoinChatCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new JoinChatCommand
            {
                UserId = "1241",
                ChatId = "21512"
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }

        [Test]
        public async Task JoinChatCommandHandlerTest_ShouldThrowChatNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new JoinChatCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new JoinChatCommand
            {
                UserId = "1",
                ChatId = "21512"
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.ChatNotFound);
        }
    }
}