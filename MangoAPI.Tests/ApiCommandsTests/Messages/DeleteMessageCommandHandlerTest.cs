namespace MangoAPI.Tests.ApiCommandsTests.Messages
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using FluentAssertions;
    using MangoAPI.BusinessLogic.ApiCommands.Messages;
    using BusinessLogic.BusinessExceptions;
    using Domain.Constants;
    using NUnit.Framework;

    [TestFixture]
    public class DeleteMessageCommandHandlerTest
    {
        [Test]
        public async Task DeleteMessageCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new DeleteMessageCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new DeleteMessageCommand
            {
                UserId = "1",
                MessageId = "3",
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
        }

        [Test]
        public async Task DeleteMessageCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new DeleteMessageCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new DeleteMessageCommand
            {
                UserId = "4",
                MessageId = "3",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }

        [Test]
        public async Task DeleteMessageCommandHandlerTest_ShouldThrowMessageNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new DeleteMessageCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new DeleteMessageCommand
            {
                UserId = "2",
                MessageId = "21",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.MessageNotFound);
        }
    }
}
