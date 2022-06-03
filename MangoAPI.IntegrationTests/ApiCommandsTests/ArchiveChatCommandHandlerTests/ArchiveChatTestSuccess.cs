using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.UserChats;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.ArchiveChatCommandHandlerTests;

public class ArchiveChatTestSuccess : IntegrationTestBase
{
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task ArchiveChatTest_Success()
    {
        var user = 
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var chat =
            await MangoModule.RequestAsync(CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.UserId),
                                           CancellationToken.None);
        var command = new ArchiveChatCommand
        {
            ChatId = chat.Response.ChatId,
            UserId = user.Response.UserId
        };
        
        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        _assert.Pass(result);
    }
}