using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.VerifyEmailCommandHandlerTests;

public class VerifyEmailTestShouldThrowUserNotFound : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task VerifyEmailTestShouldThrow_UserNotFound()
    {
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];

        var result = await MangoModule.RequestAsync(
            request: CommandHelper.CreateVerifyEmailCommand("test@gmail.com", Guid.NewGuid()),
            cancellationToken: CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
