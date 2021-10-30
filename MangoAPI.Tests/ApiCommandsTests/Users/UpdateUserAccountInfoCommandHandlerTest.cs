using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.Users
{
    [TestFixture]
    public class UpdateUserAccountInfoCommandHandlerTest
    {
        [Test]
        public async Task UpdateUserAccountInformationCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new UpdateUserAccountInfoCommandHandler(dbContextFixture.PostgresDbContext,responseFactory);
            var command = new UpdateUserAccountInfoCommand
            {
                UserId = SeedDataConstants.PetroId,
                PhoneNumber = "544390737573",
                BirthdayDate = DateTime.UtcNow,
                Email = "petro.kolosov@wp.pl",
                Website = null,
                Username = "PetroKolosov",
                DisplayName = "Petro Kolosov",
                Bio = "",
                Address = "Poland, Poznan"
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
            result.Error.Should().BeNull();
        }

        [Test]
        public async Task UpdateUserAccountInformationCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new UpdateUserAccountInfoCommandHandler(dbContextFixture.PostgresDbContext,responseFactory);
            var command = new UpdateUserAccountInfoCommand
            {
                UserId = Guid.NewGuid(),
                PhoneNumber = "544390737573",
                BirthdayDate = DateTime.UtcNow,
                Email = "petro.kolosov@wp.pl",
                Website = null,
                Username = "PetroKolosov",
                DisplayName = "Petro Kolosov",
                Bio = "",
                Address = "Poland, Poznan"
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.UserNotFound);
            result.Response.Should().BeNull();
        }
    }
}