using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.IntegrationTests.Helpers;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.VerifyEmailCommandHandlerTests;

public class VerifyEmailTestShouldThrowEmailAlreadyVerified : IntegrationTestBase
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task VerifyEmailTestShouldThrow_EmailAlreadyVerified()
    {
        Seed();
        const string expectedMessage = ResponseMessageCodes.EmailAlreadyVerified;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var user = await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var userId = user.Response.UserId;
        var userEntity = await DbContextFixture.Users.FirstOrDefaultAsync(x => x.Id == userId);
        await MangoModule.RequestAsync(
            request: CommandHelper.CreateVerifyEmailCommand(userEntity.Email, userEntity.EmailCode),
            cancellationToken: CancellationToken.None);
            
        var result = await MangoModule.RequestAsync(
            request: CommandHelper.CreateVerifyEmailCommand(userEntity.Email, userEntity.EmailCode),
            cancellationToken: CancellationToken.None);
            
        _assert.Fail(result, expectedMessage, expectedDetails);
    }

    public bool Seed()
    {
        _mangoDbFixture.Context.Users.Add(_user);

        _mangoDbFixture.Context.SaveChanges();

        _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;
            
        return true;
    }

    public IRequestHandler<VerifyEmailCommand, Result<ResponseBase>> CreateHandler()
    {
        var context = _mangoDbFixture.Context;
        var responseFactory = new ResponseFactory<ResponseBase>();
        var handler = new VerifyEmailCommandHandler(context, responseFactory);
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
        EmailCode = Guid.NewGuid(),
        EmailConfirmed = true,
        PhoneNumberConfirmed = false,
        Image = "razumovsky_picture.jpg"
    };
}