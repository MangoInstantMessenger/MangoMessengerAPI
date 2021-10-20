using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using Microsoft.AspNetCore.SignalR;
using NUnit.Framework;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Tests.ApiCommandsTests.Communities
{
    [TestFixture]
    public class CreateChatCommandHandlerTest
    {
        private static readonly IHubContext<ChatHub, IHubClient> Hub = MockedObjects.GetHubContext();

        [Test]
        public async Task CreateDirectChatCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new CreateChatCommandHandler(dbContextFixture.PostgresDbContext, Hub);

            var createChatCommand = new CreateChatCommand
            {
                UserId = SeedDataConstants.RazumovskyId,
                PartnerId = SeedDataConstants.PetroId,
                CommunityType = CommunityType.DirectChat
            };

            var result = await handler.Handle(createChatCommand, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
        }

        [Test]
        public async Task CreateDirectChatCommandHandler_ShouldThrowUserNotFound()
        {
            using var dbContextFixture = new DbContextFixture();
            var handler = new CreateChatCommandHandler(dbContextFixture.PostgresDbContext, Hub);
            var createDirectChatCommand = new CreateChatCommand
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
            var handler = new CreateChatCommandHandler(dbContextFixture.PostgresDbContext, Hub);
            var createDirectChatCommand = new CreateChatCommand
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