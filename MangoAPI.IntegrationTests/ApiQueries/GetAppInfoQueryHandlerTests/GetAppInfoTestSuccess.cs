using FluentAssertions;
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

        var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString();

        result.Response.AppInfo.ApiVersion.Should().Be(version ?? "1.0.0.0");
    }
}