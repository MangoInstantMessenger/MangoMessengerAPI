using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using MangoAPI.BusinessLogic.BusinessExceptions;
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
        }

        //[Test]
        //public async Task AddContactCommandHandlerTest_ShouldThrowUserNotFound()
        //{
        //    using var dbContextFixture = new DbContextFixture();
        //    var handler = new AddContactCommandHandler(dbContextFixture.PostgresDbContext);
        //    var command = new AddContactCommand
        //    {
        //        UserId = Guid.NewGuid(),
        //        ContactId = Guid.NewGuid()
        //    };

        //    Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

        //    await result.Should().ThrowAsync<BusinessException>()
        //        .WithMessage(ResponseMessageCodes.UserNotFound);
        //}

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

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.ContactAlreadyExist);
        }
    }
}