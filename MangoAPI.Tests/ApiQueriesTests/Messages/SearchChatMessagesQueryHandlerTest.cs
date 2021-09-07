﻿using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Messages;
using MangoAPI.BusinessLogic.BusinessExceptions;
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
                UserId = "1",
                ChatId = "2",
                MessageText = "hello"
            };

            var result = await handler.Handle(query, CancellationToken.None);

            result.Success.Should().BeTrue();
            result.Messages.Should().NotBeNull();
        }
        
        [Test]
        public async Task SearchChatMessagesQueryHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new SearchChatMessageQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new SearchChatMessagesQuery
            {
                UserId = "14",
                ChatId = "2",
                MessageText = "hello"
            };

            Func<Task> result = async () => await handler.Handle(query, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>();
        }
    }
}