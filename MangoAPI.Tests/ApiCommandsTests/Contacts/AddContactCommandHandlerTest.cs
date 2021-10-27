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
    public class AddContactCommandHandlerTest
    {
        [Test]
        public async Task AddContactCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new AddContactCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new AddContactCommand
            {
                UserId = SeedDataConstants.PetroId,
                ContactId = SeedDataConstants.AmelitId
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
            result.Error.Should().BeNull();
        }

        // [Test]
        // public async Task AddContactCommandHandlerTest_ShouldThrowUserNotFound()
        // {
        //     using var dbContextFixture = new DbContextFixture();
        //     var handler = new AddContactCommandHandler(dbContextFixture.PostgresDbContext);
        //     var command = new AddContactCommand
        //     {
        //         UserId = Guid.NewGuid(),
        //         ContactId = Guid.NewGuid()
        //     };
        //
        //     var result = await handler.Handle(command, CancellationToken.None);
        //
        //     result.Error.Success.Should().BeFalse();
        //     result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.UserNotFound);
        //     result.Response.Should().BeNull();
        // }

        [Test]
        public async Task AddContactCommandHandlerTest_ShouldThrowContactAlreadyExists()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new AddContactCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new AddContactCommand
            {
                UserId = SeedDataConstants.PetroId,
                ContactId = SeedDataConstants.SzymonId
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.ContactAlreadyExist);
            result.Response.Should().BeNull();
        }
    }
}