using MangoAPI.BusinessLogic;
using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.UpdateChannelPictureCommandHandlerTests;

public class
    UpdateChannelPictureShouldThrowChatNotFound : IntegrationTestBase
{
    private readonly Assert<UpdateChannelPictureResponse> assert = new();

    [Fact]
    public async Task UpdateChannelPictureShouldThrowChatNotFoundAsync()
    {
        const string expectedMessage = ResponseMessageCodes.ChatNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var sender = await MangoModule.RequestAsync(
            CommandHelper.RegisterPetroCommand(),
            CancellationToken.None);
        var file = MangoFilesHelper.GetTestImage();
        var command = new UpdateChanelPictureCommand(
            UserId: sender.Response.Tokens.UserId,
            ChatId: Guid.NewGuid(),
            NewGroupPicture: file,
            ContentType: "image/jpeg");

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
