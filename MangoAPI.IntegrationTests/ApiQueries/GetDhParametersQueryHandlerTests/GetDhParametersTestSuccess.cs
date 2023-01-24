using System.IO;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetDhParametersQueryHandlerTests;

public class GetDhParametersTestSuccess : IntegrationTestBase
{
    private readonly Assert<GetDhParametersResponse> assert = new();

    [Fact]
    public async Task GetDhParametersTestSuccessAsync()
    {
        var file = MangoFilesHelper.GetTestImage();
        var user =
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        await MangoModule.RequestAsync(
            request: CommandHelper.CreateOpenSslCreateDiffieHellmanParameterCommand(
                diffieHellmanParameter: file,
                userId: user.Response.Tokens.UserId),
            cancellationToken: CancellationToken.None);
        var query = new GetDhParametersQuery();

        var response = await MangoModule.RequestAsync(query, CancellationToken.None);

        assert.Pass(response);
        await using var target = new MemoryStream();
        await file.CopyToAsync(target, CancellationToken.None);
        var targetBytes = target.ToArray();
        response.Response.FileContent.Should().BeEquivalentTo(targetBytes);
    }
}
