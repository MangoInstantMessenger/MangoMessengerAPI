using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Users;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetUserQueryHandlerTests;

public class GetUserQuerySuccess : IntegrationTestBase
{
    private readonly Assert<GetUserResponse> _assert = new();

    [Fact]
    public async Task GetUserTest_Success()
    {
        var user =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var query = new GetUserQuery
        {
            UserId = user.Response.UserId
        };

        var result = await MangoModule.RequestAsync(query, CancellationToken.None);
            
        _assert.Pass(result);
        result.Response.User.UserId.Should().Be(user.Response.UserId);
    }
}