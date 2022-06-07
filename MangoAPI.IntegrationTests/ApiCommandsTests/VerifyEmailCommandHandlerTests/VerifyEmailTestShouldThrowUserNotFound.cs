using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using MediatR;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.VerifyEmailCommandHandlerTests;

public class VerifyEmailTestShouldThrowUserNotFound : IntegrationTestBase
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task VerifyEmailTestShouldThrow_UserNotFound()
    {
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new VerifyEmailCommand
        {
            Email = "test@gmail.com",
            EmailCode = Guid.NewGuid()
        };

        var result = await MangoModule.RequestAsync(
            request: CommandHelper.CreateVerifyEmailCommand("test@gmail.com", Guid.NewGuid()),
            cancellationToken: CancellationToken.None);
            
        _assert.Fail(result, expectedMessage, expectedDetails);
    }
}