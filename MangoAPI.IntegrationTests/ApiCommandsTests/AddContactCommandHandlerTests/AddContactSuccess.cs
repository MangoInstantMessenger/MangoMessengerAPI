using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.AddContactCommandHandlerTests;

public class AddContactSuccess : ITestable<AddContactCommand, ResponseBase>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task AddContactsCommandHandlerTest_Success()
    {
        Seed();
        var handler = CreateHandler();
        var command = new AddContactCommand
        {
            UserId = SeedDataConstants.RazumovskyId,
            ContactId = SeedDataConstants.KhachaturId
        };

        var result = await handler.Handle(command, CancellationToken.None);

        _assert.Pass(result);
    }

    public bool Seed()
    {
        _mangoDbFixture.Context.Users.Add(_user1);
        _mangoDbFixture.Context.Users.Add(_user2);

        _mangoDbFixture.Context.SaveChanges();

        _mangoDbFixture.Context.Entry(_user1).State = EntityState.Detached;
        _mangoDbFixture.Context.Entry(_user2).State = EntityState.Detached;

        return true;
    }

    public IRequestHandler<AddContactCommand, Result<ResponseBase>> CreateHandler()
    {
        var responseFactory = new ResponseFactory<ResponseBase>();
        var handler = new AddContactCommandHandler(_mangoDbFixture.Context, responseFactory);
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
}