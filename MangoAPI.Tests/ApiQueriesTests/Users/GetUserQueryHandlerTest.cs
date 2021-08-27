namespace MangoAPI.Tests.ApiQueriesTests.Users
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using FluentAssertions;
    using MangoAPI.BusinessLogic.ApiQueries.Users;
    using BusinessLogic.BusinessExceptions;
    using Domain.Constants;
    using NUnit.Framework;

    [TestFixture]
    public class GetUserQueryHandlerTest
    {
        [Test]
        public async Task GetUserQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetUserQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetUserQuery { UserId = "2" };

            var response = await handler.Handle(query, CancellationToken.None);

            response.Success.Should().BeTrue();
        }

        [Test]
        public async Task GetUserQueryHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetUserQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetUserQuery { UserId = "24" };

            Func<Task> response = async () => await handler.Handle(query, CancellationToken.None);

            await response.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }
    }
}
