using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Contacts;
using MangoAPI.Domain.Constants;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Tests.ApiQueriesTests.Contacts
{
    [TestFixture]
    public class GetContactsQueryHandlerTest
    {
        [Test]
        public async Task GetContactsQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetContactsQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetContactsQuery
            {
                UserId = SeedDataConstants.RazumovskyId
            };

            var response = await handler.Handle(query, CancellationToken.None);

            response.Success.Should().BeTrue();
            response.Contacts.Should().NotBeEmpty();
        }
    }
}