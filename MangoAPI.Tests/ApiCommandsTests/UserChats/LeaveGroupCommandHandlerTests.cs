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
    public class LeaveGroupCommandHandlerTests
    {
        [Test]
        public async Task LeaveChatCommandHandler_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var responseFactory = new ResponseFactory<LeaveGroupResponse>();
            var handler = new LeaveGroupCommandHandler(dbContextFixture.PostgresDbContext, responseFactory);
            var command = new LeaveGroupCommand
            {
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.ExtremeCodeFloodId
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
            result.Error.Should().BeNull();
        }
        
        [Test]
        public async Task LeaveChatCommandHandler_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var responseFactory = new ResponseFactory<LeaveGroupResponse>();
            var handler = new LeaveGroupCommandHandler(dbContextFixture.PostgresDbContext, responseFactory);
            var command = new LeaveGroupCommand
            {
                UserId = Guid.NewGuid(),
                ChatId = SeedDataConstants.ExtremeCodeFloodId,
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.UserNotFound);
            result.Response.Should().BeNull();
        }
        
        [Test]
        public async Task LeaveChatCommandHandler_ShouldThrowChatNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var responseFactory = new ResponseFactory<LeaveGroupResponse>();
            var handler = new LeaveGroupCommandHandler(dbContextFixture.PostgresDbContext, responseFactory);
            var command = new LeaveGroupCommand
            {
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = Guid.NewGuid()
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.ChatNotFound);
            result.Response.Should().BeNull();
        }
    }
}