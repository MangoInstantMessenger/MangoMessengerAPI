using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.BusinessExceptions;
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
            var handler = new UpdateUserAccountInfoCommandHandler(dbContextFixture.PostgresDbContext);
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

            result.Success.Should().BeTrue();
        }

        [Test]
        public async Task UpdateUserAccountInformationCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new UpdateUserAccountInfoCommandHandler(dbContextFixture.PostgresDbContext);
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

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }
    }
}