using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public class SendMessageCommandHandler
    : IRequestHandler<SendMessageCommand, Result<SendMessageResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly IHubContext<ChatHub, IHubClient> hubContext;
    private readonly ResponseFactory<SendMessageResponse> responseFactory;
    private readonly IBlobServiceSettings blobServiceSettings;

    public SendMessageCommandHandler(
        MangoDbContext dbContext,
        IHubContext<ChatHub, IHubClient> hubContext,
        ResponseFactory<SendMessageResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings)
    {
        this.dbContext = dbContext;
        this.hubContext = hubContext;
        this.responseFactory = responseFactory;
        this.blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<SendMessageResponse>> Handle(
        SendMessageCommand request,
        CancellationToken cancellationToken)
    {
        var user = await dbContext.Users.AsNoTracking()
            .Select(x => new
            {
                x.DisplayName, x.DisplayNameColour, x.Image, x.Id,
            }).FirstOrDefaultAsync(
                x => x.Id == request.UserId,
                cancellationToken);

        if (user == null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.UserNotFound];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var userChat = await dbContext.UserChats.AsNoTracking()
            .Select(x => new { x.ChatId, x.RoleId, x.Chat, }).FirstOrDefaultAsync(
                x => x.ChatId == request.ChatId,
                cancellationToken);

        if (userChat == null)
        {
            const string errorMessage = ResponseMessageCodes.ChatNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var messageEntity = new MessageEntity
        {
            Id = request.MessageId ?? Guid.NewGuid(),
            ChatId = request.ChatId,
            UserId = request.UserId,
            Content = request.MessageText,
            CreatedAt = request.CreatedAt ?? DateTime.UtcNow,
            Attachment = request.AttachmentUrl,
            InReplayToAuthor = request.InReplayToAuthor,
            InReplayToText = request.InReplayToText,
        };

        userChat.Chat.UpdatedAt = messageEntity.CreatedAt;
        userChat.Chat.LastMessageAuthor = user.DisplayName;
        userChat.Chat.LastMessageText = messageEntity.Content;
        userChat.Chat.LastMessageTime = messageEntity.CreatedAt;
        userChat.Chat.LastMessageId = messageEntity.Id;

        dbContext.Chats.Update(userChat.Chat);
        dbContext.Messages.Add(messageEntity);

        await dbContext.SaveChangesAsync(cancellationToken);

        var messageDto = messageEntity.ToMessage(
            user.DisplayName,
            user.Id,
            user.Image,
            blobServiceSettings.MangoBlobAccess,
            user.DisplayNameColour);

        await hubContext.Clients.Group(request.ChatId.ToString()).BroadcastMessageAsync(messageDto);

        return responseFactory.SuccessResponse(SendMessageResponse.FromSuccess(messageEntity.Id));
    }
}