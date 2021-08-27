namespace MangoAPI.Tests.ApiCommandsTests.Chats
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using FluentAssertions;
    using MangoAPI.BusinessLogic.ApiCommands.Chats;
    using BusinessLogic.BusinessExceptions;
    using Domain.Constants;
    using Domain.Enums;
    using NUnit.Framework;

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
                GroupTitle = "Extreme Code",
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
                GroupTitle = "Extreme Code",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }
    }
}
