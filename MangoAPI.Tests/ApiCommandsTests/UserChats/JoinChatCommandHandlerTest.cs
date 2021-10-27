using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.UserChats;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.UserChats
{
    [TestFixture]
    public class JoinChatCommandHandlerTest
    {
        // [Test]
        // public async Task JoinChatCommandHandlerTest_Success()
        // {
        //     using var dbContextFixture = new DbContextFixture();
        //     var handler = new JoinChatCommandHandler(dbContextFixture.PostgresDbContext);
        //     var command = new JoinChatCommand
        //     {
        //         UserId = SeedDataConstants.RazumovskyId,
        //         ChatId = SeedDataConstants.WsbId
        //     };
        //
        //     var result = await handler.Handle(command, CancellationToken.None);
        //
        //     result.Response.Success.Should().BeTrue();
        //     result.Error.Should().BeNull();
        // }

        [Test]
        public async Task JoinChatCommandHandlerTest_ShouldThrowAlreadyJoined()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new JoinChatCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new JoinChatCommand
            {
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.ExtremeCodeFloodId,
            };
            
            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.UserAlreadyJoinedGroup);
            result.Response.Should().BeNull();
        }

        // [Test]
        // public async Task JoinChatCommandHandlerTest_ShouldThrowUserNotFound()
        // {
        //     using var dbContextFixture = new DbContextFixture();
        //     var handler = new JoinChatCommandHandler(dbContextFixture.PostgresDbContext);
        //     var command = new JoinChatCommand
        //     {
        //         UserId = Guid.NewGuid(),
        //         ChatId = SeedDataConstants.ExtremeCodeDotnetId
        //     };
        //
        //     var result = await handler.Handle(command, CancellationToken.None);
        //
        //     result.Error.Success.Should().BeFalse();
        //     result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.UserNotFound);
        //     result.Response.Should().BeNull();
        // }

        [Test]
        public async Task JoinChatCommandHandlerTest_ShouldThrowChatNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new JoinChatCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new JoinChatCommand
            {
                UserId = SeedDataConstants.SzymonId,
                ChatId = Guid.NewGuid(),
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.ChatNotFound);
            result.Response.Should().BeNull();
        }
    }
}
