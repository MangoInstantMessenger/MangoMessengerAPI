using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public class SendMessageCommandHandler 
        : IRequestHandler<SendMessageCommand, GenericResponse<SendMessageResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IHubContext<ChatHub, IHubClient> _hubContext;

        public SendMessageCommandHandler(MangoPostgresDbContext postgresDbContext,
            IHubContext<ChatHub, IHubClient> hubContext)
        {
            _postgresDbContext = postgresDbContext;
            _hubContext = hubContext;
        }

        public async Task<GenericResponse<SendMessageResponse>> Handle(SendMessageCommand request, 
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == request.UserId,
                    cancellationToken);

            if (user == null)
            {
                return new GenericResponse<SendMessageResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.UserNotFound,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.UserNotFound],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var chat = await _postgresDbContext.Chats.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == request.ChatId, cancellationToken);

            if (chat == null)
            {
                return new GenericResponse<SendMessageResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.ChatNotFound,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.ChatNotFound],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var permitted = await CheckUserPermissions(user, chat, cancellationToken);

            if (!permitted)
            {
                return new GenericResponse<SendMessageResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.PermissionDenied,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.PermissionDenied],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var messageEntity = new MessageEntity
            {
                ChatId = request.ChatId,
                UserId = request.UserId,
                Content = request.MessageText,
                IsEncrypted = request.IsEncrypted,
                AuthorPublicKey = user.PublicKey,
                CreatedAt = DateTime.UtcNow,
                Attachment = request.AttachmentUrl,
                InReplayToAuthor = request.InReplayToAuthor,
                InReplayToText = request.InReplayToText,
            };

            chat.UpdatedAt = messageEntity.CreatedAt;

            _postgresDbContext.Chats.Update(chat);
            _postgresDbContext.Messages.Add(messageEntity);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            var messageDto = messageEntity.ToMessage(user);

            await _hubContext.Clients.Group(chat.Id.ToString()).BroadcastMessage(messageDto);

            return new GenericResponse<SendMessageResponse>
            {
                Error = null,
                Response = SendMessageResponse.FromSuccess(messageEntity.Id),
                StatusCode = 200
            };
        }

        private async Task<bool> CheckUserPermissions(UserEntity user, ChatEntity chat,
            CancellationToken cancellationToken)
        {
            return chat.CommunityType switch
            {
                (int)CommunityType.DirectChat => true,
                (int)CommunityType.SecretChat => true,
                (int)CommunityType.PrivateChannel => await CheckChannelPermissions(user, chat, cancellationToken),
                (int)CommunityType.PublicChannel => await CheckChannelPermissions(user, chat, cancellationToken),
                (int)CommunityType.ReadOnlyChannel => await CheckReadOnlyChannelPermissions(user, chat, cancellationToken),
                _ => false,
            };
        }

        private async Task<bool> CheckReadOnlyChannelPermissions(UserEntity user, ChatEntity chat,
            CancellationToken cancellationToken)
        {
            return await _postgresDbContext.UserChats
                .AsNoTracking()
                .AnyAsync(x => x.UserId == user.Id && x.ChatId == chat.Id && x.RoleId == (int)UserRole.Owner,
                    cancellationToken);
        }

        private async Task<bool> CheckChannelPermissions(UserEntity user, ChatEntity chat,
            CancellationToken cancellationToken)
        {
            return await _postgresDbContext.UserChats.AsNoTracking()
                .Where(x => x.UserId == user.Id && x.ChatId == chat.Id)
                .AnyAsync(cancellationToken);
        }
    }
}