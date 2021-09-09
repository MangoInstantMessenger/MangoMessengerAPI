using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Chats;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiQueriesTests.Chats
{
    [TestFixture]
    public class SearchChatsCommandHandlerTest
    {
        [Test]
        public async Task SearchChatsQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new SearchChatsQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new SearchChatsQuery
            {
                UserId = SeedDataConstants.RazumovskyId,
                DisplayName = "Extreme",
            };

            var response = await handler.Handle(query, CancellationToken.None);

            response.Success.Should().BeTrue();
            response.Chats.Should().NotBeEmpty();
        }
    }
}