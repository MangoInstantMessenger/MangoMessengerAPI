using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public class DeleteMessageCommandHandler
        : IRequestHandler<DeleteMessageCommand, Result<DeleteMessageResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IHubContext<ChatHub, IHubClient> _hubContext;
        private readonly ResponseFactory<DeleteMessageResponse> _responseFactory;

        public DeleteMessageCommandHandler(
            MangoPostgresDbContext postgresDbContext,
            IHubContext<ChatHub, IHubClient> hubContext,
            ResponseFactory<DeleteMessageResponse> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _hubContext = hubContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<DeleteMessageResponse>> Handle(DeleteMessageCommand request,
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

            var messageDeleteNotification = new MessageDeleteNotification
            {
                MessageId = request.MessageId
            };

            var messageIsLast = chat.LastMessageId.HasValue && chat.LastMessageId == request.MessageId;
            
            if (messageIsLast)
            {
                var newLastMessage = chat.Messages
                    .Where(x => x != message)
                    .OrderBy(x => x.CreatedAt)
                    .LastOrDefault();

                messageDeleteNotification.NewLastMessageAuthor = newLastMessage?.User?.DisplayName;
                messageDeleteNotification.NewLastMessageId = newLastMessage?.Id;
                messageDeleteNotification.NewLastMessageText = newLastMessage?.Content;
                messageDeleteNotification.NewLastMessageTime = newLastMessage?.CreatedAt.ToShortTimeString();

                chat.LastMessageAuthor = newLastMessage?.User?.DisplayName;
                chat.LastMessageId = newLastMessage?.Id;
                chat.LastMessageText = newLastMessage?.Content;
                chat.LastMessageTime = newLastMessage?.CreatedAt.ToShortTimeString();
            }

            _postgresDbContext.Messages.Remove(message);
            _postgresDbContext.Chats.Update(chat);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            await _hubContext.Clients.Group(message.ChatId.ToString()).NotifyOnMessageDeleteAsync(messageDeleteNotification);

            return _responseFactory.SuccessResponse(DeleteMessageResponse.FromSuccess(message));
        }
    }
}