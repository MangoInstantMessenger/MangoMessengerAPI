using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.IntegrationTests.Helpers;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.SendMessageCommandHandlerTests;

public class SendMessageSuccessTest : IntegrationTestBase
{
    private readonly Assert<SendMessageResponse> assert = new();

    [Fact]
    public async Task SendMessageNoAttachmentTestSuccessAsync()
    {
        var petroCommand = CommandHelper.RegisterPetroCommand();
        var petroResult = await MangoModule.RequestAsync(petroCommand, CancellationToken.None);
        var chatCommand = CommandHelper.CreateExtremeCodeMainChatCommand(petroResult.Response.Tokens.UserId);
        var chatResult = await MangoModule.RequestAsync(chatCommand, CancellationToken.None);
        var petroId = petroResult.Response.Tokens.UserId;
        var sendCommand = CommandHelper.SendMessageToChannelCommand(petroId, chatResult.Response.ChatId);

        var result = await MangoModule.RequestAsync(sendCommand, CancellationToken.None);
        var messageEntity = await DbContextFixture.Messages
            .Include(x => x.User)
            .Include(x => x.Chat)
            .FirstAsync(x => x.Id == result.Response.NewMessageId);

        assert.Pass(result);
        var chatEntity = messageEntity.Chat;
        var userEntity = messageEntity.User;
        chatEntity.LastMessageAuthor.Should().Be(userEntity.DisplayName);
        chatEntity.LastMessageId.Should().Be(messageEntity.Id);
        chatEntity.LastMessageText.Should().Be(messageEntity.Text);
        chatEntity.LastMessageTime.Should().Be(messageEntity.CreatedAt);
    }

    [Fact]
    public async Task SendMessageWithAttachmentTestSuccessAsync()
    {
        var petroCommand = CommandHelper.RegisterPetroCommand();
        var petroResult = await MangoModule.RequestAsync(petroCommand, CancellationToken.None);
        var chatCommand = CommandHelper.CreateExtremeCodeMainChatCommand(petroResult.Response.Tokens.UserId);
        var chatResult = await MangoModule.RequestAsync(chatCommand, CancellationToken.None);
        var petroId = petroResult.Response.Tokens.UserId;
        var file = MangoFilesHelper.GetTestImage();
        var sendCommand = CommandHelper.SendMessageToChannelCommand(petroId, chatResult.Response.ChatId, file);

        var result = await MangoModule.RequestAsync(sendCommand, CancellationToken.None);
        var messageEntity = await DbContextFixture.Messages
            .Include(x => x.User)
            .Include(x => x.Chat)
            .FirstAsync(x => x.Id == result.Response.NewMessageId);

        assert.Pass(result);
        var chatEntity = messageEntity.Chat;
        var userEntity = messageEntity.User;
        chatEntity.LastMessageAuthor.Should().Be(userEntity.DisplayName);
        chatEntity.LastMessageId.Should().Be(messageEntity.Id);
        chatEntity.LastMessageText.Should().Be(messageEntity.Text);
        chatEntity.LastMessageTime.Should().Be(messageEntity.CreatedAt);
    }
}