using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommandHandlers.Messages;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.BusinessExceptions;
using NUnit.Framework;

namespace MangoAPI.Tests.CommandHandlerTests.Messages
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
                UserId = "1",
                ChatId = "3",
                MessageText = "hello world"
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
                ChatId = "24",
                MessageText = "hello world"
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage("USER_NOT_FOUND");
        }

        [Test]
        public async Task SendMessageCommandHandlerTest_ShouldThrowChatNotFound()
        {
            throw new NotImplementedException();
        }

        [Test]
        public async Task SendMessageCommandHandlerTest_ShouldThrowPermissionDenied()
        {
            throw new NotImplementedException();
        }
    }
}