namespace MangoAPI.Tests.ApiCommandsTests.Contacts
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using FluentAssertions;
    using MangoAPI.BusinessLogic.ApiCommands.Contacts;
    using MangoAPI.BusinessLogic.BusinessExceptions;
    using MangoAPI.Domain.Constants;
    using NUnit.Framework;

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
                ContactId = "3",
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
                ContactId = "212",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }

        [Test]
        public async Task AddContactCommandHandlerTest_ShouldThrowContactAlreadyExists()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new AddContactCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new AddContactCommand
            {
                UserId = "1",
                ContactId = "2",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.ContactAlreadyExist);
        }
    }
}
