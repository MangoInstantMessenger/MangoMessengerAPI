using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Chats;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiQueriesTests.Chats
{
    [TestFixture]
    public class GetChatByIdQueryHandlerTests
    {
        [Test]
        public async Task GetChatByIdQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetChatByIdQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetChatByIdQuery
            {
                UserId = "1",
                ChatId = "1"
            };

            var result = await handler.Handle(query, CancellationToken.None);

            result.Success.Should().BeTrue();
            result.Chat.Should().NotBeNull();
        }

        [Test]
        public async Task GetChatByIdQueryHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetChatByIdQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetChatByIdQuery
            {
                UserId = "24",
                ChatId = "1"
            };

            Func<Task> result = async () => await handler.Handle(query, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }
        
        [Test]
        public async Task GetChatByIdQueryHandlerTest_ShouldThrowChatNotFound1()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetChatByIdQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetChatByIdQuery
            {
                UserId = "1",
                ChatId = "15"
            };

            Func<Task> result = async () => await handler.Handle(query, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.ChatNotFound);
        }
        
        [Test]
        public async Task GetChatByIdQueryHandlerTest_ShouldThrowChatNotFound2()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetChatByIdQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetChatByIdQuery
            {
                UserId = "1",
                ChatId = "5"
            };

            Func<Task> result = async () => await handler.Handle(query, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.ChatNotFound);
        }
        
        [Test]
        public async Task GetChatByIdQueryHandlerTest_ShouldThrowChatNotFound3()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetChatByIdQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetChatByIdQuery
            {
                UserId = "1",
                ChatId = "2"
            };

            Func<Task> result = async () => await handler.Handle(query, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.ChatNotFound);
        }
    }
}