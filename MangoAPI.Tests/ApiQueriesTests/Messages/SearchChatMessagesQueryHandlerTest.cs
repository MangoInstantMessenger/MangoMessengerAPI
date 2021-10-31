using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Messages;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiQueriesTests.Messages
{
    [TestFixture]
    public class SearchChatMessagesQueryHandlerTest
    {
        [Test]
        public async Task SearchChatMessagesQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var responseFactory = new ResponseFactory<SearchChatMessagesResponse>();
            var handler = new SearchChatMessageQueryHandler(dbContextFixture.PostgresDbContext, responseFactory);
            var query = new SearchChatMessagesQuery
            {
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.ExtremeCodeFloodId,
                MessageText = "hello"
            };

            var result = await handler.Handle(query, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
            result.Response.Messages.Should().NotBeNull();
        }

        [Test]
        public async Task SearchChatMessagesQueryHandlerTest_ShouldThrowPermissionDenied()
        {
            using var dbContextFixture = new DbContextFixture();
            var responseFactory = new ResponseFactory<SearchChatMessagesResponse>();
            var handler = new SearchChatMessageQueryHandler(dbContextFixture.PostgresDbContext, responseFactory);
            var query = new SearchChatMessagesQuery
            {
                UserId = SeedDataConstants.KhachaturId,
                ChatId = SeedDataConstants.WsbId,
                MessageText = "hello"
            };

            var result = await handler.Handle(query, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.PermissionDenied);
            result.Response.Should().BeNull();
        }
    }
}