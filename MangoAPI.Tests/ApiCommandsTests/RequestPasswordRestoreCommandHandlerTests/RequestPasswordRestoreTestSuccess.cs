using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.RequestPasswordRestoreCommandHandlerTests
{
    public class RequestPasswordRestoreTestSuccess : ITestable<RequestPasswordRestoreCommand, ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();

        [Fact]
        public async Task RequestPasswordRestoreTest_Success()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.Success;
            var handler = CreateHandler();
            var command = new RequestPasswordRestoreCommand
            {
                Email = _user.Email
            };

            var result = await handler.Handle(command, CancellationToken.None);
            
            result.StatusCode.Should().Be(HttpStatusCode.OK);
            result.Response.Message.Should().Be(expectedMessage);
            result.Response.Success.Should().BeTrue();
            result.Error.Should().BeNull();
        }
        
        public bool Seed()
        {
            _mangoDbFixture.Context.Users.Add(_user);

            _mangoDbFixture.Context.SaveChanges();

            _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;
            
            return true;
        }

        public IRequestHandler<RequestPasswordRestoreCommand, Result<ResponseBase>> CreateHandler()
        {
            var emailSenderService = MockedObjects.GetEmailSenderServiceMock();
            var responseFactory = new ResponseFactory<ResponseBase>();

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
}