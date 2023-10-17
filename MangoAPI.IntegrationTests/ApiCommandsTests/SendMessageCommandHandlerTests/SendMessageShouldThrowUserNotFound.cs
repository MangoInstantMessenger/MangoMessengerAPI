using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.SendMessageCommandHandlerTests;

public class SendMessageShouldThrowUserNotFound : IntegrationTestBase
{
    private readonly Assert<SendMessageResponse> assert = new();

    [Fact]
    public async Task SendMessageShouldThrowUserNotFoundAsync()
    {
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];

        var petroCommand = CommandHelper.RegisterPetroCommand();
        var petroResult = await RequestAsync(petroCommand, CancellationToken.None);
        var chatCommand = CommandHelper.CreateExtremeCodeMainChatCommand(petroResult.Response.Tokens.UserId);
        var chatResult = await RequestAsync(chatCommand, CancellationToken.None);

        var sendCommand = CommandHelper.SendMessageToChannelCommand(userId: Guid.NewGuid(), chatResult.Response.ChatId);
        var result = await RequestAsync(sendCommand, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}