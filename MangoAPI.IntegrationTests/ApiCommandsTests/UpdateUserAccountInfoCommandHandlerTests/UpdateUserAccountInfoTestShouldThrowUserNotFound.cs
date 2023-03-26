using MangoAPI.BusinessLogic;
using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.Domain.Constants;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.UpdateUserAccountInfoCommandHandlerTests;

public class UpdateUserAccountInfoTestShouldThrowUserNotFound : IntegrationTestBase
{
    private readonly Assert<UpdateUserAccountInfoResponse> assert = new();

    [Fact]
    public async Task UpdateUserAccountInfoTestShouldThrowUserNotFoundAsync()
    {
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new UpdateUserAccountInfoCommand(
            Guid.NewGuid(),
            "PetroKolosov",
            "Petro Kolosov",
            "pkolosov.com",
            "Third year student of WSB at Poznan",
            "Poznan, Poland",
            new DateTime(1994, 6, 12));

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}