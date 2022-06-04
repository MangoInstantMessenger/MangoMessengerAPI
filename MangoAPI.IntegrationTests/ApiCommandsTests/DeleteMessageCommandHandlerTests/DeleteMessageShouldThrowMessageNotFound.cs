using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.DeleteMessageCommandHandlerTests;

public class DeleteMessageShouldThrowMessageNotFound : IntegrationTestBase
{
    private readonly Assert<DeleteMessageResponse> _assert = new();

    [Fact]
    public async Task DeleteMessageTestShouldThrow_MessageNotFound()
    {
        const string expectedMessage = ResponseMessageCodes.MessageNotFound;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var user =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var chat =
            await MangoModule.RequestAsync(
                request: CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.UserId), 
                cancellationToken: CancellationToken.None);
        var command = new DeleteMessageCommand
        {
            UserId = user.Response.UserId,
            ChatId = chat.Response.ChatId,
            MessageId = Guid.NewGuid()
        };

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    }
}