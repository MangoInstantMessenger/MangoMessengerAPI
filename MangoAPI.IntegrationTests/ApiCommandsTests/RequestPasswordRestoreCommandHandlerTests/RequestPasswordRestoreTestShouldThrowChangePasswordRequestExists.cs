using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.RequestPasswordRestoreCommandHandlerTests;

public class RequestPasswordRestoreTestShouldThrowChangePasswordRequestExists : IntegrationTestBase
{
    private readonly Assert<RequestPasswordRestoreResponse> assert = new();

    [Fact]
    public async Task RequestPasswordRestoreTestShouldThrowChangePasswordRequestExistsAsync()
    {
        const string expectedMessage = ResponseMessageCodes.ChangePasswordRequestExists;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        _ = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        _ = await MangoModule.RequestAsync(
            request: CommandHelper.CreateRequestPasswordRestoreCommand("kolosovp95@gmail.com"),
            cancellationToken: CancellationToken.None);

        var result = await MangoModule.RequestAsync(
            request: CommandHelper.CreateRequestPasswordRestoreCommand("kolosovp95@gmail.com"),
            cancellationToken: CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
