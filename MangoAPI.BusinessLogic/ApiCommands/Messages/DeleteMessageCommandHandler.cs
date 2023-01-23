using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public class DeleteMessageCommandHandler
    : IRequestHandler<DeleteMessageCommand, Result<DeleteMessageResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly IHubContext<ChatHub, IHubClient> hubContext;
    private readonly ResponseFactory<DeleteMessageResponse> responseFactory;

    public DeleteMessageCommandHandler(
        MangoDbContext dbContext,
        IHubContext<ChatHub, IHubClient> hubContext,
        ResponseFactory<DeleteMessageResponse> responseFactory)
    {
        this.dbContext = dbContext;
        this.hubContext = hubContext;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<DeleteMessageResponse>> Handle(
        DeleteMessageCommand request,
        CancellationToken cancellationToken)
    {
        var isMessageExists = await dbContext.Messages
            .AnyAsync(t => t.Id == request.MessageId, cancellationToken);

        if (!isMessageExists)
        {
            const string errorMessage = ResponseMessageCodes.MessageNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var query = dbContext.UserChats
            .Include(x => x.Chat)
            .ThenInclude(x => x.Messages)
            .ThenInclude(x => x.User)
            .Where(x => x.ChatId == request.ChatId && x.UserId == request.UserId)
            .Select(x => x.Chat)
            .Where(x => isMessageExists);

        var chat = await query.FirstOrDefaultAsync(cancellationToken);

        // TODO: separate concerns, it is not immediately clear which is null, chat or message?
        // TODO: update tests as well
        if (chat == null)
        {
            const string errorMessage = ResponseMessageCodes.ChatNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var message = chat.Messages.First(x => x.Id == request.MessageId);
        dbContext.Entry(message.User).State = EntityState.Detached;

        var messageDeleteNotification = new MessageDeleteNotification
        {
            MessageId = request.MessageId,
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
            messageDeleteNotification.NewLastMessageTime = newLastMessage?.CreatedAt;

            chat.LastMessageAuthor = newLastMessage?.User?.DisplayName;
            chat.LastMessageId = newLastMessage?.Id;
            chat.LastMessageText = newLastMessage?.Content;
            chat.LastMessageTime = newLastMessage?.CreatedAt;
        }

        _ = dbContext.Messages.Remove(message);
        _ = dbContext.Chats.Update(chat);

        _ = await dbContext.SaveChangesAsync(cancellationToken);

        await hubContext.Clients.Group(message.ChatId.ToString()).NotifyOnMessageDeleteAsync(messageDeleteNotification);

        return responseFactory.SuccessResponse(DeleteMessageResponse.FromSuccess(message));
    }
}
