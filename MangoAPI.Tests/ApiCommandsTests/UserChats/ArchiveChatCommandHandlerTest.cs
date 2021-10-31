using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.UserChats;
using MangoAPI.BusinessLogic.Responses;
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
            var responseFactory = new ResponseFactory<ResponseBase>(); 
            var handler = new ArchiveChatCommandHandler(dbContextFixture.PostgresDbContext, responseFactory);
            var command = new ArchiveChatCommand
            {
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.ExtremeCodeFloodId,
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
            result.Error.Should().BeNull();
        }

        [Test]
        public async Task ArchiveChatCommandHandlerTest_ShouldThrowChatNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var responseFactory = new ResponseFactory<ResponseBase>(); 
            var handler = new ArchiveChatCommandHandler(dbContextFixture.PostgresDbContext, responseFactory);
            var command = new ArchiveChatCommand
            {
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = Guid.NewGuid(),
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.ChatNotFound);
            result.Response.Should().BeNull();
        }
    }
}