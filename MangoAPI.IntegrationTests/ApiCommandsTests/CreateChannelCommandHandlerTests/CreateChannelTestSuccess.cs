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

public class CreateChannelTestSuccess : IntegrationTestBase
{
    private readonly Assert<CreateCommunityResponse> _assert = new();

    [Fact]
    public async Task CreateChannelTest_Success()
    {
        var user = 
            await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);

        var result = 
            await MangoModule.RequestAsync(CommandHelper.CreateExtremeCodeMainChatCommand(user.Response.UserId), 
                                           CancellationToken.None);

        _assert.Pass(result);
    }

}