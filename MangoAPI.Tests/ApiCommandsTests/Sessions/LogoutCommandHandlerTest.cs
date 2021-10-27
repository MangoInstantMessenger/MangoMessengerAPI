using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.Sessions
{
    [TestFixture]
    public class LogoutCommandHandlerTest
    {
        [Test]
        public async Task LogoutCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new LogoutCommandHandler(dbContextFixture.PostgresDbContext);
            
            var command = new LogoutCommand
            {
                RefreshToken = "69dbef09-de5a-4da7-9d67-abeba1510118".AsGuid()
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
        }

        [Test]
        public async Task LogoutCommandHandlerTest_ShouldThrowInvalidOrExpiredRefreshToken()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new LogoutCommandHandler(dbContextFixture.PostgresDbContext);
            
            var command = new LogoutCommand
            {
                RefreshToken = "69dbef09-de5a-4da7-9d67-abeba1510135".AsGuid()
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.InvalidOrExpiredRefreshToken);
            result.Response.Should().BeNull();
        }

        [Test]
        public async Task LogoutCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new LogoutCommandHandler(dbContextFixture.PostgresDbContext);
            
            var command = new LogoutCommand
            {
                RefreshToken = "219d9df3-9bc0-4679-baaa-c18b1c7524e8".AsGuid()
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.UserNotFound);
            result.Response.Should().BeNull();
        }
    }
}