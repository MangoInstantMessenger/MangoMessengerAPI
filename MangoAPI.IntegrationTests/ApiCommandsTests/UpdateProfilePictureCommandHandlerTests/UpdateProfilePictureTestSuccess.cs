using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.UpdateProfilePictureCommandHandlerTests;

public class UpdateProfilePictureTestSuccess : IntegrationTestBase
{
    private readonly Assert<UpdateProfilePictureResponse> assert = new();

    [Fact]
    public async Task UpdateProfilePictureTestSuccessAsync()
    {
        var userResult = await RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var userId = userResult.Response.Tokens.UserId;
        var file = MangoFilesHelper.GetTestImage();
        var command = new UpdateProfilePictureCommand(userId, ContentType: "image/jpeg", file);

        var result = await RequestAsync(command, CancellationToken.None);

        assert.Pass(result);
        await BlobService.DeleteBlobAsync(result.Response.FileName);
    }
}
