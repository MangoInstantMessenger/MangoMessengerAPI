using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.DeleteContactCommandHandlerTests;

public class DeleteContactShouldThrowContactNotFound : ITestable<DeleteContactCommand, ResponseBase>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task DeleteContactTestShouldThrow_ContactNotFound()
    {
        Seed();
        const string expectedMessage = ResponseMessageCodes.ContactNotFound;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var handler = CreateHandler();

        var result = await handler.Handle(_command, CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    } 
        
    public bool Seed()
    {
        _mangoDbFixture.Context.Users.AddRange(_user1, _user2);
        _mangoDbFixture.Context.UserContacts.Add(_contact);

        _mangoDbFixture.Context.SaveChanges();
            
        _mangoDbFixture.Context.Entry(_user1).State = EntityState.Detached;
        _mangoDbFixture.Context.Entry(_user2).State = EntityState.Detached;
        _mangoDbFixture.Context.Entry(_contact).State = EntityState.Detached;
            
        return true;
    }

    public IRequestHandler<DeleteContactCommand, Result<ResponseBase>> CreateHandler()
    {
        var responseFactory = new ResponseFactory<ResponseBase>();
        var handler = new DeleteContactCommandHandler(_mangoDbFixture.Context, responseFactory);
            
        return handler;
    }
        
    private readonly UserEntity _user1 = new()
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

    private readonly UserEntity _user2 = new()
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

    private readonly UserContactEntity _contact = new()
    {
        Id = Guid.NewGuid(),
        ContactId = SeedDataConstants.AmelitId,
        UserId = SeedDataConstants.RazumovskyId,
        CreatedAt = DateTime.UtcNow,
    };

    private readonly DeleteContactCommand _command = new()
    {
        UserId = SeedDataConstants.RazumovskyId,
        ContactId = Guid.NewGuid()
    };
}