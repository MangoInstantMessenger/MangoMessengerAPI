using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.HubConfig;
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

        public DeleteMessageCommandHandler(MangoPostgresDbContext postgresDbContext, 
            IHubContext<ChatHub, IHubClient> hubContext, ResponseFactory<DeleteMessageResponse> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _hubContext = hubContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<DeleteMessageResponse>> Handle(DeleteMessageCommand request, 
            CancellationToken cancellationToken)
        {
            var message = await _postgresDbContext.Messages
                .FirstOrDefaultAsync(messageEntity => 
                        messageEntity.Id == request.MessageId && 
                        messageEntity.UserId == request.UserId, cancellationToken);

            if (message == null)
            {
                const string errorMessage = ResponseMessageCodes.MessageNotFound;
                var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, errorDescription);
            }

            var userChat = await _postgresDbContext.UserChats
                .Include(x => x.Chat)
                .FirstOrDefaultAsync(x => x.ChatId == message.ChatId &&
                                          x.UserId == request.UserId, cancellationToken);
            
            if (userChat == null)
            {
                const string errorMessage = ResponseMessageCodes.ChatNotFound;
                var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, errorDescription);
            }

            if (message.Id == message.Chat.LastMessageId)
            {
                var chatMessages = await _postgresDbContext.Messages
                    .AsNoTracking()
                    .Include(x => x.User)
                    .Where(x => x.ChatId == message.ChatId)
                    .ToListAsync(cancellationToken);
                
                var messagesCount = chatMessages.Count;

                if (messagesCount == 1)
                {
                    userChat.Chat.LastMessageId = null;
                    userChat.Chat.LastMessageAuthor = null;
                    userChat.Chat.LastMessageText = null;
                    userChat.Chat.LastMessageTime = null;
                }
                else
                {
                    var previousMessage = chatMessages[messagesCount - 2];
                    userChat.Chat.LastMessageId = previousMessage.Id;
                    userChat.Chat.LastMessageAuthor = previousMessage.User.DisplayName;
                    userChat.Chat.LastMessageText = previousMessage.Content;
                    userChat.Chat.LastMessageTime = previousMessage.UpdatedAt.HasValue 
                        ? previousMessage.UpdatedAt.Value.ToShortTimeString() : previousMessage.CreatedAt.ToShortTimeString();
                }

            }

            _postgresDbContext.Messages.Remove(message);
            _postgresDbContext.Chats.Update(userChat.Chat);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            await _hubContext.Clients.Group(message.ChatId.ToString()).NotifyOnMessageDelete(request.MessageId);
            
            return _responseFactory.SuccessResponse(DeleteMessageResponse.FromSuccess(message));
        }
    }
}