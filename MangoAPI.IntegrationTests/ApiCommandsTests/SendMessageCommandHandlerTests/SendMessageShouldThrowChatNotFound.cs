﻿using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.SendMessageCommandHandlerTests;

public class SendMessageShouldThrowChatNotFound : IntegrationTestBase
{
    private readonly Assert<SendMessageResponse> assert = new();

    [Fact]
    public async Task SendMessageShouldThrowChatNotFoundAsync()
    {
        const string expectedMessage = ResponseMessageCodes.ChatNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];

        var petroCommand = CommandHelper.RegisterPetroCommand();

        var user = await RequestAsync(petroCommand, CancellationToken.None);
        var chatId = Guid.NewGuid();
        var sendCommand = CommandHelper.SendMessageToChannelCommand(user.Response.Tokens.UserId, chatId);

        var result = await RequestAsync(sendCommand, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}