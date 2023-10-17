﻿using System.Threading;
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
        var petroCommand = CommandHelper.RegisterPetroCommand();
        var petroResult = await RequestAsync(petroCommand, CancellationToken.None);
        var chatCommand = CommandHelper.CreateExtremeCodeMainChatCommand(petroResult.Response.Tokens.UserId);
        var chatResult = await RequestAsync(chatCommand, CancellationToken.None);
        var messageCommand =
            CommandHelper.SendMessageToChannelCommand(petroResult.Response.Tokens.UserId, chatResult.Response.ChatId);
        var messageResult = await RequestAsync(messageCommand, CancellationToken.None);
        var editCommand = new EditMessageCommand(
            chatResult.Response.ChatId,
            petroResult.Response.Tokens.UserId,
            messageResult.Response.NewMessageId,
            "Message edited");

        var result = await RequestAsync(editCommand, CancellationToken.None);
        var editedMessage =
            await DbContextFixture.Messages.FirstAsync(x => x.Id == messageResult.Response.NewMessageId);

        assert.Pass(result);
        editedMessage.Text.Should().Be(editCommand.ModifiedText);
    }
}