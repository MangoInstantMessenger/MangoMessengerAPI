﻿using FluentAssertions;
using System.Threading;
using System.Threading.Tasks;
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
        var user = await RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var contact = await RequestAsync(
            request: CommandHelper.RegisterKhachaturCommand(),
            cancellationToken: CancellationToken.None);
        await RequestAsync(
            request: CommandHelper.CreateContactCommand(user.Response.Tokens.UserId, contact.Response.Tokens.UserId),
            cancellationToken: CancellationToken.None);
        var query = new GetContactsQuery(UserId: user.Response.Tokens.UserId);

        var result = await RequestAsync(query, CancellationToken.None);

        assert.Pass(result);
        result.Response.Contacts.Count.Should().Be(1);
        result.Response.Contacts[0].UserId.Should().Be(contact.Response.Tokens.UserId);
    }
}
