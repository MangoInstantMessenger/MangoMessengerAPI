using MangoAPI.BusinessLogic;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.DeleteMessageCommandHandlerTests;

public class DeleteMessageTestSuccess : IntegrationTestBase
{
    private readonly Assert<DeleteMessageResponse> assert = new();

    [Fact]
    public async Task DeleteMessageTestSuccessAsync()
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
        var command = new DeleteMessageCommand(
            UserId: user.Response.Tokens.UserId,
            ChatId: chat.Response.ChatId,
            MessageId: message.Response.MessageId);

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Pass(result);
    }
}
