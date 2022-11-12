using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.Domain.Constants;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.CreateChannelCommandHandlerTests;

public class CreateChannelShouldThrowCountExceed100 : IntegrationTestBase
{
    private readonly Assert<CreateCommunityResponse> assert = new();

    [Fact]
    public async Task CreateChannel_ShouldThrow_CountExceed100()
    {
        const string expectedMessage = ResponseMessageCodes.MaximumOwnerChatsExceeded100;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var user =
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        for (var i = 0; i <= 100; i++)
        {
            await MangoModule.RequestAsync(
                CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.Tokens.UserId),
                CancellationToken.None);
        }

        var result = await MangoModule.RequestAsync(
            CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.Tokens.UserId),
            CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}
