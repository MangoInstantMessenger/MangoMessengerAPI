using System;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Models;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public class EditMessageCommandHandler
        : IRequestHandler<EditMessageCommand, Result<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IHubContext<ChatHub, IHubClient> _hubContext;
        private readonly ResponseFactory<ResponseBase> _responseFactory;

        public EditMessageCommandHandler(MangoPostgresDbContext postgresDbContext,
            IHubContext<ChatHub, IHubClient> hubContext, ResponseFactory<ResponseBase> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _hubContext = hubContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<ResponseBase>> Handle(EditMessageCommand request,
            CancellationToken cancellationToken)
        {
            var query = _postgresDbContext.UserChats
                .Include(x => x.Chat)
                .ThenInclude(x => x.Messages)
                .ThenInclude(x => x.User)
                .Where(x => x.ChatId == request.ChatId && x.UserId == request.UserId)
                .Select(x => x.Chat)
                .Where(x => x.Messages.Any(t => t.Id == request.MessageId));


            var chat = await query.FirstOrDefaultAsync(cancellationToken);

            if (chat == null)
            {
                const string errorMessage = ResponseMessageCodes.ChatNotFound;
                var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, errorDescription);
            }

            var message = chat.Messages.First(x => x.Id == request.MessageId);
            _postgresDbContext.Entry(message.User).State = EntityState.Detached;

            var messageIsLast = chat.LastMessageId.HasValue && chat.LastMessageId == request.MessageId;
            var updatedAtShortString = DateTime.UtcNow.ToShortTimeString();

            message.Content = request.ModifiedText;
            message.UpdatedAt = DateTime.UtcNow;

            if (messageIsLast)
            {
                chat.LastMessageText = request.ModifiedText;
                chat.LastMessageTime = updatedAtShortString;
            }

            _postgresDbContext.Messages.Update(message);
            _postgresDbContext.Chats.Update(chat);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            var messageDeleteNotification = new MessageEditNotification
            {
                MessageId = request.MessageId,
                ModifiedText = request.ModifiedText,
                UpdatedAt = updatedAtShortString,
                IsLastMessage = messageIsLast,
            };

            await _hubContext.Clients.Group(message.ChatId.ToString())
                .NotifyOnMessageEditAsync(messageDeleteNotification);

            return _responseFactory.SuccessResponse(DeleteMessageResponse.FromSuccess(message));
        }
    }
}