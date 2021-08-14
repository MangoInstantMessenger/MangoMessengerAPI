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
    public class CreateDirectChatCommandHandlerTest : TestBase
    {
        [Test]
        public async Task CreateDirectChatCommandHandler_200Test()
        {
            var handler = new CreateDirectChatCommandHandler(PostgresDbContext);
            var createChatCommand = new CreateDirectChatCommand
            {
                UserId = "1",
                PartnerId = "2"
            };

            var result = await handler.Handle(createChatCommand, CancellationToken.None);

            result.Success.Should().BeTrue();

        }

        [Test]
        public async Task CreateDirectChatCommandHandler_409Test()
        {
            var handler = new CreateDirectChatCommandHandler(PostgresDbContext);
            var createDirectChatCommand = new CreateDirectChatCommand
            {
                UserId = "3421512523",
                PartnerId = "15241412"
            };

            Func<Task> result = async () => await handler.Handle(createDirectChatCommand, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage("USER_NOT_FOUND");
        }
    }
}