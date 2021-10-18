using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using Microsoft.AspNetCore.SignalR;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Tests.ApiCommandsTests.Communities
{
    [TestFixture]
    public class CreateChannelCommandHandlerTest
    {
        private static readonly IHubContext<ChatHub, IHubClient> Hub = MockedObjects.GetHubContext();

        [Test]
        public async Task CreateGroupCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new CreateChannelCommandHandler(dbContextFixture.PostgresDbContext, Hub);
            var command = new CreateChannelCommand
            {
                UserId = SeedDataConstants.PetroId,
                CommunityType = CommunityType.PublicChannel,
                ChannelTitle = "Extreme Code",
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
        }
    }
}