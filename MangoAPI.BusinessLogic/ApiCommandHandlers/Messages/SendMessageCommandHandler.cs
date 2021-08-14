using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses.Messages;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommandHandlers.Messages
{
    public class SendMessageCommandHandler : IRequestHandler<SendMessageCommand, SendMessageResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;

        public SendMessageCommandHandler(MangoPostgresDbContext postgresDbContext,
            UserManager<UserEntity> userManager)
        {
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
        }

        public async Task<SendMessageResponse> Handle(SendMessageCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);

            if (user == null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var chat = await _postgresDbContext.Chats.FirstOrDefaultAsync(x => x.Id == request.ChatId,
                cancellationToken);

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
                Updated = DateTime.UtcNow
            };

            await _postgresDbContext.Messages.AddAsync(messageEntity, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return SendMessageResponse.FromSuccess(messageEntity.Id);
        }

        private async Task<bool> CheckUserPermissions(UserEntity user, ChatEntity chat,
            CancellationToken cancellationToken)
        {
            return chat.ChatType switch
            {
                ChatType.DirectChat => true,
                ChatType.PrivateChannel => await CheckPrivateChannelPermissions(user, chat, cancellationToken),
                ChatType.PublicChannel => await CheckPublicChannelPermissions(user, chat, cancellationToken),
                ChatType.ReadOnlyChannel => await CheckReadOnlyChannelPermissions(user, chat, cancellationToken),
                _ => false
            };
        }

        private async Task<bool> CheckReadOnlyChannelPermissions(UserEntity user, ChatEntity chat,
            CancellationToken cancellationToken)
        {
            return (await _postgresDbContext.UserChats
                    .Where(x => x.UserId == user.Id && x.ChatId == chat.Id)
                    .ToListAsync(cancellationToken))
                .Any(x => x.RoleId is UserRole.Moderator or UserRole.Admin or UserRole.Owner);
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