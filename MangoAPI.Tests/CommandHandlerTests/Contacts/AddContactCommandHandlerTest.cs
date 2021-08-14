using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommandHandlers.Contacts;
using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using MangoAPI.BusinessLogic.BusinessExceptions;
using NUnit.Framework;

namespace MangoAPI.Tests.CommandHandlerTests.Contacts
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
                UserId = "1",
                ContactId = "2"
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
        }

        [Test]
        public async Task AddContactCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new AddContactCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new AddContactCommand
            {
                UserId = "123",
                ContactId = "212"
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage("USER_NOT_FOUND");
        }
        
        [Test]
        public async Task AddContactCommandHandlerTest_ShouldThrowContactAlreadyExists()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new AddContactCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new AddContactCommand
            {
                UserId = "1",
                ContactId = "2"
            };

            await handler.Handle(command, CancellationToken.None);
            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage("CONTACT_ALREADY_EXISTS");
        }
    }
}