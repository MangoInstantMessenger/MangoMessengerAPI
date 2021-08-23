namespace MangoAPI.Tests.ApiCommandsTests.Chats
{
    using System.Threading;
    using System.Threading.Tasks;
    using FluentAssertions;
    using MangoAPI.BusinessLogic.ApiCommands.Chats;
    using NUnit.Framework;

    [TestFixture]
    public class SearchChatsCommandHandlerTest
    {
        [Test]
        public async Task SearchChatsQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new SearchChatsQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new SearchChatsQuery
            {
                UserId = "1",
                DisplayName = "Extreme",
            };

            var response = await handler.Handle(query, CancellationToken.None);

            response.Success.Should().BeTrue();
            response.Chats.Should().NotBeEmpty();
        }
    }
}
