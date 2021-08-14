using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommandHandlers.Chats;
using MangoAPI.BusinessLogic.ApiCommands.Chats;
using MangoAPI.BusinessLogic.BusinessExceptions;
using NUnit.Framework;

namespace MangoAPI.Tests.CommandHandlerTests.Chats
{
    [TestFixture]
    public class JoinChatCommandHandlerTest : TestBase
    {
        [Test]
        public async Task JoinChatCommandHandlerTest_200Test()
        {
            var handler = new JoinChatCommandHandler(PostgresDbContext);
            var command = new JoinChatCommand
            {
                UserId = "2",
                ChatId = "3"
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
        }

        [Test]
        public async Task JoinChatCommandHandler_409Test()
        {
            var handler = new JoinChatCommandHandler(PostgresDbContext);
            var command = new JoinChatCommand
            {
                UserId = "1241",
                ChatId = "21512"
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>();
        }
    }
}