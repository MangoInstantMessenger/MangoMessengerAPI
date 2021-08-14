using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Users;
using MangoAPI.BusinessLogic.ApiQueryHandlers.Chats;
using NUnit.Framework;

namespace MangoAPI.Tests.QueryHandlerTests.Chats
{
    [TestFixture]
    public class GetCurrentUserChatsQueryHandlerTest
    {
        [Test]
        public async Task GetCurrentUserChatsQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var query = new GetCurrentUserChatsQuery {UserId = "1"};
            var handler = new GetCurrentUserChatsQueryHandler(dbContextFixture.PostgresDbContext);
            
            var response = await handler.Handle(query, CancellationToken.None);

            response.Success.Should().BeTrue();
            response.Chats.Should().NotBeEmpty();
        }
        
        [Test]
        public async Task GetCurrentUserChatsQueryHandlerTest_ShouldThrowUserNotFound()
        {
            throw new NotImplementedException();
        }
    }
}