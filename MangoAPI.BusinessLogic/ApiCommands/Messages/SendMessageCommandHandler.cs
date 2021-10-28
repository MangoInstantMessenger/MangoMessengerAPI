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
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public class SendMessageCommandHandler
        : IRequestHandler<SendMessageCommand, Result<SendMessageResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IHubContext<ChatHub, IHubClient> _hubContext;

        public SendMessageCommandHandler(MangoPostgresDbContext postgresDbContext,
            IHubContext<ChatHub, IHubClient> hubContext)
        {
            _postgresDbContext = postgresDbContext;
            _hubContext = hubContext;
        }

        public async Task<Result<SendMessageResponse>> Handle(SendMessageCommand request,
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.AsNoTracking()
                .Select(x => new
                {
                    x.DisplayName,
                    x.Image,
                    x.Id,
                }).FirstOrDefaultAsync(x => x.Id == request.UserId, 
                    cancellationToken);

            if (user == null)
            {
                return new Result<SendMessageResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.UserNotFound,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.UserNotFound],
                        Success = false,
                        StatusCode = HttpStatusCode.Conflict
                    },
                    Response = null,
                    StatusCode = HttpStatusCode.Conflict
                };
            }

            var userChat = await _postgresDbContext.UserChats.AsNoTracking()
                .Select(x => new
                {
                    x.ChatId,
                    x.RoleId,
                    x.Chat
                }).FirstOrDefaultAsync(x => x.ChatId == request.ChatId,
                    cancellationToken);

            if (userChat == null)
            {
                return new Result<SendMessageResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.ChatNotFound,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.ChatNotFound],
                        Success = false,
                        StatusCode = HttpStatusCode.Conflict
                    },
                    Response = null,
                    StatusCode = HttpStatusCode.Conflict
                };
            }

            if (userChat.Chat.CommunityType == (int)CommunityType.ReadOnlyChannel)
            {
                return new Result<SendMessageResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.PermissionDenied,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.PermissionDenied],
                        Success = false,
                        StatusCode = HttpStatusCode.Conflict
                    },
                    Response = null,
                    StatusCode = HttpStatusCode.Conflict
                };
            }

            var messageEntity = new MessageEntity
            {
                ChatId = request.ChatId,
                UserId = request.UserId,
                Content = request.MessageText,
                CreatedAt = DateTime.UtcNow,
                Attachment = request.AttachmentUrl,
                InReplayToAuthor = request.InReplayToAuthor,
                InReplayToText = request.InReplayToText,
            };

            userChat.Chat.UpdatedAt = messageEntity.CreatedAt;
            userChat.Chat.LastMessageAuthor = user.DisplayName;
            userChat.Chat.LastMessageText = messageEntity.Content;
            userChat.Chat.LastMessageTime = messageEntity.CreatedAt.ToShortTimeString();

            _postgresDbContext.Chats.Update(userChat.Chat);
            _postgresDbContext.Messages.Add(messageEntity);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            var messageDto = messageEntity.ToMessage(user.DisplayName, user.Id, user.Image);

            await _hubContext.Clients.Group(request.ChatId.ToString()).BroadcastMessage(messageDto);

            return new Result<SendMessageResponse>
            {
                Error = null,
                Response = SendMessageResponse.FromSuccess(messageEntity.Id),
                StatusCode = HttpStatusCode.OK
            };
        }
    }
}