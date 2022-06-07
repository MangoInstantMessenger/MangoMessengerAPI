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

public class VerifyEmailTestShouldThrowInvalidEmailConfirmationCode : IntegrationTestBase
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<ResponseBase> _assert = new();

    [Fact]
    public async Task VerifyEmailTest_ShouldThrowInvalidEmailConfirmationCode()
    {
        const string expectedMessage = ResponseMessageCodes.InvalidEmailConfirmationCode;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        await MangoModule.RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);

        var result = await MangoModule.RequestAsync(
            request: CommandHelper.CreateVerifyEmailCommand("kolosovp95@gmail.com", Guid.NewGuid()), 
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
        EmailConfirmed = false,
        PhoneNumberConfirmed = false,
        Image = "razumovsky_picture.jpg"
    };
}