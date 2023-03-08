using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Communities;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetCurrentUserChatsQueryHandlerTests;

public class GetCurrentUserChatsTestSuccess : IntegrationTestBase
{
    private readonly Assert<GetCurrentUserChatsResponse> assert = new();

    [Fact]
    public async Task GetCurrentUserChatsTestSuccessAsync()
    {
        var user = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        await MangoModule.RequestAsync(
            request: CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.Tokens.UserId),
            cancellationToken: CancellationToken.None);
        var query = new GetCurrentUserChatsQuery(UserId: user.Response.Tokens.UserId);

        var result = await MangoModule.RequestAsync(query, CancellationToken.None);

        assert.Pass(result);
        result.Response.Chats.Count.Should().Be(2);
    }
}
