using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiQueries.GetUserQueryHandlerTests;

public class GetUserQuerySuccess 
    : ITestable<GetUserQuery, GetUserResponse>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<GetUserResponse> _assert = new();

    [Fact]
    public async Task GetUserTest_Success()
    {
        Seed();
        var query = new GetUserQuery
        {
            UserId = _user.Id
        };
        var handler = CreateHandler();

        var result = await handler.Handle(query, CancellationToken.None);
            
        _assert.Pass(result);
        result.Response.User.UserId.Should().Be(_user.Id);
    }
        
    public bool Seed()
    {
        _mangoDbFixture.Context.Users.Add(_user);

        _mangoDbFixture.Context.SaveChanges();

        _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;
            
        return true;
    }

    public IRequestHandler<GetUserQuery, Result<GetUserResponse>> CreateHandler()
    {
        var responseFactory = new ResponseFactory<GetUserResponse>();
        var blobSettings = MockedObjects.GetBlobServiceSettingsMock();
        var handler = new GetUserQueryHandler(_mangoDbFixture.Context, responseFactory, blobSettings);
        return handler;
    }
        
    private readonly UserEntity _user = new()
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
}