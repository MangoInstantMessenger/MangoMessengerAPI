using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Messages;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.SearchChatMessageQueryHandlerTests;

public class SearchChatMessageTestSuccess : IntegrationTestBase
{
    private readonly Assert<SearchChatMessagesResponse> assert = new();

    [Fact]
    public async Task SearchChatMessageTest_Success()
    {
        var user =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var chat =
            await MangoModule.RequestAsync(
                request: CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.UserId),
                cancellationToken: CancellationToken.None);
        await MangoModule.RequestAsync(
            request: CommandHelper.SendMessageToChannelCommand(user.Response.UserId, chat.Response.ChatId),
            cancellationToken: CancellationToken.None);
        var query = new SearchChatMessagesQuery(
            UserId: user.Response.UserId,
            ChatId: chat.Response.ChatId,
            MessageText: "test");

        var result = await MangoModule.RequestAsync(query, CancellationToken.None);

        assert.Pass(result);
        result.Response.Messages.Count.Should().Be(1);
    }
}
