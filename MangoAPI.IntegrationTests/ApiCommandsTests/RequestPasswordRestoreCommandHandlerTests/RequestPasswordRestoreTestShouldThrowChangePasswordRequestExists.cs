using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.RequestPasswordRestoreCommandHandlerTests;

public class RequestPasswordRestoreTestShouldThrowChangePasswordRequestExists : IntegrationTestBase
{
    private readonly Assert<RequestPasswordRestoreResponse> _assert = new();

    [Fact]
    public async Task RequestPasswordRestoreTestShouldThrow_ChangePasswordRequestExists()
    {
        const string expectedMessage = ResponseMessageCodes.ChangePasswordRequestExists;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        await MangoModule.RequestAsync(
            request: CommandHelper.CreateRequestPasswordRestoreCommand("kolosovp95@gmail.com"),
            cancellationToken: CancellationToken.None);

        var result = await MangoModule.RequestAsync(
            request: CommandHelper.CreateRequestPasswordRestoreCommand("kolosovp95@gmail.com"),
            cancellationToken: CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    }
}