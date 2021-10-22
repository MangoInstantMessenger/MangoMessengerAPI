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
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.ExtremeCodeFloodId,
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
        }

        [Test]
        public async Task ArchiveChatCommandHandlerTest_ShouldThrowChatNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new ArchiveChatCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new ArchiveChatCommand
            {
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = Guid.NewGuid(),
            };

            Func<Task> request = async () => await handler.Handle(command, CancellationToken.None);

            await request.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.ChatNotFound);
        }
    }
}