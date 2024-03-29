﻿using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public class EditMessageCommandHandler
    : IRequestHandler<EditMessageCommand, Result<ResponseBase>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<ResponseBase> responseFactory;

    public EditMessageCommandHandler(
        MangoDbContext dbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(
        EditMessageCommand request,
        CancellationToken cancellationToken)
    {
        var checkMessage = await dbContext.Messages
            .Include(x => x.User)
            .FirstOrDefaultAsync(t => t.Id == request.MessageId, cancellationToken);

        if (checkMessage == null)
        {
            const string errorMessage = ResponseMessageCodes.MessageNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        if (checkMessage.User.Id != request.UserId)
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

        var message = chat.Messages.First(x => x.Id == request.MessageId);
        dbContext.Entry(message.User).State = EntityState.Detached;

        var messageIsLast = chat.LastMessageId.HasValue && chat.LastMessageId == request.MessageId;
        var updatedAt = DateTime.UtcNow;

        message.UpdateMessageText(request.ModifiedText);

        if (messageIsLast)
        {
            chat.UpdateLastMessage(request.ModifiedText, updatedAt);
        }

        dbContext.Messages.Update(message);
        dbContext.Chats.Update(chat);

        await dbContext.SaveChangesAsync(cancellationToken);

        return responseFactory.SuccessResponse(DeleteMessageResponse.FromSuccess(message));
    }
}