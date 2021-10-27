using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.Domain.Constants;
using NUnit.Framework;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Tests.ApiCommandsTests.Messages
{
    [TestFixture]
    public class EditMessageCommandHandlerTest
    {
        // [Test]
        // public async Task EditMessageCommandHandlerTest_Success()
        // {
        //     using var dbContextFixture = new DbContextFixture();
        //     var handler = new EditMessageCommandHandler(dbContextFixture.PostgresDbContext, MockedObjects.GetHubContext());
        //     var command = new EditMessageCommand
        //     {
        //         UserId = SeedDataConstants.SzymonId,
        //         MessageId = "664b168f-565c-4a94-b2f5-7b199bd1c364".AsGuid(),
        //         ModifiedText = "hello c#",
        //     };
        //
        //     var result = await handler.Handle(command, CancellationToken.None);
        //
        //     result.Response.Success.Should().BeTrue();
        //     result.Error.Should().BeNull();
        // }

        [Test]
        public async Task EditMessageCommandHandlerTest_ShouldThrowMessageNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new EditMessageCommandHandler(dbContextFixture.PostgresDbContext, MockedObjects.GetHubContext());
            var command = new EditMessageCommand
            {
                UserId = SeedDataConstants.SzymonId,
                MessageId = Guid.NewGuid(),
                ModifiedText = "hello c#",
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(ResponseMessageCodes.MessageNotFound);
            result.Response.Should().BeNull();
        }
    }
}