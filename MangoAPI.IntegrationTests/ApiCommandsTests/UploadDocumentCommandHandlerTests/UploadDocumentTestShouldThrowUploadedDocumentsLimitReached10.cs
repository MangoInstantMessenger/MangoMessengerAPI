using MangoAPI.BusinessLogic;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Documents;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.UploadDocumentCommandHandlerTests;

public class UploadDocumentTestShouldThrowUploadedDocumentsLimitReached10 : IntegrationTestBase
{
    private readonly Assert<UploadDocumentResponse> assert = new();

    [Fact]
    public async Task UploadDocumentTestShouldThrowUploadedDocumentsLimitReached10Async()
    {
        const string expectedMessage = ResponseMessageCodes.UploadedDocumentsLimitReached10;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var fileNamesList = new List<string>();
        var file = MangoFilesHelper.GetTestImage();
        var user = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var command =
            new UploadDocumentCommand(FormFile: file, UserId: user.Response.Tokens.UserId, ContentType: "image/jpeg");
        for (var i = 0; i <= 10; i++)
        {
            var uploadResult = await MangoModule.RequestAsync(command, CancellationToken.None);
            fileNamesList.Add(uploadResult.Response.FileName);
        }

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
        foreach (var fileName in fileNamesList)
        {
            await BlobService.DeleteBlobAsync(fileName);
        }
    }
}
