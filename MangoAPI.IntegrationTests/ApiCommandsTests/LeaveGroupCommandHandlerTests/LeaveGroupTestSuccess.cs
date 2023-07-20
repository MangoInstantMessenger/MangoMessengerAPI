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
        var petroCommand = CommandHelper.RegisterPetroCommand();
        var petroResult = await RequestAsync(petroCommand, CancellationToken.None);
        var chatCommand = CommandHelper.CreateExtremeCodeMainChatCommand(petroResult.Response.Tokens.UserId);
        var chatResult = await RequestAsync(chatCommand, CancellationToken.None);
        var command = new LeaveGroupCommand(petroResult.Response.Tokens.UserId, chatResult.Response.ChatId);

        var result = await RequestAsync(command, CancellationToken.None);

        assert.Pass(result);
    }
}
