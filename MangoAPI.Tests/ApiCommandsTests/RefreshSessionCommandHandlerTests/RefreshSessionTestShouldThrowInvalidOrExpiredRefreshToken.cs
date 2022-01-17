using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.RefreshSessionCommandHandlerTests;

public class RefreshSessionTestShouldThrowInvalidOrExpiredRefreshToken 
    : ITestable<RefreshSessionCommand, TokensResponse>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<TokensResponse> _assert = new();

    [Fact]
    public async Task RefreshSessionTestShouldThrow_InvalidOrExpiredRefreshToken()
    {
        Seed();
        const string expectedMessage = ResponseMessageCodes.InvalidOrExpiredRefreshToken;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var handler = CreateHandler();
        var command = new RefreshSessionCommand
        {
            RefreshToken = Guid.NewGuid()
        };

        var result = await handler.Handle(command, CancellationToken.None);
            
        _assert.Fail(result, expectedMessage, expectedDetails);
    }
        
    public bool Seed()
    {
        _mangoDbFixture.Context.Users.Add(_user);

        _mangoDbFixture.Context.SaveChanges();

        _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;

        return true;
    }

    public IRequestHandler<RefreshSessionCommand, Result<TokensResponse>> CreateHandler()
    {
        var context = _mangoDbFixture.Context;
        var responseFactory = new ResponseFactory<TokensResponse>();
        var jwtGenerator = MockedObjects.GetJwtGeneratorMock();
        var handler = new RefreshSessionCommandHandler(context, jwtGenerator, responseFactory);

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
}