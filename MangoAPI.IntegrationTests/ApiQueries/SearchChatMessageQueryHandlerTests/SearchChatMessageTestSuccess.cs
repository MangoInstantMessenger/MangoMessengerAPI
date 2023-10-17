using FluentAssertions;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.Messages;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.SearchChatMessageQueryHandlerTests;

public class SearchChatMessageTestSuccess : IntegrationTestBase
{
    private readonly Assert<SearchChatMessagesResponse> assert = new();

    [Fact]
    public async Task SearchChatMessageTestSuccessAsync()
    {
        var user = await RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var chat = await RequestAsync(
                request: CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.Tokens.UserId),
                cancellationToken: CancellationToken.None);
        await RequestAsync(
            request: CommandHelper.SendMessageToChannelCommand(user.Response.Tokens.UserId, chat.Response.ChatId),
            cancellationToken: CancellationToken.None);
        var query = new SearchChatMessagesQuery(
            UserId: user.Response.Tokens.UserId,
            ChatId: chat.Response.ChatId,
            MessageText: "test");

        var result = await RequestAsync(query, CancellationToken.None);

        assert.Pass(result);
        result.Response.Messages.Count.Should().Be(1);
    }
}
