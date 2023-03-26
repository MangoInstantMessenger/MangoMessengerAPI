using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic;
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
        var user =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var chat =
            await MangoModule.RequestAsync(
                CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.Tokens.UserId),
                CancellationToken.None);
        await MangoModule.RequestAsync(
            CommandHelper.SendMessageToChannelCommand(user.Response.Tokens.UserId, chat.Response.ChatId),
            CancellationToken.None);
        var query = new SearchChatMessagesQuery(
            user.Response.Tokens.UserId,
            chat.Response.ChatId,
            "test");

        var result = await MangoModule.RequestAsync(query, CancellationToken.None);

        assert.Pass(result);
        result.Response.Messages.Count.Should().Be(1);
    }
}