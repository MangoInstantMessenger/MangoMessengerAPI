using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.UserChats;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.UserChats
{
    [TestFixture]
    public class LeaveGroupCommandHandlerTests
    {
        [Test]
        public async Task LeaveChatCommandHandler_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new LeaveGroupCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new LeaveGroupCommand
            {
                UserId = "1",
                ChatId = "3",
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
        }
        
        [Test]
        public async Task LeaveChatCommandHandler_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new LeaveGroupCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new LeaveGroupCommand
            {
                UserId = "24",
                ChatId = "3",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }
        
        [Test]
        public async Task LeaveChatCommandHandler_ShouldThrowChatNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new LeaveGroupCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new LeaveGroupCommand
            {
                UserId = "1",
                ChatId = "35",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.ChatNotFound);
        }
    }
}