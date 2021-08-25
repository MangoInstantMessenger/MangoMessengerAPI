using MangoAPI.DataAccess.Database.Extensions;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using BusinessExceptions;
    using DataAccess.Database;
    using Domain.Constants;
    using Domain.Entities;
    using MangoAPI.Domain.Enums;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class SendMessageCommandHandler : IRequestHandler<SendMessageCommand, SendMessageResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public SendMessageCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
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
                Id = Guid.NewGuid().ToString(),
                ChatId = request.ChatId,
                UserId = request.UserId,
                Content = request.MessageText,
                Created = DateTime.UtcNow,
                Updated = DateTime.UtcNow,
            };

            await _postgresDbContext.Messages.AddAsync(messageEntity, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return SendMessageResponse.FromSuccess(messageEntity.Id);
        }

        private async Task<bool> CheckUserPermissions(
            UserEntity user,
            ChatEntity chat,
            CancellationToken cancellationToken)
        {
            return chat.ChatType switch
            {
                ChatType.DirectChat => true,
                ChatType.PrivateChannel => await CheckPrivateChannelPermissions(user, chat, cancellationToken),
                ChatType.PublicChannel => await CheckPublicChannelPermissions(user, chat, cancellationToken),
                ChatType.ReadOnlyChannel => await CheckReadOnlyChannelPermissions(user, chat, cancellationToken),
                _ => false,
            };
        }

        private async Task<bool> CheckReadOnlyChannelPermissions(
            UserEntity user,
            ChatEntity chat,
            CancellationToken cancellationToken)
        {
            return (await _postgresDbContext.UserChats
                    .Where(x => x.UserId == user.Id && x.ChatId == chat.Id)
                    .ToListAsync(cancellationToken))
                .Any(x => x.RoleId is UserRole.Moderator or UserRole.Admin or UserRole.Owner);
        }

        private async Task<bool> CheckPublicChannelPermissions(
            UserEntity user,
            ChatEntity chat,
            CancellationToken cancellationToken)
        {
            return await _postgresDbContext.UserChats
                .Where(x => x.UserId == user.Id && x.ChatId == chat.Id)
                .AnyAsync(cancellationToken);
        }

        private async Task<bool> CheckPrivateChannelPermissions(
            UserEntity user,
            ChatEntity chat,
            CancellationToken cancellationToken)
        {
            return await _postgresDbContext.UserChats
                .Where(x => x.UserId == user.Id && x.ChatId == chat.Id)
                .AnyAsync(cancellationToken);
        }
    }
}
