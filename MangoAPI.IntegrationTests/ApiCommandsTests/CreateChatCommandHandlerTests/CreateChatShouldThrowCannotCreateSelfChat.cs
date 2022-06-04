using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.CreateChatCommandHandlerTests;

public class CreateChatShouldThrowCannotCreateSelfChat : IntegrationTestBase
{
    private readonly Assert<CreateCommunityResponse> _assert = new();

    [Fact]
    public async Task CreateChatShouldThrow_CannotCreateSelfChat()
    {
        const string expectedMessage = ResponseMessageCodes.CannotCreateSelfChat;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var user =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var command = new CreateChatCommand 
        {
            UserId = user.Response.UserId,
            PartnerId = user.Response.UserId
        };
        
        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    }
}