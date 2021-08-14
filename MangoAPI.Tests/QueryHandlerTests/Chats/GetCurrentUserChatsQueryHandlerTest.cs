using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Users;
using MangoAPI.BusinessLogic.ApiQueryHandlers.Chats;
using NUnit.Framework;

namespace MangoAPI.Tests.QueryHandlerTests.Chats
{
    [TestFixture]
    public class GetCurrentUserChatsQueryHandlerTest : TestBase
    {
        [Test]
        public async Task GetCurrentUserChatsQueryHandler_200Test()
        {
            var query = new GetCurrentUserChatsQuery {UserId = "1"};
            var handler = new GetCurrentUserChatsQueryHandler(PostgresDbContext);
            
            var response = await handler.Handle(query, CancellationToken.None);

            response.Success.Should().BeTrue();
            response.Chats.Should().HaveCount(0);
        }
    }
}