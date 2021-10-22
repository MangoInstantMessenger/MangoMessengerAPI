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
    public class UpdateProfilePictureCommandHandlerTest
    {
        [Test]
        public async Task UpdateProfilePictureCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new UpdateProfilePictureCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new UpdateProfilePictureCommand
            {
                UserId = SeedDataConstants.PetroId,
                Image = "floppa_03ac7bcb-5989-4f9e-9542-b92246d2baf0.JPG"
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
        } 
        
        [Test]
        public async Task UpdateProfilePictureCommandHandlerTest_ShouldThrowUserNotFound ()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new UpdateProfilePictureCommandHandler(dbContextFixture.PostgresDbContext);
            var command = new UpdateProfilePictureCommand
            {
                UserId = Guid.NewGuid(),
                Image = "floppa_03ac7bcb-5989-4f9e-9542-b92246d2baf0.JPG"
            };

            Func<Task> result = async () => await handler.Handle(command, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }
    }
}