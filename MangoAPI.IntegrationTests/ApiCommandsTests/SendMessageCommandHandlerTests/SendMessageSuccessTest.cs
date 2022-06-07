using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.IntegrationTests.Helpers;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.SendMessageCommandHandlerTests;

public class SendMessageSuccessTest : IntegrationTestBase
{
    private readonly Assert<SendMessageResponse> _assert = new();

    [Fact]
    public async Task SendMessage_Test_Success()
    {
        var user = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var chat = await MangoModule.RequestAsync(
            request: CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.UserId),
            cancellationToken: CancellationToken.None);

        var result = await MangoModule.RequestAsync(
            request: CommandHelper.SendMessageToChannelCommand(user.Response.UserId, chat.Response.ChatId),
            cancellationToken: CancellationToken.None);

        _assert.Pass(result);
        var messageEntity = await DbContextFixture.Messages
            .Include(x => x.User)
            .Include(x => x.Chat)
            .FirstAsync(x => x.Id == result.Response.MessageId);
        var chatEntity = messageEntity.Chat;
        var userEntity = messageEntity.User;
        chatEntity.LastMessageAuthor.Should().Be(userEntity.DisplayName);
        chatEntity.LastMessageId.Should().Be(messageEntity.Id);
        chatEntity.LastMessageText.Should().Be(messageEntity.Content);
        chatEntity.LastMessageTime.Should().Be(messageEntity.CreatedAt);
    }
}