using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.DeleteMessageCommandHandlerTests;

public class DeleteMessageShouldThrowChatNotFound : IntegrationTestBase
{
    private readonly Assert<DeleteMessageResponse> _assert = new();

    [Fact]
    public async Task DeleteMessageShouldThrow_ChatNotFound()
    {
        const string expectedMessage = ResponseMessageCodes.ChatNotFound;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var user =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var chat =
            await MangoModule.RequestAsync(
                request: CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.UserId), 
                cancellationToken: CancellationToken.None);
        var message =
            await MangoModule.RequestAsync(
                request: CommandHelper.SendMessageToChannelCommand(user.Response.UserId, chat.Response.ChatId), 
                cancellationToken: CancellationToken.None);
        var command = new DeleteMessageCommand
        {
            UserId = user.Response.UserId,
            ChatId = Guid.NewGuid(),
            MessageId = message.Response.MessageId
        };

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    }
}