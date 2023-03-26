using MangoAPI.BusinessLogic;
using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.Users;
using MangoAPI.Domain.Constants;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetUserQueryHandlerTests;

public class GetUserQueryShouldThrowUserNotFound : IntegrationTestBase
{
    private readonly Assert<GetUserResponse> assert = new();

    [Fact]
    public async Task GetUserQueryShouldThrowUserNotFoundAsync()
    {
        const string expectedMessage = ResponseMessageCodes.UserNotFound;
        var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var query = new GetUserQuery(Guid.NewGuid());

        var result = await MangoModule.RequestAsync(query, CancellationToken.None);

        assert.Fail(result, expectedMessage, expectedDetails);
    }
}