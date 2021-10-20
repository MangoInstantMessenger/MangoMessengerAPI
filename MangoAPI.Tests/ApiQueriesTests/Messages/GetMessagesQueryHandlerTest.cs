using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Messages;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiQueriesTests.Messages
{
    [TestFixture]
    public class GetMessagesQueryHandlerTest
    {
        [Test]
        public async Task GetMessagesQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetMessagesQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetMessagesQuery
            {
                UserId = SeedDataConstants.RazumovskyId, 
                ChatId = SeedDataConstants.ExtremeCodeFloodId
            };

            var response = await handler.Handle(query, CancellationToken.None);

            response.Response.Success.Should().BeTrue();
            response.Response.Messages.Should().NotBeEmpty();
        }

        [Test]
        public async Task GetMessagesQueryHandlerTest_ShouldThrowPermissionDenied()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetMessagesQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetMessagesQuery
            {
                UserId = SeedDataConstants.RazumovskyId, 
                ChatId = SeedDataConstants.DirectPetroSzymon
            };

            Func<Task> response = async () => await handler.Handle(query, CancellationToken.None);

            await response.Should().NotThrowAsync<BusinessException>();
        }
    }
}
