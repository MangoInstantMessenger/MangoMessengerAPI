using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.IntegrationTests.Helpers;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.EditMessageCommandHandlerTests;

public class EditMessageSuccess : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task EditMessageHandlerTestSuccessAsync()
    {
        var user =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var chat =
            await MangoModule.RequestAsync(
                request: CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.Tokens.UserId),
                cancellationToken: CancellationToken.None);
        var message =
            await MangoModule.RequestAsync(
                request: CommandHelper.SendMessageToChannelCommand(user.Response.Tokens.UserId, chat.Response.ChatId),
                cancellationToken: CancellationToken.None);
        var command = new EditMessageCommand(
            ChatId: chat.Response.ChatId,
            UserId: user.Response.Tokens.UserId,
            MessageId: message.Response.MessageId,
            ModifiedText: "Message edited");

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);
        var editedMessage =
            await DbContextFixture.Messages.FirstAsync(x => x.Id == message.Response.MessageId);

        assert.Pass(result);
        editedMessage.Content.Should().Be(command.ModifiedText);
    }
}
