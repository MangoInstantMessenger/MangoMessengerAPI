using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.BusinessExceptions;
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
            var handler = new LogoutAllCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new LogoutAllCommand { UserId = "1" };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
        }

        [Test]
        public async Task LogoutAllCommandHandlerTest_ShouldThrowInvalidOrExpiredRefreshToken()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new LogoutAllCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new LogoutAllCommand { UserId = "3" };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.InvalidOrExpiredRefreshToken);
        }
    }
}
