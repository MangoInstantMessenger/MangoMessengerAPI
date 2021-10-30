using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Contacts;
using MangoAPI.Domain.Constants;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.Tests.ApiQueriesTests.Contacts
{
    [TestFixture]
    public class GetContactsQueryHandlerTest
    {
        [Test]
        public async Task GetContactsQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var responseFactory = new ResponseFactory<GetContactsResponse>();
            var handler = new GetContactsQueryHandler(dbContextFixture.PostgresDbContext, responseFactory);
            var query = new GetContactsQuery
            {
                UserId = SeedDataConstants.RazumovskyId
            };

            var response = await handler.Handle(query, CancellationToken.None);

            response.Response.Success.Should().BeTrue();
            response.Response.Contacts.Should().NotBeEmpty();
        }
    }
}