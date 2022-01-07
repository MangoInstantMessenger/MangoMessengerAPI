using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.UpdateUserAccountInfoCommandHandlerTests
{
    public class UpdateUserAccountInfoTestSuccess : ITestable<UpdateUserAccountInfoCommand, ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();

        [Fact]
        public async Task UpdateUserAccountInfoTest_Success()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.Success;
            var handler = CreateHandler();

            var result = await handler.Handle(_command, CancellationToken.None);
            
            result.StatusCode.Should().Be(HttpStatusCode.OK);
            result.Response.Success.Should().BeTrue();
            result.Response.Message.Should().Be(expectedMessage);
            result.Error.Should().BeNull();
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

        public IRequestHandler<UpdateUserAccountInfoCommand, Result<ResponseBase>> CreateHandler()
        {
            var context = _mangoDbFixture.Context;
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new UpdateUserAccountInfoCommandHandler(context, responseFactory);
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

        private readonly UpdateUserAccountInfoCommand _command = new()
        {
            UserId = SeedDataConstants.RazumovskyId,
            Username = "Petro_Kolosov",
            DisplayName = "Petro Kolosov",
            Website = "pkolosov.com",
            Bio = "Third year student of WSB at Poznan",
            Address = "Poznan, Poland",
            BirthdayDate = new DateTime(1994, 6, 12)
        };
    }
}