using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.RegisterCommandHandlerTests;

public class RegisterTestShouldThrowUserAlreadyExists : IntegrationTestBase
{
    private readonly Assert<RegisterResponse> _assert = new();

    [Fact]
    public async Task RegisterTestShouldThrow_UserAlreadyExists()
    {
        const string expectedMessage = ResponseMessageCodes.UserAlreadyExists;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = CommandHelper.RegisterPetroCommand();
        await MangoModule.RequestAsync(command, CancellationToken.None);

        var registrationsResult = await MangoModule.RequestAsync(command, CancellationToken.None);

        _assert.Fail(registrationsResult, expectedMessage, expectedDetails);
    }
}