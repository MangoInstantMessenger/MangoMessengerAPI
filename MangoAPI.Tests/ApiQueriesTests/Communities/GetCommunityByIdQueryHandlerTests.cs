using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Communities;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.Domain.Constants;
using NUnit.Framework;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Tests.ApiQueriesTests.Communities
{
    [TestFixture]
    public class GetCommunityByIdQueryHandlerTests
    {
        [Test]
        public async Task GetChatByIdQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetCommunityByIdQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetCommunityByIdQuery
            {
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.ExtremeCodeFloodId
            };

            var result = await handler.Handle(query, CancellationToken.None);

            result.Success.Should().BeTrue();
            result.Chat.Should().NotBeNull();
        }

        [Test]
        public async Task GetChatByIdQueryHandlerTest_ShouldThrowChatNotFound1()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetCommunityByIdQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetCommunityByIdQuery
            {
                UserId = SeedDataConstants.SzymonId,
                ChatId = new Guid()
            };

            Func<Task> result = async () => await handler.Handle(query, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.ChatNotFound);
        }

        [Test]
        public async Task GetChatByIdQueryHandlerTest_ShouldThrowChatNotFound2()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetCommunityByIdQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetCommunityByIdQuery
            {
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.DirectAmelitRazumovsky
            };

            Func<Task> result = async () => await handler.Handle(query, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.ChatNotFound);
        }

        [Test]
        public async Task GetChatByIdQueryHandlerTest_ShouldThrowChatNotFound3()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new GetCommunityByIdQueryHandler(dbContextFixture.PostgresDbContext);
            var query = new GetCommunityByIdQuery
            {
                UserId = SeedDataConstants.SzymonId,
                ChatId = SeedDataConstants.ExtremeCodeCppId
            };

            Func<Task> result = async () => await handler.Handle(query, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.ChatNotFound);
        }
    }
}