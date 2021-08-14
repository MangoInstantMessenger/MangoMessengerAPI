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
    public class SendMessageCommandHandlerTest : TestBase
    {
        [Test]
        public async Task SendMessageCommandHandlerTest_200Test()
        {
            var handler = new SendMessageCommandHandler(PostgresDbContext);
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
        public async Task SendMessageCommandHandlerTest_400Test()
        {
            
        }

        [Test]
        public async Task SendMessageCommandHandlerTest_409Test()
        {
            var handler = new SendMessageCommandHandler(PostgresDbContext);
            var command = new SendMessageCommand
            {
                UserId = "15",
                ChatId = "24",
                MessageText = "hello world"
            };
            
            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            result.Should().ThrowAsync<BusinessException>()
                .WithMessage("PERMISSION_DENIED");
        }
    }
}