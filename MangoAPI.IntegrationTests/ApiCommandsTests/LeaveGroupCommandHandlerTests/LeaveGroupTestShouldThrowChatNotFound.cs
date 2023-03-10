using MangoAPI.BusinessLogic;
using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.LeaveGroupCommandHandlerTests;

public class LeaveGroupTestShouldThrowChatNotFound : IntegrationTestBase
{
    private readonly Assert<LeaveGroupResponse> assert = new();

    [Fact]
    public async Task LeaveGroupTestShouldThrowUserNotFoundAsync()
    {
        const string expectedMessage = ResponseMessageCodes.ChatNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var user =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var command = new LeaveGroupCommand(UserId: user.Response.Tokens.UserId, ChatId: Guid.NewGuid());

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
