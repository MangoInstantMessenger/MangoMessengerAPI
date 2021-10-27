using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.Users
{
    [TestFixture]
    public class UpdateUserSocialInformationCommandHandlerTest
    {
        [Test]
        public async Task UpdateUserSocialInformationCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new UpdateUserSocialInformationCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new UpdateUserSocialInformationCommand
            {
                UserId = SeedDataConstants.PetroId,
                Facebook = "kolosov.petro",
                Twitter = "kolosovPetro",
                Instagram = "razumovsky",
                LinkedIn = "Kolosov Petro"
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
            result.Error.Should().BeNull();
        }
        
        [Test]
        public async Task UpdateUserSocialInformationCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new UpdateUserSocialInformationCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new UpdateUserSocialInformationCommand
            {
                UserId = Guid.NewGuid(),
                Facebook = "hello world",
                Twitter = "hello world",
                Instagram = "hello world",
                LinkedIn = "hello world"
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.UserNotFound);
            result.Response.Should().BeNull();
        }
    }
}