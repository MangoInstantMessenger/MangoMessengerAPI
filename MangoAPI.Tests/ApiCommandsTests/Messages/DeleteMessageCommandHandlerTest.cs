using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.Messages
{
    [TestFixture]
    public class DeleteMessageCommandHandlerTest
    {
        [Test]
        public async Task DeleteMessageCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new DeleteMessageCommandHandler(dbContextFixture.PostgresDbContext, MockedObjects.GetHubContext());
            var command = new DeleteMessageCommand
            {
                UserId = SeedDataConstants.SzymonId,
                MessageId = "664b168f-565c-4a94-b2f5-7b199bd1c364".AsGuid(),
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
        }

        [Test]
        public async Task DeleteMessageCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new DeleteMessageCommandHandler(dbContextFixture.PostgresDbContext, MockedObjects.GetHubContext());
            var command = new DeleteMessageCommand
            {
                UserId = Guid.NewGuid(),
                MessageId = Guid.NewGuid(),
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }

        [Test]
        public async Task DeleteMessageCommandHandlerTest_ShouldThrowMessageNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new DeleteMessageCommandHandler(dbContextFixture.PostgresDbContext, MockedObjects.GetHubContext());
            var command = new DeleteMessageCommand
            {
                UserId = SeedDataConstants.SzymonId,
                MessageId = Guid.NewGuid(),
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.MessageNotFound);
        }
    }
}
