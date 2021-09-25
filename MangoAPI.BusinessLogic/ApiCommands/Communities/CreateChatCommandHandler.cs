using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public class CreateChatCommandHandler : IRequestHandler<CreateChatCommand, CreateCommunityResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IHubContext<ChatHub, IHubClient> _hubContext;

        public CreateChatCommandHandler(MangoPostgresDbContext postgresDbContext, IHubContext<ChatHub, IHubClient> hubContext)
        {
            _postgresDbContext = postgresDbContext;
            _hubContext = hubContext;
        }

        public async Task<CreateCommunityResponse> Handle(CreateChatCommand request,
            CancellationToken cancellationToken)
        {
            var partner = await _postgresDbContext.Users.FindUserByIdAsync(request.PartnerId, cancellationToken);

            if (partner is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            if (partner.PublicKey == 0 && request.CommunityType == CommunityType.SecretChat)
            {
                throw new BusinessException(ResponseMessageCodes.UserPublicKeyIsNotGenerated);
            }

            if (request.UserId == request.PartnerId)
            {
                throw new BusinessException(ResponseMessageCodes.CannotCreateSelfChat);
            }

            var currentUser = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            var userPrivateChats = await _postgresDbContext.Chats
                .GetUserChatsAsync(currentUser.Id, cancellationToken);

            var existingChat = userPrivateChats
                .FirstOrDefault(x => x.ChatUsers.Any(t => t.UserId == partner.Id)
                                     && x.CommunityType == (int)request.CommunityType);

            if (existingChat != null)
            {
                return CreateCommunityResponse.FromSuccess(existingChat);
            }

            var chatEntity = new ChatEntity
            {
                Id = Guid.NewGuid(),
                CommunityType = (int)request.CommunityType,
                Title = $"{currentUser.DisplayName} / {partner.DisplayName}",
                CreatedAt = DateTime.UtcNow,
                Description = $"Direct chat between {currentUser.DisplayName} and {partner.DisplayName}",
                MembersCount = 2,
            };

            if (request.CommunityType == CommunityType.SecretChat)
            {
                chatEntity.Description = $"Secret chat between {currentUser.DisplayName} and {partner.DisplayName}";
            }

            var userChats = new[]
            {
                new UserChatEntity {ChatId = chatEntity.Id, RoleId = (int) UserRole.User, UserId = currentUser.Id},
                new UserChatEntity {ChatId = chatEntity.Id, RoleId = (int) UserRole.User, UserId = request.PartnerId},
            };

            await _postgresDbContext.Chats.AddAsync(chatEntity, cancellationToken);
            await _postgresDbContext.UserChats.AddRangeAsync(userChats, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            var chatDto = chatEntity.ToChatDto();
            await _hubContext.Clients.Group(request.UserId.ToString()).UpdateUserChats(chatDto);

            return CreateCommunityResponse.FromSuccess(chatEntity);
        }
    }
}