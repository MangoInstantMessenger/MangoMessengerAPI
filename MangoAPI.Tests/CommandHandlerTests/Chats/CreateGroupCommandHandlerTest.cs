using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Chats;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using NUnit.Framework;

namespace MangoAPI.Tests.CommandHandlerTests.Chats
{
    [TestFixture]
    public class CreateGroupCommandHandlerTest
    {
        [Test]
        public async Task CreateGroupCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new CreateGroupCommandHandler(dbContextFixture.PostgresDbContext);
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
        public async Task CreateGroupCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new CreateGroupCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new CreateGroupCommand
            {
                UserId = "12412512",
                GroupType = ChatType.PublicChannel,
                GroupTitle = "Extreme Code"
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }
    }
}