using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public class SendMessageCommandHandler : IRequestHandler<SendMessageCommand, SendMessageResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IHubContext<ChatHub, IHubClient> _hubContext;

        public SendMessageCommandHandler(MangoPostgresDbContext postgresDbContext,
            IHubContext<ChatHub, IHubClient> hubContext)
        {
            _postgresDbContext = postgresDbContext;
            _hubContext = hubContext;
        }

        public async Task<SendMessageResponse> Handle(SendMessageCommand request, CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            if (user == null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var chat = await _postgresDbContext.Chats.FindChatByIdAsync(request.ChatId, cancellationToken);

            if (chat == null)
            {
                throw new BusinessException(ResponseMessageCodes.ChatNotFound);
            }

            var permitted = await CheckUserPermissions(user, chat, cancellationToken);

            if (!permitted)
            {
                throw new BusinessException(ResponseMessageCodes.PermissionDenied);
            }

            var messageEntity = new MessageEntity
            {
                ChatId = request.ChatId,
                UserId = request.UserId,
                Content = request.MessageText,
                IsEncrypted = request.IsEncrypted,
                AuthorPublicKey = user.PublicKey,
                CreatedAt = DateTime.UtcNow,
                AttachmentPath = request.AttachmentUrl
            };

            chat.UpdatedAt = messageEntity.CreatedAt;

            _postgresDbContext.Chats.Update(chat);
            await _postgresDbContext.Messages.AddAsync(messageEntity, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);
            await _hubContext.Clients.All.BroadcastMessage();
            return SendMessageResponse.FromSuccess(messageEntity.Id);
        }

        private async Task<bool> CheckUserPermissions(UserEntity user, ChatEntity chat,
            CancellationToken cancellationToken)
        {
            return chat.CommunityType switch
            {
                (int) CommunityType.DirectChat => true,
                (int) CommunityType.SecretChat => true,
                (int) CommunityType.PrivateChannel => await CheckPrivateChannelPermissions(user, chat, cancellationToken),
                (int) CommunityType.PublicChannel => await CheckPublicChannelPermissions(user, chat, cancellationToken),
                (int) CommunityType.ReadOnlyChannel => await CheckReadOnlyChannelPermissions(user, chat, cancellationToken),
                _ => false,
            };
        }

        private async Task<bool> CheckReadOnlyChannelPermissions(UserEntity user, ChatEntity chat,
            CancellationToken cancellationToken)
        {
            return (await _postgresDbContext.UserChats
                    .Where(x => x.UserId == user.Id && x.ChatId == chat.Id)
                    .ToListAsync(cancellationToken))
                .Any(x => x.RoleId is (int) UserRole.Moderator or (int) UserRole.Admin or (int) UserRole.Owner);
        }

        private async Task<bool> CheckPublicChannelPermissions(UserEntity user, ChatEntity chat,
            CancellationToken cancellationToken)
        {
            return await _postgresDbContext.UserChats
                .Where(x => x.UserId == user.Id && x.ChatId == chat.Id)
                .AnyAsync(cancellationToken);
        }

        private async Task<bool> CheckPrivateChannelPermissions(UserEntity user, ChatEntity chat,
            CancellationToken cancellationToken)
        {
            return await _postgresDbContext.UserChats
                .Where(x => x.UserId == user.Id && x.ChatId == chat.Id)
                .AnyAsync(cancellationToken);
        }
    }
}