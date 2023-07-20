using FluentAssertions;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.Users;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetUserQueryHandlerTests;

public class GetUserQuerySuccess : IntegrationTestBase
{
    private readonly Assert<GetUserResponse> assert = new();

    [Fact]
    public async Task GetUserTestSuccessAsync()
    {
        var user = await RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var query = new GetUserQuery(UserId: user.Response.Tokens.UserId);

        var result = await RequestAsync(query, CancellationToken.None);

        assert.Pass(result);
        result.Response.User.UserId.Should().Be(user.Response.Tokens.UserId);
    }
}
