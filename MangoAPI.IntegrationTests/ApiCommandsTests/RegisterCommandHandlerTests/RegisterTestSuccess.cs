﻿using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.RegisterCommandHandlerTests;

public class RegisterTestSuccess : ITestable<RegisterCommand, RegisterResponse>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<RegisterResponse> _assert = new();

    [Fact]
    public async Task RegisterTest_Success()
    {
        Seed();
        var handler = CreateHandler();

        var result = await handler.Handle(_command, CancellationToken.None);

        _assert.Pass(result);
    }

    public bool Seed()
    {
        return true;
    }

    public IRequestHandler<RegisterCommand, Result<RegisterResponse>> CreateHandler()
    {
        var emailSenderServiceMock = MockedObjects.GetEmailSenderServiceMock();
        var userServiceMock = MockedObjects.GetUserServiceMock(_command.Password);
        var responseFactory = new ResponseFactory<RegisterResponse>();
        var mailSettings = MockedObjects.GetMailgunSettings();

        var handler = new RegisterCommandHandler(
            userServiceMock,
            _mangoDbFixture.Context,
            emailSenderServiceMock,
            responseFactory,
            mailSettings);

        return handler;
    }

    private readonly RegisterCommand _command = new()
    {
        Email = "kolosovp95@gmail.com",
        DisplayName = "Petro Kolosov",
        Password = "Bm3-`dPRv-/w#3)cw^97",
        TermsAccepted = true
    };
}