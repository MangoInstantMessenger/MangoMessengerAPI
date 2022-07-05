using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.UpdateChannelPictureCommandHandlerTests;

public class UpdateChannelPictureSuccess : IntegrationTestBase
{
    private readonly Assert<UpdateChannelPictureResponse> assert = new();

    [Fact]
    public async Task UpdateChannelPicture_Success()
    {
        var sender = await MangoModule.RequestAsync(
            CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var userId = sender.Response.UserId;
        var createChannelCommand = CommandHelper.CreateExtremeCodeMainChatCommand(userId);
        var chat = await MangoModule.RequestAsync(
            createChannelCommand, CancellationToken.None);
        var chatId = chat.Response.ChatId;
        var file = MangoFilesHelper.GetTestImage();
        var command = new UpdateChanelPictureCommand(
            ChatId: chatId,
            UserId: userId,
            NewGroupPicture: file,
            ContentType: "image/jpeg");

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Pass(result);
        await BlobService.DeleteBlobAsync(result.Response.FileName);
    }
}
