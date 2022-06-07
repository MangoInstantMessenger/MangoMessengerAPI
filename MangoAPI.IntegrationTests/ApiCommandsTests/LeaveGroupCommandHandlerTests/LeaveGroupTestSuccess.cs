using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.UserChats;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.LeaveGroupCommandHandlerTests;

public class LeaveGroupTestSuccess : IntegrationTestBase
{
    private readonly Assert<LeaveGroupResponse> _assert = new();

    [Fact]
    public async Task LeaveGroupTest_Success()
    {
        var user =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var chat =
            await MangoModule.RequestAsync(
                request: CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.UserId),
                cancellationToken: CancellationToken.None);
        var command = new LeaveGroupCommand
        {
            UserId = user.Response.UserId,
            ChatId = chat.Response.ChatId
        };

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        _assert.Pass(result);
    }
}