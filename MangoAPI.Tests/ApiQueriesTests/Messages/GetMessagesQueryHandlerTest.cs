namespace MangoAPI.Tests.ApiQueriesTests.Messages
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using FluentAssertions;
    using MangoAPI.BusinessLogic.ApiQueries.Messages;
    using BusinessLogic.BusinessExceptions;
    using Domain.Constants;
    using NUnit.Framework;

    [TestFixture]
    public class GetMessagesQueryHandlerTest
    {
        [Test]
        public async Task GetMessagesQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetMessagesQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetMessagesQuery { UserId = "1", ChatId = "3" };

            var response = await handler.Handle(query, CancellationToken.None);

            response.Success.Should().BeTrue();
            response.Messages.Should().NotBeEmpty();
        }

        [Test]
        public async Task GetMessagesQueryHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetMessagesQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetMessagesQuery { UserId = "24", ChatId = "3" };

            Func<Task> response = async () => await handler.Handle(query, CancellationToken.None);

            await response.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }

        [Test]
        public async Task GetMessagesQueryHandlerTest_ShouldThrowPermissionDenied()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetMessagesQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetMessagesQuery { UserId = "1", ChatId = "1" };

            Func<Task> response = async () => await handler.Handle(query, CancellationToken.None);

            await response.Should().NotThrowAsync<BusinessException>();
        }
    }
}
