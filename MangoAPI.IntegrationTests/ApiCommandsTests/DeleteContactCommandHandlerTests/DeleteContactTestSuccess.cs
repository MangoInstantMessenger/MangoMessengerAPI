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
    public async Task DeleteContactTestSuccessAsync()
    {
        var user = await RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var partner = await RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        await RequestAsync(
            request: CommandHelper.CreateContactCommand(user.Response.Tokens.UserId, partner.Response.Tokens.UserId),
            cancellationToken: CancellationToken.None);
        var command = new DeleteContactCommand(UserId: user.Response.Tokens.UserId, ContactId: partner.Response.Tokens.UserId);

        var result = await RequestAsync(command, CancellationToken.None);

        assert.Pass(result);
    }
}
