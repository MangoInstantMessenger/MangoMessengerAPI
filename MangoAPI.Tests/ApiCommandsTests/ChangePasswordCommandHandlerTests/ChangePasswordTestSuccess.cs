using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.ChangePasswordCommandHandlerTests
{
    public class ChangePasswordTestSuccess : ITestable<ChangePasswordCommand, ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();
        private readonly Assert<ResponseBase> _assert = new();
        private readonly PasswordHashService _passwordHasher = new();

        [Fact]
        public async Task ChangePasswordTest_Success()
        {
            Seed();
            var handler = CreateHandler();
            var command = new ChangePasswordCommand
            {
                UserId = _user.Id,
                CurrentPassword = "Bm3-`dPRv-/w#3)cw^97",
                NewPassword = "Gm3-`xPRr-/q#6)re^94",
                RepeatNewPassword = "Gm3-`xPRr-/q#6)re^94"
            };

            var result = await handler.Handle(command, CancellationToken.None);
            
            _assert.Pass(result);
        }
        
        public bool Seed()
        {
            _passwordHasher.HashPassword(_user, "Bm3-`dPRv-/w#3)cw^97");
            _mangoDbFixture.Context.Users.Add(_user);

            _mangoDbFixture.Context.SaveChanges();

            _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;

            
            return true;
        }

        public IRequestHandler<ChangePasswordCommand, Result<ResponseBase>> CreateHandler()
        {
            var userManagerMock = MockedObjects.GetUserServiceMock("Bm3-`dPRv-/w#3)cw^97");
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new ChangePasswordCommandHandler(_mangoDbFixture.Context, userManagerMock, responseFactory);
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