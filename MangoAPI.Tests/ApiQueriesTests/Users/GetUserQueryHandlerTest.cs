using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Users;
using MangoAPI.BusinessLogic.BusinessExceptions;
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

            response.Success.Should().BeTrue();
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

            Func<Task> response = async () => await handler.Handle(query, CancellationToken.None);

            await response.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }
    }
}
