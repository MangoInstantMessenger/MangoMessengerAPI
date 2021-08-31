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
    public class ArchiveChatCommandHandlerTest
    {
        [Test]
        public async Task ArchiveChatCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new ArchiveChatCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new ArchiveChatCommand
            {
                Archived = true,
                UserId = "1",
                ChatId = "3",
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
        }

        [Test]
        public async Task ArchiveChatCommandHandlerTest_ShouldThrowChatNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new ArchiveChatCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new ArchiveChatCommand
            {
                Archived = true,
                UserId = "111",
                ChatId = "333",
            };

            Func<Task> request = async () => await handler.Handle(command, CancellationToken.None);

            await request.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.ChatNotFound);
        }
    }
}
