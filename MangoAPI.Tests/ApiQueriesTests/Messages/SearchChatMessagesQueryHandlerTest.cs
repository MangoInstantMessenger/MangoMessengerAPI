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
    public class SearchChatMessagesQueryHandlerTest
    {
        [Test]
        public async Task SearchChatMessagesQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new SearchChatMessageQueryHandler(dbContextFixture.PostgresDbContext);
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
            var handler = new SearchChatMessageQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new SearchChatMessagesQuery
            {
                UserId = SeedDataConstants.KhachaturId,
                ChatId = SeedDataConstants.WsbId,
                MessageText = "hello"
            };

            Func<Task> result = async () => await handler.Handle(query, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.PermissionDenied);
            
        }
    }
}