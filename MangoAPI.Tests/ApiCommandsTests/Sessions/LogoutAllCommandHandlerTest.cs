using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.Sessions
{
    [TestFixture]
    public class LogoutAllCommandHandlerTest
    {
        [Test]
        public async Task LogoutAllCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new LogoutAllCommandHandler(dbContextFixture.PostgresDbContext, responseFactory);

            var command = new LogoutAllCommand
            {
                UserId = SeedDataConstants.PetroId
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
            result.Error.Should().BeNull();
        }

        [Test]
        public async Task LogoutAllCommandHandlerTest_ShouldThrowInvalidOrExpiredRefreshToken()
        {
            using var dbContextFixture = new DbContextFixture();
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new LogoutAllCommandHandler(dbContextFixture.PostgresDbContext, responseFactory);
            var command = new LogoutAllCommand
            {
                UserId = Guid.NewGuid()
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.InvalidOrExpiredRefreshToken);
            result.Response.Should().BeNull();
        }
    }
}