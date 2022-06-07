using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.Users;
using MangoAPI.Domain.Constants;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetUserQueryHandlerTests;

public class GetUserQueryShouldThrowUserNotFound : IntegrationTestBase
{
    private readonly Assert<GetUserResponse> _assert = new();

    [Fact]
    public async Task GetUserQueryShouldThrow_UserNotFound()
    {
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var query = new GetUserQuery
        {
            UserId = Guid.NewGuid()
        };
        
        var result = await MangoModule.RequestAsync(query, CancellationToken.None);
            
        _assert.Fail(result, expectedMessage,expectedDetails);
    }
}