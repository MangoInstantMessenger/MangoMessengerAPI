using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.CreateChatCommandHandlerTests;

public class CreateChatShouldThrowCannotCreateSelfChat : IntegrationTestBase
{
    private readonly Assert<CreateCommunityResponse> assert = new();

    [Fact]
    public async Task CreateChatShouldThrowCannotCreateSelfChatAsync()
    {
        const string expectedMessage = ResponseMessageCodes.CannotCreateSelfChat;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var user = await RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var command = new CreateChatCommand(
            UserId: user.Response.Tokens.UserId,
            PartnerId: user.Response.Tokens.UserId);

        var result = await RequestAsync(command, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
