using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Infrastructure.Database;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public class SendMessageCommandHandler
    : IRequestHandler<SendMessageCommand, Result<SendMessageResponse>>
{
    private readonly MangoDbContext _dbContext;
    private readonly IHubContext<ChatHub, IHubClient> _hubContext;
    private readonly ResponseFactory<SendMessageResponse> _responseFactory;
    private readonly IBlobServiceSettings _blobServiceSettings;

    public SendMessageCommandHandler(
        MangoDbContext dbContext,
        IHubContext<ChatHub, IHubClient> hubContext,
        ResponseFactory<SendMessageResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings)
    {
        _dbContext = dbContext;
        _hubContext = hubContext;
        _responseFactory = responseFactory;
        _blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<SendMessageResponse>> Handle(SendMessageCommand request,
        CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users.AsNoTracking()
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

        var userChat = await _dbContext.UserChats.AsNoTracking()
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

        var messageCount = await _dbContext.Messages
            .AsNoTracking()
            .Where(x => x.UserId == request.UserId)
            .CountAsync(cancellationToken);

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
        userChat.Chat.LastMessageTime = messageEntity.CreatedAt;
        userChat.Chat.LastMessageId = messageEntity.Id;

        _dbContext.Chats.Update(userChat.Chat);
        _dbContext.Messages.Add(messageEntity);

        await _dbContext.SaveChangesAsync(cancellationToken);

        var messageDto = messageEntity.ToMessage(user.DisplayName, user.Id, user.Image, _blobServiceSettings.MangoBlobAccess);

        await _hubContext.Clients.Group(request.ChatId.ToString()).BroadcastMessageAsync(messageDto);

        return _responseFactory.SuccessResponse(SendMessageResponse.FromSuccess(messageEntity.Id));
    }
}