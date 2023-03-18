using MangoAPI.BusinessLogic;
using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.Domain.Constants;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.UpdateUserSocialsInformationCommandHandlerTests;

public class UpdatePersonalInformationTestShouldThrowUserNotFound : IntegrationTestBase
{
    private readonly Assert<UpdatePersonalInformationResponse> assert = new();

    [Fact]
    public async Task UpdatePersonalInformationTestSuccessAsync()
    {
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new UpdatePersonalInformationCommand(
            UserId: Guid.NewGuid(),
            Instagram: "petro.kolosov",
            LinkedIn: "petro.kolosov",
            Facebook: "petro.kolosov",
            Twitter: "petro.kolosov");

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}