using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.DeleteContactCommandHandlerTests;

public class DeleteContactShouldThrowUserNotFound : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task DeleteContactTestShouldThrow_UserNotFound()
    {
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new DeleteContactCommand(UserId: Guid.NewGuid(), ContactId: Guid.NewGuid());

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
