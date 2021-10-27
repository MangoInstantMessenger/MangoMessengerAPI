using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Users;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiQueriesTests.Users
{
    [TestFixture]
    public class GetUserQueryHandlerTest
    {
        [Test]
        public async Task GetUserQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetUserQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetUserQuery
            {
                UserId = SeedDataConstants.RazumovskyId
            };

            var response = await handler.Handle(query, CancellationToken.None);

            response.Response.Success.Should().BeTrue();
        }

        [Test]
        public async Task GetUserQueryHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetUserQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetUserQuery
            {
                UserId = Guid.NewGuid()
            };

            var result = await handler.Handle(query, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.UserNotFound);
            result.Response.Should().BeNull();
        }
    }
}
