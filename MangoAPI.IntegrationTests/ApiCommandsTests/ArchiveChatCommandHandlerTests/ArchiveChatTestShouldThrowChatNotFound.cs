using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.ArchiveChatCommandHandlerTests;

public class ArchiveChatTestShouldThrowChatNotFound : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task ArchiveChatTestShouldThrowChatNotFoundAsync()
    {
        const string expectedMessage = ResponseMessageCodes.ChatNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var user = await RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var command = new ArchiveChatCommand(ChatId: Guid.NewGuid(), UserId: user.Response.Tokens.UserId);

        var result = await RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
