using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.UpdateProfilePictureCommandHandlerTests;

public class UpdateProfilePictureTestShouldThrowUploadedDocumentsLimitReached10 : IntegrationTestBase
{
    private readonly Assert<UpdateProfilePictureResponse> _assert = new();

    [Fact]
    public async Task UpdateProfilePictureTestShouldThrow_UploadedDocumentsLimitReached10()
    {
        const string expectedMessage = ResponseMessageCodes.UploadedDocumentsLimitReached10;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var fileNameList = new List<string>();
        var userResult = await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var userId = userResult.Response.UserId;
        var file = MangoFilesHelper.GetTestImage();
        var command = new UpdateProfilePictureCommand(UserId: userId, ContentType: "image/jpeg", PictureFile: file);
        for (var i = 0; i <= 10; i++)
        {
            var fileResult = await MangoModule.RequestAsync(command, CancellationToken.None);
            fileNameList.Add(fileResult.Response.FileName);
        }

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
        foreach (var fileName in fileNameList)
        {
            await BlobService.DeleteBlobAsync(fileName);
        }
    }
}