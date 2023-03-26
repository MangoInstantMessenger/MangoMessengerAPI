using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic;
using MangoAPI.BusinessLogic.ApiQueries.Messages;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetMessagesQueryHandlerTests;

public class GetMessagesTestSuccess : IntegrationTestBase
{
    private readonly Assert<GetMessagesResponse> assert = new();

    [Fact]
    public async Task GetMessagesTestSuccessAsync()
    {
        var user = await MangoModule.RequestAsync(
            CommandHelper.RegisterPetroCommand(),
            CancellationToken.None);
        var chat = await MangoModule.RequestAsync(
            CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.Tokens.UserId),
            CancellationToken.None);
        await MangoModule.RequestAsync(
            CommandHelper.SendMessageToChannelCommand(user.Response.Tokens.UserId, chat.Response.ChatId),
            CancellationToken.None);
        await MangoModule.RequestAsync(
            CommandHelper.SendMessageToChannelCommand(user.Response.Tokens.UserId, chat.Response.ChatId),
            CancellationToken.None);
        var query = new GetMessagesQuery(user.Response.Tokens.UserId, chat.Response.ChatId);

        var result = await MangoModule.RequestAsync(query, CancellationToken.None);

        assert.Pass(result);
        result.Response.Messages.Count.Should().Be(2);
    }
}