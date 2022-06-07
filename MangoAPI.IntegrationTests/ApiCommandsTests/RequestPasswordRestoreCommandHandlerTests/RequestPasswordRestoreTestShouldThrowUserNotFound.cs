using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.Domain.Constants;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.RequestPasswordRestoreCommandHandlerTests;

public class RequestPasswordRestoreTestShouldThrowUserNotFound : IntegrationTestBase
{
    private readonly Assert<RequestPasswordRestoreResponse> _assert = new();

    [Fact]
    public async Task RequestPasswordRestoreTestShouldThrow_UserNotFound()
    {
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new RequestPasswordRestoreCommand
        {
            Email = "email"
        };

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    }
}