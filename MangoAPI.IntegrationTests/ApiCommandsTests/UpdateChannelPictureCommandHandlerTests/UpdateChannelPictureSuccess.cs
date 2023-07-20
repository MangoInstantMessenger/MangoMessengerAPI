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
    public async Task UpdateChannelPictureSuccessAsync()
    {
        var sender = await RequestAsync(
            CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var userId = sender.Response.Tokens.UserId;
        var createChannelCommand = CommandHelper.CreateExtremeCodeMainChatCommand(userId);
        var chat = await RequestAsync(
            createChannelCommand, CancellationToken.None);
        var chatId = chat.Response.ChatId;
        var file = MangoFilesHelper.GetTestImage();
        var command = new UpdateChanelPictureCommand(
            ChatId: chatId,
            UserId: userId,
            NewGroupPicture: file,
            ContentType: "image/jpeg");

        var result = await RequestAsync(command, CancellationToken.None);

        assert.Pass(result);
        await BlobService.DeleteBlobAsync(result.Response.FileName);
    }
}
