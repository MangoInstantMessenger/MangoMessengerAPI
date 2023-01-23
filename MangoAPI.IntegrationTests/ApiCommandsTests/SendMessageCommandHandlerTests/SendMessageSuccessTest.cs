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
    private readonly Assert<SendMessageResponse> assert = new();

    [Fact]
    public async Task SendMessageTestSuccessAsync()
    {
        var user = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var chat = await MangoModule.RequestAsync(
            request: CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.Tokens.UserId),
            cancellationToken: CancellationToken.None);

        var result = await MangoModule.RequestAsync(
            request: CommandHelper.SendMessageToChannelCommand(user.Response.Tokens.UserId, chat.Response.ChatId),
            cancellationToken: CancellationToken.None);

        assert.Pass(result);
        var messageEntity = await DbContextFixture.Messages
            .Include(x => x.User)
            .Include(x => x.Chat)
            .FirstAsync(x => x.Id == result.Response.MessageId);
        var chatEntity = messageEntity.Chat;
        var userEntity = messageEntity.User;
        _ = chatEntity.LastMessageAuthor.Should().Be(userEntity.DisplayName);
        _ = chatEntity.LastMessageId.Should().Be(messageEntity.Id);
        _ = chatEntity.LastMessageText.Should().Be(messageEntity.Content);
        _ = chatEntity.LastMessageTime.Should().Be(messageEntity.CreatedAt);
    }
}
