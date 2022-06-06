using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MediatR;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.PasswordRestoreCommandHandlerTests;

public class PasswordRestoreTestShouldThrowInvalidOrExpired: IntegrationTestBase
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task PasswordRestoreTestShouldThrow_InvalidOrExpired()
    {
        const string expectedMessage = ResponseMessageCodes.InvalidOrExpiredRestorePasswordRequest;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new PasswordRestoreCommand
        {
            RequestId = Guid.NewGuid(),
            NewPassword = "Bm3-`dPRv-/w#3)cw^97",
            RepeatPassword = "Bm3-`dPRv-/w#3)cw^97"
        };

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);
            
        _assert.Fail(result, expectedMessage, expectedDetails);
    }
}