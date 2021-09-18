using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Communities;
using MangoAPI.Domain.Constants;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Tests.ApiQueriesTests.Communities
{
    [TestFixture]
    public class GetCurrentUserChatsQueryHandlerTest
    {
        [Test]
        public async Task GetCurrentUserChatsQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetCurrentUserChatsQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetCurrentUserChatsQuery
            {
                UserId = SeedDataConstants.RazumovskyId
            };

            var response = await handler.Handle(query, CancellationToken.None);

            response.Success.Should().BeTrue();
            response.Chats.Should().NotBeEmpty();
        }
    }
}