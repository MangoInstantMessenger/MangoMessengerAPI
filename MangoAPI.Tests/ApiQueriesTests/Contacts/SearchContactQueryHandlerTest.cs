using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Contacts;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiQueriesTests.Contacts
{
    [TestFixture]
    public class SearchContactQueryHandlerTest
    {
        [Test]
        public async Task UserSearchQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new SearchContactByDisplayNameQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new SearchContactQuery
            {
                SearchQuery = "Petro"
            };

            var response = await handler.Handle(query, CancellationToken.None);

            response.Response.Success.Should().BeTrue();
        }
    }
}
