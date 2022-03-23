using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.PublicKeys;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiQueries.GetPublicKeysQueryHandlerTests;

public class GetPublicKeysTestSuccess : ITestable<CngGetPublicKeysQuery, CngGetPublicKeysResponse>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<CngGetPublicKeysResponse> _assert = new();

    [Fact]
    public async Task GetPublicKeysTest_Success()
    {
        Seed();
        var query = new CngGetPublicKeysQuery
        {
            UserId = _user.Id
        };
        var handler = CreateHandler();

        var result = await handler.Handle(query, CancellationToken.None);
            
        _assert.Pass(result);
        result.Response.PublicKeys.Count.Should().Be(1);
        result.Response.PublicKeys[0].PartnerId.Should().Be(_partner.Id);
    }
        
    public bool Seed()
    {
        _mangoDbFixture.Context.AddRange(_user, _partner);
        _mangoDbFixture.Context.CngPublicKeys.Add(_cngPublicKey);

        _mangoDbFixture.Context.SaveChanges();
            
        _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;
        _mangoDbFixture.Context.Entry(_partner).State = EntityState.Detached;
        _mangoDbFixture.Context.Entry(_cngPublicKey).State = EntityState.Detached;
            
        return true;
    }

    public IRequestHandler<CngGetPublicKeysQuery, Result<CngGetPublicKeysResponse>> CreateHandler()
    {
        var responseFactory = new ResponseFactory<CngGetPublicKeysResponse>();
        var context = _mangoDbFixture.Context;
        var handler = new CngGetPublicKeysQueryHandler(context, responseFactory);
        return handler;
    }

    private readonly UserEntity _user = new()
    {
        DisplayName = "razumovsky r",
        Bio = "11011 y.o Dotnet Developer from $\"{cityName}\"",
        Id = SeedDataConstants.RazumovskyId,
        UserName = "razumovsky_r",
        Email = "kolosovp95@gmail.com",
        NormalizedEmail = "KOLOSOVP94@GMAIL.COM",
        EmailConfirmed = true,
        PhoneNumberConfirmed = true,
        Image = "razumovsky_picture.jpg"
    };

    private readonly UserEntity _partner = new()
    {
        DisplayName = "Amelit",
        Bio = "Дипломат",
        Id = SeedDataConstants.AmelitId,
        UserName = "TheMoonlightSonata",
        Email = "amelit@gmail.com",
        NormalizedEmail = "AMELIT@GMAIL.COM",
        EmailConfirmed = true,
        PhoneNumberConfirmed = true,
        Image = "amelit_picture.jpg"
    };
        
    private readonly CngPublicKeyEntity _cngPublicKey = new()
    {
        UserId = SeedDataConstants.RazumovskyId,
        PartnerId = SeedDataConstants.AmelitId,
        PartnerPublicKey = "Public Key"
    };
}