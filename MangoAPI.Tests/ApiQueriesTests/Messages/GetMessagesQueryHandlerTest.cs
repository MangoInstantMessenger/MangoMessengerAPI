using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Messages;
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
            response.Error.Should().BeNull();
        }

        // [Test]
        // public async Task GetMessagesQueryHandlerTest_ShouldThrowPermissionDenied()
        // {
        //     using var dbContextFixture = new DbContextFixture();
        //     var handler = new GetMessagesQueryHandler(dbContextFixture.PostgresDbContext);
        //     var query = new GetMessagesQuery
        //     {
        //         UserId = SeedDataConstants.RazumovskyId, 
        //         ChatId = SeedDataConstants.DirectPetroSzymon
        //     };
        //
        //     var result = await handler.Handle(query, CancellationToken.None);
        //
        //     result.Error.Success.Should().BeFalse();
        //     result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.PermissionDenied);
        //     result.Response.Should().BeNull();
        // }
    }
}
