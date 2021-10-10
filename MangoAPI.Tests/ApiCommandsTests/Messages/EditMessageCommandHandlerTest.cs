using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.Domain.Constants;
using NUnit.Framework;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Tests.ApiCommandsTests.Messages
{
    [TestFixture]
    public class EditMessageCommandHandlerTest
    {
        [Test]
        public async Task EditMessageCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new EditMessageCommandHandler(dbContextFixture.PostgresDbContext, MockedObjects.GetHubContext());
            var command = new EditMessageCommand
            {
                UserId = SeedDataConstants.SzymonId,
                MessageId = "664b168f-565c-4a94-b2f5-7b199bd1c364".AsGuid(),
                ModifiedText = "hello c#",
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
        }

        [Test]
        public async Task EditMessageCommandHandlerTest_ShouldThrowMessageNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new EditMessageCommandHandler(dbContextFixture.PostgresDbContext, MockedObjects.GetHubContext());
            var command = new EditMessageCommand
            {
                UserId = SeedDataConstants.SzymonId,
                MessageId = Guid.NewGuid(),
                ModifiedText = "hello c#",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.MessageNotFound);
        }

        [Test]
        public async Task EditMessageCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new EditMessageCommandHandler(dbContextFixture.PostgresDbContext, MockedObjects.GetHubContext());
            var command = new EditMessageCommand
            {
                UserId = Guid.NewGuid(),
                MessageId = Guid.NewGuid(),
                ModifiedText = "hello c#",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }
    }
}