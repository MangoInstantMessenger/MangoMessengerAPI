﻿using FluentAssertions;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.Messages;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetMessagesQueryHandlerTests;

public class GetMessagesTestSuccess : IntegrationTestBase
{
    private readonly Assert<GetMessagesResponse> assert = new();

    [Fact]
    public async Task GetMessagesTestSuccessAsync()
    {
        var user = await RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var chat = await RequestAsync(
            request: CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.Tokens.UserId),
            cancellationToken: CancellationToken.None);
        await RequestAsync(
            request: CommandHelper.SendMessageToChannelCommand(user.Response.Tokens.UserId, chat.Response.ChatId),
            cancellationToken: CancellationToken.None);
        await RequestAsync(
            request: CommandHelper.SendMessageToChannelCommand(user.Response.Tokens.UserId, chat.Response.ChatId),
            cancellationToken: CancellationToken.None);
        var query = new GetMessagesQuery(UserId: user.Response.Tokens.UserId, ChatId: chat.Response.ChatId);

        var result = await RequestAsync(query, CancellationToken.None);

        assert.Pass(result);
        result.Response.Messages.Count.Should().Be(2);
    }
}
