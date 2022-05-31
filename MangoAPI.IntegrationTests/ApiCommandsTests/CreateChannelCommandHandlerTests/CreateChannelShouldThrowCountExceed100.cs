using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.CreateChannelCommandHandlerTests;

public class CreateChannelShouldThrowCountExceed100 : ITestable<CreateChannelCommand, CreateCommunityResponse>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<CreateCommunityResponse> _assert = new();

    [Fact]
    public async Task CreateChannel_ShouldThrow_CountExceed100()
    {
        Seed();
        const string expectedMessage = ResponseMessageCodes.MaximumOwnerChatsExceeded100;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var handler = CreateHandler();

        async void Action(int _)
        {
            await handler.Handle(_command, CancellationToken.None);
        }
            
        Enumerable.Range(1, 100).ToList().ForEach(Action);

        var result = await handler.Handle(_command, CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    }

    public bool Seed()
    {
        _mangoDbFixture.Context.Users.Add(_user);

        _mangoDbFixture.Context.SaveChanges();

        _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;

        return true;
    }

    public IRequestHandler<CreateChannelCommand, Result<CreateCommunityResponse>> CreateHandler()
    {
        var hubContext = MockedObjects.GetHubContextMock();
        var responseFactory = new ResponseFactory<CreateCommunityResponse>();
        var handler = new CreateChannelCommandHandler(_mangoDbFixture.Context, hubContext, responseFactory);
        return handler;
    }

    private readonly UserEntity _user = new()
    {
        DisplayName = "razumovsky r",
        Bio = "11011 y.o Dotnet Developer from $\"{cityName}\"",
        Id = SeedDataConstants.RazumovskyId,
        UserName = "razumovsky_r",
        Email = "kolosovp95@gmail.com",
        NormalizedEmail = "KOLOSOVP94@GMAIL.COM",
        EmailConfirmed = true,
        PhoneNumberConfirmed = true,
        Image = "razumovsky_picture.jpg"
    };

    private readonly CreateChannelCommand _command = new()
    {
        ChannelDescription = "My test channel",
        ChannelTitle = "Test channel",
        UserId = SeedDataConstants.RazumovskyId
    };
}