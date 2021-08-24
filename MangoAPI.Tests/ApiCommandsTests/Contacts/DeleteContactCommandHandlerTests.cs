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
    public class DeleteContactCommandHandlerTests
    {
        [Test]
        public async Task DeleteContactCommandHandler_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new DeleteContactCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new DeleteContactCommand
            {
                UserId = "1",
                ContactId = "2",
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
        }
        
        [Test]
        public async Task DeleteContactCommandHandler_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new DeleteContactCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new DeleteContactCommand
            {
                UserId = "15",
                ContactId = "2",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }
        
        [Test]
        public async Task DeleteContactCommandHandler_ShouldThrowChatNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new DeleteContactCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new DeleteContactCommand
            {
                UserId = "2",
                ContactId = "25",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.ContactNotFound);
        }
    }
}