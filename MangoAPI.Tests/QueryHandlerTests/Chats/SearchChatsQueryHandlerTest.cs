using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Chats;
using NUnit.Framework;

namespace MangoAPI.Tests.QueryHandlerTests.Chats
{
    [TestFixture]
    public class SearchChatsQueryHandlerTest
    {
        [Test]
        public async Task SearchChatsQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new SearchChatsCommandHandler(dbContextFixture.PostgresDbContext);
            var query = new SearchChatsCommand
            {
                UserId = "1",
                DisplayName = "Extreme"
            };

            var response = await handler.Handle(query, CancellationToken.None);

            response.Success.Should().BeTrue();
            response.Chats.Should().NotBeEmpty();
        }
    }
}