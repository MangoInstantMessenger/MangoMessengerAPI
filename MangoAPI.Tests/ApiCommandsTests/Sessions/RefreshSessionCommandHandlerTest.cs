using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.Sessions
{
    [TestFixture]
    public class RefreshSessionCommandHandlerTest
    {
        [Test]
        public async Task RefreshSessionCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var jwtGenerator = new JwtGenerator();
            var handler = new RefreshSessionCommandHandler(dbContextFixture.PostgresDbContext, jwtGenerator);
            var command = new RefreshSessionCommand {RefreshToken = "69dbef09-de5a-4da7-9d67-abeba1510118"};

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
            result.RefreshToken.Should().NotBeNullOrEmpty();
            result.AccessToken.Should().NotBeNullOrEmpty();
        }

        [Test]
        public async Task RefreshSessionCommandHandlerTest_ShouldThrowInvalidOrExpiredRefreshToken()
        {
            using var dbContextFixture = new DbContextFixture();
            var jwtGenerator = new JwtGenerator();
            var handler = new RefreshSessionCommandHandler(dbContextFixture.PostgresDbContext, jwtGenerator);
            var command = new RefreshSessionCommand {RefreshToken = "Invalid_ID"};

            Func<Task> execute = async () => await handler.Handle(command, CancellationToken.None);

            await execute.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.InvalidOrExpiredRefreshToken);
        }
    }
}