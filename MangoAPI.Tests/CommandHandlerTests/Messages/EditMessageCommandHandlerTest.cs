using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommandHandlers.Messages;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.BusinessExceptions;
using Microsoft.AspNetCore.Identity;
using NUnit.Framework;

namespace MangoAPI.Tests.CommandHandlerTests.Messages
{
    [TestFixture]
    public class EditMessageCommandHandlerTest : TestBase
    {
        [Test]
        public async Task EditMessageCommandHandlerTest_200Test()
        {
            var handler = new EditMessageCommandHandler(PostgresDbContext);
            var command = new EditMessageCommand
            {
                UserId = "1",
                MessageId = "5",
                ModifiedText = "hello c#"
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
        }

        [Test]
        public async Task EditMessageCommandHandlerTest_400Test()
        {
            
        }

        [Test]
        public async Task EditMessageCommandHandlerTest_409Test()
        {
            var handler = new EditMessageCommandHandler(PostgresDbContext);
            var command = new EditMessageCommand
            {
                MessageId = "152",
                ModifiedText = "hello c#"
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            result.Should().ThrowAsync<BusinessException>()
                .WithMessage("MESSAGE_NOT_FOUND");
        }
    }
}