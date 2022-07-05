using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.DeleteContactCommandHandlerTests;

public class DeleteContactTestSuccess : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task DeleteContactTest_Success()
    {
        var user =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var partner =
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        var contact =
            await MangoModule.RequestAsync(
                request: CommandHelper.CreateContactCommand(user.Response.UserId, partner.Response.UserId),
                cancellationToken: CancellationToken.None);
        var command = new DeleteContactCommand(UserId: user.Response.UserId, ContactId: partner.Response.UserId);

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Pass(result);
    }
}
