using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MediatR;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.UpdateUserSocialsInformationCommandHandlerTests;

public class UpdateUserSocialsInformationTestShouldThrowUserNotFound 
    : ITestable<UpdateUserSocialInformationCommand,ResponseBase>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task UpdateUserSocialsInformationTest_Success()
    {
        Seed();
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var handler = CreateHandler();

        var result = await handler.Handle(_command, CancellationToken.None);
            
        _assert.Fail(result, expectedMessage, expectedDetails);
    }
        
    public bool Seed()
    {
        return true;
    }

    public IRequestHandler<UpdateUserSocialInformationCommand, Result<ResponseBase>> CreateHandler()
    {
        var context = _mangoDbFixture.Context;
        var responseFactory = new ResponseFactory<ResponseBase>();
        var handler = new UpdateUserSocialInformationCommandHandler(context, responseFactory);
        return handler;
    }

    private readonly UpdateUserSocialInformationCommand _command = new()
    {
        UserId = SeedDataConstants.RazumovskyId,
        Instagram = "petro.kolosov",
        LinkedIn = "petro.kolosov",
        Facebook = "petro.kolosov",
        Twitter = "petro.kolosov",
    };
}