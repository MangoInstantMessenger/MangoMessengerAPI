using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.AddContactCommandHandlerTests;

public class AddContactShouldThrowCannotAddSelf : IntegrationTestBase
{
    private readonly Assert<ResponseBase> assert = new();

    [Fact]
    public async Task AddContactCommandHandlerTestShouldThrowCannotAddSelfAsync()
    {
        const string expectedMessage = ResponseMessageCodes.CannotAddSelfToContacts;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var registerPetroCommand = CommandHelper.RegisterPetroCommand();
        var user = await RequestAsync(registerPetroCommand, CancellationToken.None);

        var command = new AddContactCommand(user.Response.Tokens.UserId, user.Response.Tokens.UserId);
        var result = await RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
