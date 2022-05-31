using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.LoginCommandHandlerTests;

public class LoginTestShouldThrowInvalidCredentials : ITestable<LoginCommand, TokensResponse>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<TokensResponse> _assert = new();
    private readonly PasswordHashService _passwordHasher = new();
        
    [Fact]
    public async Task LoginTestShouldThrow_InvalidCredentials()
    {
        Seed();
        const string expectedMessage = ResponseMessageCodes.InvalidCredentials;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var command = new LoginCommand
        {
            Email = "kolosovp95@gmail.com",
            Password = "Bm4-`dPRv-/w#3)cw^97"
        };
        var handler = CreateHandler();

        var result = await handler.Handle(command, CancellationToken.None);
            
        _assert.Fail(result, expectedMessage, expectedDetails);
    }
        
    public bool Seed()
    {
        _passwordHasher.HashPassword(_user, "Bm3-`dPRv-/w#3)cw^97");
        _mangoDbFixture.Context.Users.Add(_user);

        _mangoDbFixture.Context.SaveChanges();

        _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;

            
        return true;
    }

    public IRequestHandler<LoginCommand, Result<TokensResponse>> CreateHandler()
    {
        var signInManager = MockedObjects.GetSignInServiceMock(true);
        var jwtGenerator = MockedObjects.GetJwtGeneratorMock();
        var responseFactory = new ResponseFactory<TokensResponse>();
        var jwtSettings = MockedObjects.GetJwtGeneratorSettingsMock();
        var handler =
            new LoginCommandHandler(signInManager, jwtGenerator, _mangoDbFixture.Context, responseFactory, jwtSettings);
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
        Image = "razumovsky_picture.jpg"
    };
}