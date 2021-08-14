using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommandHandlers.Chats;
using MangoAPI.BusinessLogic.ApiCommands.Chats;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.Domain.Enums;
using NUnit.Framework;

namespace MangoAPI.Tests.CommandHandlerTests.Chats
{
    [TestFixture]
    public class CreateGroupCommandHandlerTest : TestBase
    {
        [Test]
        public async Task CreateGroupCommandHandler_200Test()
        {
            var handler = new CreateGroupCommandHandler(PostgresDbContext);
            var command = new CreateGroupCommand
            {
                UserId = "1",
                GroupType = ChatType.PublicChannel,
                GroupTitle = "Extreme Code"
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
        }

        [Test]
        public async Task CreateGroupCommandHandler_409Test()
        {
            var handler = new CreateGroupCommandHandler(PostgresDbContext);
            var command = new CreateGroupCommand
            {
                UserId = "12412512",
                GroupType = ChatType.PublicChannel,
                GroupTitle = "Extreme Code"
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage("USER_NOT_FOUND");
        }
    }
}