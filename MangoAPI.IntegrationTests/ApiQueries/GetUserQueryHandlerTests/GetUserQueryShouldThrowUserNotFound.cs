using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MediatR;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetUserQueryHandlerTests;

public class GetUserQueryShouldThrowUserNotFound
    : ITestable<GetUserQuery, GetUserResponse>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<GetUserResponse> _assert = new();

    [Fact]
    public async Task GetUserQueryShouldThrow_UserNotFound()
    {
        Seed();
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var query = new GetUserQuery
        {
            UserId = Guid.NewGuid()
        };
        var handler = CreateHandler();

        var result = await handler.Handle(query, CancellationToken.None);
            
        _assert.Fail(result, expectedMessage,expectedDetails);
    }
        
    public bool Seed()
    {
        return true;
    }

    public IRequestHandler<GetUserQuery, Result<GetUserResponse>> CreateHandler()
    {
        var responseFactory = new ResponseFactory<GetUserResponse>();
        var blobSettings = MockedObjects.GetBlobServiceSettingsMock();
        var handler = new GetUserQueryHandler(_mangoDbFixture.Context, responseFactory, blobSettings);
        return handler;
    }
}