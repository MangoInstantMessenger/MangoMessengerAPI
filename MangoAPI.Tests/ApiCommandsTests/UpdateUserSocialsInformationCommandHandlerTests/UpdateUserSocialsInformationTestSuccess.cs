using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.UpdateUserSocialsInformationCommandHandlerTests
{
    public class UpdateUserSocialsInformationTestSuccess : ITestable<UpdateUserSocialInformationCommand,ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();
        private readonly Assert<ResponseBase> _assert = new();

        [Fact]
        public async Task UpdateUserSocialsInformationTest_Success()
        {
            Seed();
            var handler = CreateHandler();
            
            var result = await handler.Handle(_command, CancellationToken.None);

            _assert.Pass(result);
        }
        
        public bool Seed()
        {
            _mangoDbFixture.Context.Users.Add(_user);
            _mangoDbFixture.Context.UserInformation.Add(_userInfo);

            _mangoDbFixture.Context.SaveChanges();

            _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;
            _mangoDbFixture.Context.Entry(_userInfo).State = EntityState.Detached;
            
            return true;
        }

        public IRequestHandler<UpdateUserSocialInformationCommand, Result<ResponseBase>> CreateHandler()
        {
            var context = _mangoDbFixture.Context;
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new UpdateUserSocialInformationCommandHandler(context, responseFactory);
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

        private readonly UserInformationEntity _userInfo = new()
        {
            Id = Guid.NewGuid(),
            UserId = SeedDataConstants.RazumovskyId,
            BirthDay = new DateTime(1994, 7, 21),
            Address = "Odessa, Ukraine",
            Website = "razumovsky.com",
            Twitter = "razumovsky_r",
            Facebook = "razumovsky_r",
            Instagram = "razumovsky_r",
            LinkedIn = "razumovsky_r",
        };

        private readonly UpdateUserSocialInformationCommand _command = new()
        {
            UserId = SeedDataConstants.RazumovskyId,
            Instagram = "petro.kolosov",
            LinkedIn = "petro.kolosov",
            Facebook = "petro.kolosov",
            Twitter = "petro.kolosov",
        };
    }
}