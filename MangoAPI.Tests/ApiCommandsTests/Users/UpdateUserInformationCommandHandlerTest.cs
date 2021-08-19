namespace MangoAPI.Tests.ApiCommandsTests.Users
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using FluentAssertions;
    using MangoAPI.BusinessLogic.ApiCommands.Users;
    using MangoAPI.BusinessLogic.BusinessExceptions;
    using MangoAPI.Domain.Constants;
    using NUnit.Framework;

    [TestFixture]
    public class UpdateUserInformationCommandHandlerTest
    {
        [Test]
        public async Task UpdateUserInformationCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new UpdateUserInformationCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new UpdateUserInformationCommand
            {
                UserId = "1",
                FirstName = "Szymon",
                LastName = "Murawsky",
                BirthDay = new DateTime(1987, 2, 14),
                Address = "Poland, Lvov",
                Facebook = "szymon.murawski",
                Instagram = "szymon.murawski",
                LinkedIn = "szymon.murawski",
                ProfilePicture = "image.jpg",
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Success.Should().BeTrue();
        }

        [Test]
        public async Task UpdateUserInformationCommandHandlerTest_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new UpdateUserInformationCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new UpdateUserInformationCommand
            {
                UserId = "24",
                FirstName = "First Name",
                LastName = "Last Name",
                BirthDay = new DateTime(1999, 1, 1),
                Address = "Address",
                Facebook = "Facebook",
                Instagram = "Instagram",
                LinkedIn = "LinkedIn",
                ProfilePicture = "Profile Picture",
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }
    }
}
