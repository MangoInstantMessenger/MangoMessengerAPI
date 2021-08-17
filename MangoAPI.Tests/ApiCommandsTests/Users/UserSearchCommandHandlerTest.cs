using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.Users
{
    [TestFixture]
    public class UserSearchCommandHandlerTest
    {
        [Test]
        public async Task UserSearchQueryHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new UserSearchCommandHandler(dbContextFixture.PostgresDbContext);
            var query = new UserSearchCommand {DisplayName = "Petro"};

            var response = await handler.Handle(query, CancellationToken.None);

            response.Success.Should().BeTrue();
        }
    }
}