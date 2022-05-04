using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Contacts;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiQueries.GetContactsQueryHandlerTests;

public class GetContactsTestSuccess : ITestable<GetContactsQuery, GetContactsResponse>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<GetContactsResponse> _assert = new();

    [Fact]
    public async Task GetContactsTest_Success()
    {
        Seed();
        var handler = CreateHandler();
        var query = new GetContactsQuery
        {
            UserId = SeedDataConstants.KhachaturId
        };

        var result = await handler.Handle(query, CancellationToken.None);
            
        _assert.Pass(result);
        result.Response.Contacts.Count.Should().Be(1);
        result.Response.Contacts[0].UserId.Should().Be(_user2.Id);
    }
        
    public bool Seed()
    {
        _mangoDbFixture.Context.Users.Add(_user1);
        _mangoDbFixture.Context.Users.Add(_user2);
        _mangoDbFixture.Context.UserContacts.Add(_contact);

        _mangoDbFixture.Context.SaveChanges();

        _mangoDbFixture.Context.Entry(_user1).State = EntityState.Detached;
        _mangoDbFixture.Context.Entry(_user2).State = EntityState.Detached;
        _mangoDbFixture.Context.Entry(_contact).State = EntityState.Detached;

        return true;
    }

    public IRequestHandler<GetContactsQuery, Result<GetContactsResponse>> CreateHandler()
    {
        var responseFactory = new ResponseFactory<GetContactsResponse>();
        var blobSettings = MockedObjects.GetBlobServiceSettingsMock();
        var handler = new GetContactsQueryHandler(_mangoDbFixture.Context, responseFactory, blobSettings);
        return handler;
    }
        
    private readonly UserEntity _user1 = new()
    {
        DisplayName = "Khachatur Khachatryan",
        Bio = "13 y. o. | C# pozer, Hearts Of Iron IV noob",
        Id = SeedDataConstants.KhachaturId,
        UserName = "KHACHATUR228",
        Email = "xachulxx@gmail.com",
        NormalizedEmail = "XACHULXX@GMAIL.COM",
        EmailConfirmed = true,
        PhoneNumberConfirmed = true,
        Image = "khachatur_picture.jpg",
    };

    private readonly UserEntity _user2 = new()
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

    private readonly UserContactEntity _contact = new()
    {
        Id = Guid.NewGuid(),
        UserId = SeedDataConstants.KhachaturId,
        ContactId = SeedDataConstants.RazumovskyId,
        CreatedAt = DateTime.UtcNow
    };
}