using MangoAPI.BusinessLogic;
using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.EditMessageCommandHandlerTests;

public class EditMessageShouldThrowChatNotFound : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task EditMessageCommandHandlerTestShouldThrowChatNotFoundAsync()
    {
        const string expectedMessage = ResponseMessageCodes.ChatNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var petroCommand = CommandHelper.RegisterPetroCommand();
            
        var petro = await MangoModule.RequestAsync(petroCommand, CancellationToken.None);
        var petroId = petro.Response.Tokens.UserId;
        var chatCommand = CommandHelper.CreateExtremeCodeMainChatCommand(petroId);
        var chat = await MangoModule.RequestAsync(chatCommand, CancellationToken.None);
        var sendMessageCommand = CommandHelper.SendMessageToChannelCommand(petroId, chat.Response.ChatId);
        var message = await MangoModule.RequestAsync(sendMessageCommand, CancellationToken.None);
        var command = new EditMessageCommand(
            ChatId: Guid.Empty,
            petroId,
            message.Response.MessageModel.MessageId,
            ModifiedText: "Message edited");

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
