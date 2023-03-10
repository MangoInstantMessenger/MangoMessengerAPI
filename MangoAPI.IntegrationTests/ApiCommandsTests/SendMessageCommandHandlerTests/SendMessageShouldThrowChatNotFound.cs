using MangoAPI.BusinessLogic;
using System;
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
        var user = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);

        var result = await MangoModule.RequestAsync(
            request: CommandHelper.SendMessageToChannelCommand(user.Response.Tokens.UserId, Guid.NewGuid()),
            cancellationToken: CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
