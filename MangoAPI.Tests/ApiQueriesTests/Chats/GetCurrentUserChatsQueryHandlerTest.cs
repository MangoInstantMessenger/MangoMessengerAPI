namespace MangoAPI.Tests.ApiQueriesTests.Chats
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using FluentAssertions;
    using MangoAPI.BusinessLogic.ApiQueries.Chats;
    using MangoAPI.BusinessLogic.BusinessExceptions;
    using MangoAPI.Domain.Constants;
    using NUnit.Framework;

    [TestFixture]
    public class GetCurrentUserChatsQueryHandlerTest
    {
        [Test]
        public async Task GetCurrentUserChatsQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetCurrentUserChatsQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetCurrentUserChatsQuery { UserId = "1" };

            var response = await handler.Handle(query, CancellationToken.None);

            response.Success.Should().BeTrue();
            response.Chats.Should().NotBeEmpty();
        }

        [Test]
        public async Task GetCurrentUserChatsQueryHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetCurrentUserChatsQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetCurrentUserChatsQuery { UserId = "24" };

            Func<Task> response = async () => await handler.Handle(query, CancellationToken.None);

            await response.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }
    }
}
