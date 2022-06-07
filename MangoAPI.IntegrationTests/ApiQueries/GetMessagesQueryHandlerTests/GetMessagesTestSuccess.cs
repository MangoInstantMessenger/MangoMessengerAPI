using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Messages;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetMessagesQueryHandlerTests;

public class GetMessagesTestSuccess : IntegrationTestBase
{
    private readonly Assert<GetMessagesResponse> _assert = new();

    [Fact]
    public async Task GetMessagesTest_Success()
    {
        var user = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var chat = await MangoModule.RequestAsync(
            request: CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.UserId),
            cancellationToken: CancellationToken.None);
        await MangoModule.RequestAsync(
            request: CommandHelper.SendMessageToChannelCommand(user.Response.UserId, chat.Response.ChatId),
            cancellationToken: CancellationToken.None);
        await MangoModule.RequestAsync(
            request: CommandHelper.SendMessageToChannelCommand(user.Response.UserId, chat.Response.ChatId),
            cancellationToken: CancellationToken.None);
        var query = new GetMessagesQuery
        {
            UserId = user.Response.UserId,
            ChatId = chat.Response.ChatId
        };

        var result = await MangoModule.RequestAsync(query, CancellationToken.None);
            
        _assert.Pass(result);
        result.Response.Messages.Count.Should().Be(2);
    }
}