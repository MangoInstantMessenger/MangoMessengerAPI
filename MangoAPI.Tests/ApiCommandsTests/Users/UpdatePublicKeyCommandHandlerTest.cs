using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.Users
{
    [TestFixture]
    public class UpdatePublicKeyCommandHandlerTest
    {
        [Test]
        public async Task UpdatePublicKeyCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new UpdatePublicKeyCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new UpdatePublicKeyCommand(SeedDataConstants.RazumovskyId, 1337);

            var response = await handler.Handle(command, CancellationToken.None);

            response.Success.Should().BeTrue();
        }

        [Test]
        public async Task UpdatePublicKeyCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new UpdatePublicKeyCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new UpdatePublicKeyCommand(Guid.NewGuid(), 1337);

            Func<Task> request = async () => await handler.Handle(command, CancellationToken.None);

            await request.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }
    }
}