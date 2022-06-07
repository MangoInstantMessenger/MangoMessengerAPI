using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic;
using MangoAPI.BusinessLogic.ApiQueries.Contacts;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.IntegrationTests.Helpers;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiQueries.GetContactsQueryHandlerTests;

public class GetContactsTestSuccess : IntegrationTestBase
{
    private readonly MangoDbFixture _mangoDbFixture = new();
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