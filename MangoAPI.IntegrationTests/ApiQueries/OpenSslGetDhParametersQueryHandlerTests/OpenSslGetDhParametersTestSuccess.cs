using System.IO;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.OpenSslGetDhParametersQueryHandlerTests;

public class OpenSslGetDhParametersTestSuccess : IntegrationTestBase
{
    private readonly Assert<OpenSslGetDhParametersResponse> _assert = new();

    [Fact]
    public async Task OpenSslGetDhParametersTest_Success()
    {
        var file = MangoFilesHelper.GetTestImage();
        var user = 
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        await MangoModule.RequestAsync(
            request: CommandHelper.CreateOpenSslCreateDiffieHellmanParameterCommand(
                diffieHellmanParameter: file,
                userId: user.Response.UserId),
            cancellationToken: CancellationToken.None);
        var query = new OpenSslGetDhParametersQuery();

        var response = await MangoModule.RequestAsync(query, CancellationToken.None);
        
        _assert.Pass(response);
        await using var target = new MemoryStream();
        await file.CopyToAsync(target, CancellationToken.None);
        var targetBytes = target.ToArray();
        response.Response.FileContent.Should().BeEquivalentTo(targetBytes);
    }
}