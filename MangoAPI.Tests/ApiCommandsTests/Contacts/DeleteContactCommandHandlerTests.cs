using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.Contacts
{
    [TestFixture]
    public class DeleteContactCommandHandlerTests
    {
        [Test]
        public async Task DeleteContactCommandHandler_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new DeleteContactCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new DeleteContactCommand
            {
                UserId = SeedDataConstants.PetroId,
                ContactId = SeedDataConstants.SzymonId,
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
            result.Error.Should().BeNull();
        }

        [Test]
        public async Task DeleteContactCommandHandler_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new DeleteContactCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new DeleteContactCommand
            {
                UserId = Guid.NewGuid(),
                ContactId = SeedDataConstants.PetroId,
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.UserNotFound);
            result.Response.Should().BeNull();
        }

        [Test]
        public async Task DeleteContactCommandHandler_ShouldThrowContactNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new DeleteContactCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new DeleteContactCommand
            {
                UserId = SeedDataConstants.PetroId,
                ContactId = Guid.NewGuid(),
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.ContactNotFound);
            result.Response.Should().BeNull();
        }
    }
}