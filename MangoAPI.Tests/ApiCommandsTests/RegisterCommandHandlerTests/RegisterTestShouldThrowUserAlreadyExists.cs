using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.RegisterCommandHandlerTests
{
    public class RegisterTestShouldThrowUserAlreadyExists : ITestable<RegisterCommand, ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();
        private readonly Assert<ResponseBase> _assert = new();

        [Fact]
        public async Task RegisterTestShouldThrow_UserAlreadyExists()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.UserAlreadyExists;
            string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var handler = CreateHandler();

            var result = await handler.Handle(_command, CancellationToken.None);
            
            _assert.Fail(result, expectedMessage, expectedDetails);
        }
        
        public bool Seed()
        {
            _mangoDbFixture.Context.Add(_user);

            _mangoDbFixture.Context.SaveChanges();

            _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;
            
            return true;
        }

        public IRequestHandler<RegisterCommand, Result<ResponseBase>> CreateHandler()
        {
            var emailSenderServiceMock = MockedObjects.GetEmailSenderServiceMock();
            var userServiceMock = MockedObjects.GetUserServiceMock(_command.Password);
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new RegisterCommandHandler(userServiceMock, _mangoDbFixture.Context, emailSenderServiceMock,
                responseFactory);
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
        
        private readonly RegisterCommand _command = new()
        {
            Email = "kolosovp95@gmail.com",
            DisplayName = "Petro Kolosov",
            Password = "Bm3-`dPRv-/w#3)cw^97",
            TermsAccepted = true
        };
    }
}