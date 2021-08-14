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
    public class AddContactCommandHandlerTest : TestBase
    {
        [Test]
        public async Task AddContactCommandHandlerTest_200()
        {
            var handler = new AddContactCommandHandler(PostgresDbContext);
            var command = new AddContactCommand
            {
                UserId = "1",
                ContactId = "2"
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
        }

        [Test]
        public async Task AddContactCommandHandlerTest_409()
        {
            var handler = new AddContactCommandHandler(PostgresDbContext);
            var command = new AddContactCommand
            {
                UserId = "123",
                ContactId = "212"
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage("CONTACT_NOT_FOUND");
        }
    }
}