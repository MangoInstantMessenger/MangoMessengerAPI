using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.IntegrationTests.Helpers;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.CreateChannelCommandHandlerTests;

public class CreateChannelShouldThrowCountExceed100 : IntegrationTestBase
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<CreateCommunityResponse> _assert = new();

    [Fact]
    public async Task CreateChannel_ShouldThrow_CountExceed100()
    {
        const string expectedMessage = ResponseMessageCodes.MaximumOwnerChatsExceeded100;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var user = 
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        for (int i = 0; i <= 100; i++)
        {
            await MangoModule.RequestAsync(CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.UserId),
                    CancellationToken.None);
        }

        var result = await MangoModule.RequestAsync(CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.UserId),
            CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    }
}