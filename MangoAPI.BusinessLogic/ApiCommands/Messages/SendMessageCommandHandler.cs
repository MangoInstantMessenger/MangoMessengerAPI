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
        : IRequestHandler<SendMessageCommand, Result<SendMessageResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IHubContext<ChatHub, IHubClient> _hubContext;
        private readonly ResponseFactory<SendMessageResponse> _responseFactory;

        public SendMessageCommandHandler(
            MangoPostgresDbContext postgresDbContext,
            IHubContext<ChatHub, IHubClient> hubContext,
            ResponseFactory<SendMessageResponse> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _hubContext = hubContext;
            _responseFactory = responseFactory;
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
                const string errorMessage = ResponseMessageCodes.UserNotFound;
                var errorDescription = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.UserNotFound];

                return _responseFactory.ConflictResponse(errorMessage, errorDescription);
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
                const string errorMessage = ResponseMessageCodes.ChatNotFound;
                var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, errorDescription);
            }

            var messageCount = await _postgresDbContext.Messages
                .AsNoTracking()
                .Where(x => x.UserId == request.UserId)
                .Where(x => x.CreatedAt >= DateTime.UtcNow.Date.AddMinutes(-5))
                .CountAsync(cancellationToken);

            if (messageCount >= 100)
            {
                const string errorMessage = ResponseMessageCodes.MaximumMessageCountInLast5MinutesExceeded100;
                var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, errorDescription);
            }

            if (userChat.Chat.CommunityType == (int) CommunityType.ReadOnlyChannel)
            {
                const string errorMessage = ResponseMessageCodes.PermissionDenied;
                var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, errorDescription);
            }

            var messageEntity = new MessageEntity
            {
                Id = Guid.NewGuid(),
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
            userChat.Chat.LastMessageId = messageEntity.Id;

            _postgresDbContext.Chats.Update(userChat.Chat);
            _postgresDbContext.Messages.Add(messageEntity);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            var messageDto = messageEntity.ToMessage(user.DisplayName, user.Id, user.Image);

            await _hubContext.Clients.Group(request.ChatId.ToString()).BroadcastMessageAsync(messageDto);

            return _responseFactory.SuccessResponse(SendMessageResponse.FromSuccess(messageEntity.Id));
        }
    }
}