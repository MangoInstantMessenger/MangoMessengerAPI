using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.UpdateUserAccountInfoCommandHandlerTests;

public class UpdateUserAccountInfoTestShouldThrowUserNotFound : IntegrationTestBase
{
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task UpdateUserAccountInfoTestShouldThrow_UserNotFound()
    {
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new UpdateUserAccountInfoCommand
        {
            UserId = Guid.NewGuid(),
            Username = "Petro_Kolosov",
            DisplayName = "Petro Kolosov",
            Website = "pkolosov.com",
            Bio = "Third year student of WSB at Poznan",
            Address = "Poznan, Poland",
            BirthdayDate = new DateTime(1994, 6, 12)
        };

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);
            
        _assert.Fail(result, expectedMessage, expectedDetails);
    }
}