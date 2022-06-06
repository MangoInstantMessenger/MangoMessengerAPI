using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.RequestPasswordRestoreCommandHandlerTests;

public class RequestPasswordRestoreTestShouldThrowChangePasswordRequestExists 
    : ITestable<RequestPasswordRestoreCommand, RequestPasswordRestoreResponse>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<RequestPasswordRestoreResponse> _assert = new();

    [Fact]
    public async Task RequestPasswordRestoreTestShouldThrow_ChangePasswordRequestExists()
    {
        Seed();
        const string expectedMessage = ResponseMessageCodes.ChangePasswordRequestExists;
        string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
        var handler = CreateHandler();
        var command = new RequestPasswordRestoreCommand
        {
            Email = _user.Email
        };

        var result = await handler.Handle(command, CancellationToken.None);

        _assert.Fail(result, expectedMessage, expectedDetails);
    }
        
    public bool Seed()
    {
        _mangoDbFixture.Context.Users.Add(_user);
        _mangoDbFixture.Context.PasswordRestoreRequests.Add(new PasswordRestoreRequestEntity
        {
            Id = Guid.NewGuid(),
            UserId = SeedDataConstants.RazumovskyId,
            Email = _user.Email,
            CreatedAt = DateTime.UtcNow,
            ExpiresAt = DateTime.UtcNow.AddHours(3)
        });

        _mangoDbFixture.Context.SaveChanges();

        _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;
            
        return true;
    }

    public IRequestHandler<RequestPasswordRestoreCommand, Result<RequestPasswordRestoreResponse>> CreateHandler()
    {
        var emailSenderService = MockedObjects.GetEmailSenderServiceMock();
        var responseFactory = new ResponseFactory<RequestPasswordRestoreResponse>();

        var handler =
            new RequestPasswordRestoreCommandHandler(_mangoDbFixture.Context, emailSenderService, responseFactory);

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