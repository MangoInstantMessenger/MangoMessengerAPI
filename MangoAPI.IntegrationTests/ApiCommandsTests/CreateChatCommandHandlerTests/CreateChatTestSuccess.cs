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
    public async Task CreateChatTest_Success()
    {
        var user =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var partner =
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var command = new CreateChatCommand(
            UserId: user.Response.UserId,
            PartnerId: partner.Response.UserId);

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Pass(result);
    }
}
