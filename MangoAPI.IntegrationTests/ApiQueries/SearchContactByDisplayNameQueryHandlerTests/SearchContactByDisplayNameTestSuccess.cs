﻿using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic;
using MangoAPI.BusinessLogic.ApiQueries.Contacts;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.SearchContactByDisplayNameQueryHandlerTests;

public class SearchContactByDisplayNameTestSuccess : IntegrationTestBase
{
    private readonly Assert<SearchContactResponse> assert = new();

    [Fact]
    public async Task SearchContactByDisplayNameTestSuccessAsync()
    {
        var user =
            await MangoModule.RequestAsync(CommandHelper.RegisterKhachaturCommand(), CancellationToken.None);
        await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var query = new SearchContactQuery(UserId: user.Response.Tokens.UserId, SearchQuery: "Kolosov");

        var result = await MangoModule.RequestAsync(query, CancellationToken.None);

        assert.Pass(result);
        result.Response.Contacts.Count.Should().Be(1);
        result.Response.Contacts[0].DisplayName.Should().Be("PetroKolosov");
    }
}