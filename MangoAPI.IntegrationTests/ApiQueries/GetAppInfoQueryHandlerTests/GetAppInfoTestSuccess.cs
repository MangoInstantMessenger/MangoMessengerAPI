using FluentAssertions;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.ApiQueries.AppInfo;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetAppInfoQueryHandlerTests;

public class GetAppInfoTestSuccess : IntegrationTestBase
{
    [Fact]
    public async Task GetAppInfoTestSuccessAsync()
    {
        var query = new GetAppInfoQuery();

        var result = await MangoModule.RequestAsync(query, CancellationToken.None);

        const string expectedVersion = ParameterService.DefaultVersion;
        result.Response.AppInfo.ApiVersion.Should().Be(expectedVersion);
    }
}