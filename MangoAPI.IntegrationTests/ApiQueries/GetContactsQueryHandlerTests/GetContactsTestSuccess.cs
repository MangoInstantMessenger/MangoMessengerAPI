using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Contacts;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetContactsQueryHandlerTests;

public class GetContactsTestSuccess : IntegrationTestBase
{
    private readonly Assert<GetContactsResponse> _assert = new();

    [Fact]
    public async Task GetContactsTest_Success()
    {
        var user = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var contact = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterKhachaturCommand(),
            cancellationToken: CancellationToken.None);
        await MangoModule.RequestAsync(
            request: CommandHelper.CreateContactCommand(user.Response.UserId, contact.Response.UserId),
            cancellationToken: CancellationToken.None);
        var query = new GetContactsQuery
        {
            UserId = user.Response.UserId
        };

        var result = await MangoModule.RequestAsync(query, CancellationToken.None);
            
        _assert.Pass(result);
        result.Response.Contacts.Count.Should().Be(1);
        result.Response.Contacts[0].UserId.Should().Be(contact.Response.UserId);
    }
}