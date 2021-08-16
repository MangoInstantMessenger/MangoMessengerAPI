using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Chats;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.Domain.Constants;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.Chats
{
    [TestFixture]
    public class CreateDirectChatCommandHandlerTest
    {
        [Test]
        public async Task CreateDirectChatCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new CreateDirectChatCommandHandler(dbContextFixture.PostgresDbContext);
            var createChatCommand = new CreateDirectChatCommand
            {
                UserId = "1",
                PartnerId = "2"
            };

            var result = await handler.Handle(createChatCommand, CancellationToken.None);

            result.Success.Should().BeTrue();
        }

        [Test]
        public async Task CreateDirectChatCommandHandler_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new CreateDirectChatCommandHandler(dbContextFixture.PostgresDbContext);
            var createDirectChatCommand = new CreateDirectChatCommand
            {
                UserId = "3421512523",
                PartnerId = "15241412"
            };

            Func<Task> result = async () => await handler.Handle(createDirectChatCommand, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage("USER_NOT_FOUND");
        }

        [Test]
        public async Task CreateDirectChatCommandHandler_ShouldThrowAlreadyExists()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new CreateDirectChatCommandHandler(dbContextFixture.PostgresDbContext);
            var createDirectChatCommand = new CreateDirectChatCommand
            {
                UserId = "1",
                PartnerId = "2"
            };

            await handler.Handle(createDirectChatCommand, CancellationToken.None);
            Func<Task> result = async () => await handler.Handle(createDirectChatCommand, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.DirectChatAlreadyExists);
        }
    }
}