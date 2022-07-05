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
    public async Task EditMessageCommandHandlerTest_ShouldThrow_ChatNotFound()
    {
        const string expectedMessage = ResponseMessageCodes.ChatNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
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
        var command = new EditMessageCommand(
            ChatId: Guid.Empty,
            UserId: user.Response.UserId,
            MessageId: message.Response.MessageId,
            ModifiedText: "Message edited");

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
