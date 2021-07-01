using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MangoAPI.DTO.Commands;
using MangoAPI.DTO.Commands.Messages;
using MangoAPI.DTO.Models;
using MangoAPI.DTO.Responses.Messages;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace MangoAPI.Infrastructure.CommandHandlers.Messages
{
    public class SendMessageCommandHandler : IRequestHandler<SendMessageCommand, SendMessageResponse>
    {
        private readonly MangoPostgresDbContext _db;
        private readonly IChatNotificationService _chatNotificationService;

        public SendMessageCommandHandler(MangoPostgresDbContext db, IChatNotificationService chatNotificationService)
        {
            _db = db;
            _chatNotificationService = chatNotificationService;
        }

        public async Task<SendMessageResponse> Handle(SendMessageCommand request, CancellationToken cancellationToken)
        {
            var user = await GetUserAsync(request.UserId, cancellationToken);
            if (user == null)
                return SendMessageResponse.UserNotFound;

            var chat = await GetChatAsync(request.ChatId, cancellationToken);
            if (chat == null)
                return SendMessageResponse.ChatNotFoundResponse;

            if (!await CheckUserPermissions(user, chat, cancellationToken))
                return SendMessageResponse.UserDontHavePermissions;

            var dbMessage = await SaveMessage(request, cancellationToken);
            var messageDto = new Message()
            {
                SentAt = dbMessage.Created,
                MessageText = dbMessage.Content,
                UserDisplayName = user.DisplayName
            };
            await _chatNotificationService.NotifyChatUsersAsync(chat.Id, messageDto, cancellationToken);
            return SendMessageResponse.FromSuccess(messageDto);
        }

        private async Task<MessageEntity> SaveMessage(SendMessageCommand request, CancellationToken cancellationToken)
        {
            var messageEntity = new MessageEntity()
            {
                ChatId = request.ChatId,
                UserId = request.UserId,
                Content = request.Content,
                Created = DateTime.UtcNow,
            };

            messageEntity = _db.Messages.Add(messageEntity).Entity;
            await _db.SaveChangesAsync(cancellationToken);
            return messageEntity;
        }

        private async Task<bool> CheckUserPermissions(UserEntity user, ChatEntity chat, CancellationToken cancellationToken)
        {
            return chat.ChatType switch
            {
                ChatType.DirectChat => await CheckForPersonalIgnoreList(user, chat, cancellationToken),
                ChatType.PrivateChannel => await CheckPrivateChannelPermissions(user, chat, cancellationToken),
                ChatType.PublicChannel => await CheckPublicChannelPermissions(user, chat, cancellationToken),
                ChatType.ReadOnlyChannel => await CheckReadOnlyChannelPermissions(user, chat, cancellationToken),
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private async Task<bool> CheckReadOnlyChannelPermissions(UserEntity user, ChatEntity chat, CancellationToken cancellationToken) =>
            (await _db.UserChats
                .Where(x => x.UserId == user.Id && x.ChatId == chat.Id)
                .ToListAsync(cancellationToken))
            .Any(x => x.RoleId is UserRole.Moderator or UserRole.Admin or UserRole.Owner);

        private async Task<bool> CheckPublicChannelPermissions(UserEntity user, ChatEntity chat, CancellationToken cancellationToken) =>
            await _db.UserChats
                .Where(x => x.UserId == user.Id && x.ChatId == chat.Id)
                .AnyAsync(cancellationToken);

        private async Task<bool> CheckPrivateChannelPermissions(UserEntity user, ChatEntity chat, CancellationToken cancellationToken) =>
            await _db.UserChats
                .Where(x => x.UserId == user.Id && x.ChatId == chat.Id)
                .AnyAsync(cancellationToken);

        private async Task<bool> CheckForPersonalIgnoreList(UserEntity user, ChatEntity chat, CancellationToken cancellationToken)
        {
            return true; // ToDo implement
        }

        private async Task<ChatEntity> GetChatAsync(int requestChatId, CancellationToken cancellationToken)
        {
            var chat = await _db.Chats.FirstOrDefaultAsync(x => x.Id == requestChatId, cancellationToken);
            return chat;
        }

        async Task<UserEntity> GetUserAsync(string userId, CancellationToken cancellationToken)
        {
            var user = await _db.Users.FirstOrDefaultAsync(x => x.Id == userId, cancellationToken);
            return user;
        }
    }
}