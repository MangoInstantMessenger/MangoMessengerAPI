using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Contacts;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

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
            var query = new GetContactsQuery {UserId = "1"};

            var response = await handler.Handle(query, CancellationToken.None);

            response.Success.Should().BeTrue();
            response.Contacts.Should().NotBeEmpty();
        }

        [Test]
        public async Task GetContactsQueryHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetContactsQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetContactsQuery {UserId = "24"};

            Func<Task> response = async () => await handler.Handle(query, CancellationToken.None);

            await response.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }
    }
}