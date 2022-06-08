using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Communities;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetCurrentUserChatsQueryHandlerTests;

public class GetCurrentUserChatsTestSuccess : IntegrationTestBase
{
    private readonly Assert<GetCurrentUserChatsResponse> _assert = new();

    [Fact]
    public async Task GetCurrentUserChatsTest_Success()
    {
        var user = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        await MangoModule.RequestAsync(
            request: CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.UserId),
            cancellationToken: CancellationToken.None);
        var query = new GetCurrentUserChatsQuery(UserId: user.Response.UserId);

        var result = await MangoModule.RequestAsync(query, CancellationToken.None);

        _assert.Pass(result);
        result.Response.Chats.Count.Should().Be(1);
    }
}