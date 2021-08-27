namespace MangoAPI.Tests.ApiQueriesTests.Users
{
    using System.Threading;
    using System.Threading.Tasks;
    using FluentAssertions;
    using MangoAPI.BusinessLogic.ApiQueries.Users;
    using NUnit.Framework;

    [TestFixture]
    public class UserSearchCommandHandlerTest
    {
        [Test]
        public async Task UserSearchQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new SearchUserByDisplayNameQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new SearchUserByDisplayNameQuery() { DisplayName = "Petro" };

            var response = await handler.Handle(query, CancellationToken.None);

            response.Success.Should().BeTrue();
        }
    }
}
