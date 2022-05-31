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

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public class EditMessageCommandHandler
    : IRequestHandler<EditMessageCommand, Result<ResponseBase>>
{
    private readonly MangoDbContext _dbContext;
    private readonly IHubContext<ChatHub, IHubClient> _hubContext;
    private readonly ResponseFactory<ResponseBase> _responseFactory;

    public EditMessageCommandHandler(
        MangoDbContext dbContext,
        IHubContext<ChatHub, IHubClient> hubContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        _dbContext = dbContext;
        _hubContext = hubContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(EditMessageCommand request,
        CancellationToken cancellationToken)
    {
        var isMessageExists = await _dbContext.Messages
            .AnyAsync(t => t.Id == request.MessageId, cancellationToken);
            
        if (!isMessageExists)
        {
            const string errorMessage = ResponseMessageCodes.MessageNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var query = _dbContext.UserChats
            .Include(x => x.Chat)
            .ThenInclude(x => x.Messages)
            .ThenInclude(x => x.User)
            .Where(x => x.ChatId == request.ChatId && x.UserId == request.UserId)
            .Select(x => x.Chat)
            .Where(x => isMessageExists);
            
        var chat = await query.FirstOrDefaultAsync(cancellationToken);
            
        if (chat == null)
        {
            const string errorMessage = ResponseMessageCodes.ChatNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var message = chat.Messages.First(x => x.Id == request.MessageId);
        _dbContext.Entry(message.User).State = EntityState.Detached;

        var messageIsLast = chat.LastMessageId.HasValue && chat.LastMessageId == request.MessageId;
        var updatedAt = DateTime.UtcNow;

        message.Content = request.ModifiedText;
        message.UpdatedAt = DateTime.UtcNow;

        if (messageIsLast)
        {
            chat.LastMessageText = request.ModifiedText;
            chat.LastMessageTime = updatedAt;
        }

        _dbContext.Messages.Update(message);
        _dbContext.Chats.Update(chat);

        await _dbContext.SaveChangesAsync(cancellationToken);

        var messageDeleteNotification = new MessageEditNotification
        {
            MessageId = request.MessageId,
            ModifiedText = request.ModifiedText,
            UpdatedAt = updatedAt,
            IsLastMessage = messageIsLast,
        };

        await _hubContext.Clients.Group(message.ChatId.ToString())
            .NotifyOnMessageEditAsync(messageDeleteNotification);

        return _responseFactory.SuccessResponse(DeleteMessageResponse.FromSuccess(message));
    }
}