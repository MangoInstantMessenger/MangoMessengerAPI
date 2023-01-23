using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.LeaveGroupCommandHandlerTests;

public class LeaveGroupTestSuccess : IntegrationTestBase
{
    private readonly Assert<LeaveGroupResponse> assert = new();

    [Fact]
    public async Task LeaveGroupTestSuccessAsync()
    {
        var user =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var chat =
            await MangoModule.RequestAsync(
                request: CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.Tokens.UserId),
                cancellationToken: CancellationToken.None);
        var command = new LeaveGroupCommand(UserId: user.Response.Tokens.UserId, ChatId: chat.Response.ChatId);

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Pass(result);
    }
}
