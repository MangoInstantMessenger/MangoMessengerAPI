﻿using System;
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
                UserId = SeedDataConstants.RazumovskyId,
                PartnerId = SeedDataConstants.PetroId,
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
                UserId = Guid.NewGuid(),
                PartnerId = Guid.NewGuid()
            };

            Func<Task> result = async () => await handler.Handle(createDirectChatCommand, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.UserNotFound);
        }

        [Test]
        public async Task CreateDirectChatCommandHandler_ShouldThrowCannotCreateSelf()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new CreateDirectChatCommandHandler(dbContextFixture.PostgresDbContext);
            var createDirectChatCommand = new CreateDirectChatCommand
            {
                UserId = SeedDataConstants.PetroId,
                PartnerId = SeedDataConstants.PetroId,
            };

            Func<Task> result = async () => await handler.Handle(createDirectChatCommand, CancellationToken.None);

            await result.Should().ThrowAsync<BusinessException>()
                .WithMessage(ResponseMessageCodes.CannotCreateSelfChat);
        }
    }
}
