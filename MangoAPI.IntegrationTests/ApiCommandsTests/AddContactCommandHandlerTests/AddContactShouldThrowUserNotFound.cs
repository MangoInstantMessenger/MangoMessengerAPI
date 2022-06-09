using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.AddContactCommandHandlerTests;

public class AddContactShouldThrowUserNotFound : IntegrationTestBase
{
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task AddContactCommandHandlerTest_ShouldThrow_UserNotFound()
    {
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var user = 
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var command = new AddContactCommand(
            UserId: user.Response.UserId,
            ContactId: Guid.Empty);

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    }
}