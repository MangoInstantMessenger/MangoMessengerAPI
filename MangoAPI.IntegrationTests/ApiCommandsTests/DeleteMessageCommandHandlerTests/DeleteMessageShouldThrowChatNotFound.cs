using MangoAPI.BusinessLogic;
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
    private readonly Assert<DeleteMessageResponse> assert = new();

    [Fact]
    public async Task DeleteMessageShouldThrowChatNotFoundAsync()
    {
        const string expectedMessage = ResponseMessageCodes.ChatNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var user =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var chat =
            await MangoModule.RequestAsync(
                CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.Tokens.UserId),
                CancellationToken.None);
        var message =
            await MangoModule.RequestAsync(
                CommandHelper.SendMessageToChannelCommand(user.Response.Tokens.UserId, chat.Response.ChatId),
                CancellationToken.None);
        var command = new DeleteMessageCommand(
            user.Response.Tokens.UserId,
            Guid.NewGuid(),
            message.Response.NewMessageId);

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}