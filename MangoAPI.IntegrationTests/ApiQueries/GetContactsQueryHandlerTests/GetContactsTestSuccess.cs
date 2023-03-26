using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic;
using MangoAPI.BusinessLogic.ApiQueries.Contacts;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetContactsQueryHandlerTests;

public class GetContactsTestSuccess : IntegrationTestBase
{
    private readonly Assert<GetContactsResponse> assert = new();

    [Fact]
    public async Task GetContactsTestSuccessAsync()
    {
        var user = await MangoModule.RequestAsync(
            CommandHelper.RegisterPetroCommand(),
            CancellationToken.None);
        var contact = await MangoModule.RequestAsync(
            CommandHelper.RegisterKhachaturCommand(),
            CancellationToken.None);
        await MangoModule.RequestAsync(
            CommandHelper.CreateContactCommand(user.Response.Tokens.UserId, contact.Response.Tokens.UserId),
            CancellationToken.None);
        var query = new GetContactsQuery(user.Response.Tokens.UserId);

        var result = await MangoModule.RequestAsync(query, CancellationToken.None);

        assert.Pass(result);
        result.Response.Contacts.Count.Should().Be(1);
        result.Response.Contacts[0].UserId.Should().Be(contact.Response.Tokens.UserId);
    }
}