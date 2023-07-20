using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.CreateChatCommandHandlerTests;

public class CreateChatTestSuccess : IntegrationTestBase
{
    private readonly Assert<CreateCommunityResponse> assert = new();

    [Fact]
    public async Task CreateChatTestSuccessAsync()
    {
        var petroCommand = CommandHelper.RegisterPetroCommand();
        var petroResult = await RequestAsync(petroCommand, CancellationToken.None);
        var khachaturCommand = CommandHelper.RegisterKhachaturCommand();
        var khachaturResult = await RequestAsync(khachaturCommand, CancellationToken.None);
        var petroId = petroResult.Response.Tokens.UserId;
        var khachaturId = khachaturResult.Response.Tokens.UserId;

        var command = new CreateChatCommand(petroId, khachaturId);
        var result = await RequestAsync(command, CancellationToken.None);

        assert.Pass(result);
    }
}