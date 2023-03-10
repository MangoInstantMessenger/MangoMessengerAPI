using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic;
using MangoAPI.BusinessLogic.ApiQueries.Communities;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.SearchCommunityQueryHandlerTests;

public class SearchCommunityTestSuccess : IntegrationTestBase
{
    private readonly Assert<SearchCommunityResponse> assert = new();

    [Fact]
    public async Task SearchCommunityTestSuccessAsync()
    {
        var user =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var chat = await MangoModule.RequestAsync(
                request: CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.Tokens.UserId),
                cancellationToken: CancellationToken.None);
        var query = new SearchCommunityQuery(UserId: user.Response.Tokens.UserId, DisplayName: "Extreme");

        var result = await MangoModule.RequestAsync(query, CancellationToken.None);

        assert.Pass(result);
        result.Response.Chats.Count.Should().Be(1);
        result.Response.Chats[0].ChatId.Should().Be(chat.Response.ChatId);
    }
}
