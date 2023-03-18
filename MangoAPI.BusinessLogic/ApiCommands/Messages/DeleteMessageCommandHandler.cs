using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Notifications;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;

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
        var checkMessage = await dbContext.Messages
            .Include(x => x.User)
            .Select(x=> new
            {
                MessageId = x.Id,
                UserId = x.User.Id
            })
            .FirstOrDefaultAsync(t => t.MessageId == request.MessageId, cancellationToken);

        if (checkMessage == null)
        {
            const string errorMessage = ResponseMessageCodes.MessageNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        if (checkMessage.UserId != request.UserId)
        {
            const string errorMessage = ResponseMessageCodes.Unauthorized;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var query = dbContext.UserChats
            .Include(x => x.Chat)
            .ThenInclude(x => x.Messages)
            .ThenInclude(x => x.User)
            .Where(x => x.ChatId == request.ChatId && x.UserId == request.UserId)
            .Select(x => x.Chat);

        var chat = await query.FirstOrDefaultAsync(cancellationToken);

        if (chat == null)
        {
            const string errorMessage = ResponseMessageCodes.ChatNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var deletedMessage = chat.Messages.First(x => x.Id == request.MessageId);

        dbContext.Entry(deletedMessage.User).State = EntityState.Detached;

        var isMessageLast = chat.LastMessageId.HasValue && chat.LastMessageId == request.MessageId;

        var deleteNotification = isMessageLast
            ? UpdateChatLastMessageAndReturnNotification(chat, deletedMessage)
            : CreateNotLastMessageNotification(chat.Id, deletedMessage.Id);

        dbContext.Messages.Remove(deletedMessage);
        dbContext.Chats.Update(chat);

        await dbContext.SaveChangesAsync(cancellationToken);

        await hubContext.Clients.Group(deletedMessage.ChatId.ToString()).MessageDeletedAsync(deleteNotification);

        return responseFactory.SuccessResponse(DeleteMessageResponse.FromSuccess(deletedMessage));
    }

    private static MessageDeleteNotification UpdateChatLastMessageAndReturnNotification(
        ChatEntity chat,
        MessageEntity deletedMessage)
    {
        var newLastMessage = chat.Messages
            .Where(x => x.Id != deletedMessage.Id).MaxBy(x => x.CreatedAt);

        chat.UpdateLastMessage(
            lastMessageAuthor: newLastMessage?.User?.DisplayName,
            lastMessageText: newLastMessage?.Text,
            newLastMessage?.CreatedAt,
            newLastMessage?.Id);

        var deleteNotification = new MessageDeleteNotification(
            chat.Id,
            deletedMessage.Id,
            newLastMessage?.Text,
            newLastMessage?.CreatedAt,
            newLastMessage?.Id,
            newLastMessage?.User?.DisplayName,
            IsLastMessage: true);

        return deleteNotification;
    }

    private static MessageDeleteNotification CreateNotLastMessageNotification(Guid chatId, Guid deletedMessageId)
    {
        var deleteNotification = new MessageDeleteNotification(
            chatId,
            deletedMessageId,
            NewLastMessageText: string.Empty,
            NewLastMessageTime: null,
            NewLastMessageId: null,
            NewLastMessageDisplayName: null,
            IsLastMessage: false);

        return deleteNotification;
    }
}