using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.UpdateUserAccountInfoCommandHandlerTests;

public class UpdateUserAccountInfoTestShouldThrowInvalidRequestModel : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task UpdateUserAccountInfoTestShouldThrowInvalidRequestModelAsync()
    {
        const string expectedMessage = ResponseMessageCodes.InvalidRequestModel;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        
        var user = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        
        var command = new UpdateUserAccountInfoCommand(
            UserId: user.Response.Tokens.UserId,
            Username: Guid.NewGuid().ToString(),
            DisplayName: "Petro Kolosov",
            Website: "pkolosov.com",
            Bio: "Third year student of WSB at Poznan",
            Address: "Poznan, Poland",
            BirthdayDate: new DateTime(1994, 6, 12));

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
