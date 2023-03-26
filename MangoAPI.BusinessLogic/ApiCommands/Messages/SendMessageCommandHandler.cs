﻿using FluentValidation;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Notifications;
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
    private readonly ResponseFactory<SendMessageResponse> responseFactory;
    private readonly IBlobServiceSettings blobServiceSettings;
    private readonly IBlobService blobService;
    private readonly IHubContext<ChatHub, IHubClient> hubContext;

    public SendMessageCommandHandler(
        MangoDbContext dbContext,
        ResponseFactory<SendMessageResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings,
        IBlobService blobService, IHubContext<ChatHub, IHubClient> hubContext)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.blobServiceSettings = blobServiceSettings;
        this.blobService = blobService;
        this.hubContext = hubContext;
    }

    public async Task<Result<SendMessageResponse>> Handle(
        SendMessageCommand request,
        CancellationToken cancellationToken)
    {
        var user = await dbContext.Users.AsNoTracking()
            .Select(x => new
            {
                x.DisplayName,
                x.DisplayNameColour,
                Image = x.ImageFileName,
                x.Id
            }).FirstOrDefaultAsync(
                x => x.Id == request.UserId, cancellationToken);

        if (user == null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.UserNotFound];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var userChat = await dbContext.UserChats.AsNoTracking()
            .Select(x => new
            {
                x.ChatId,
                x.RoleId,
                x.Chat
            }).FirstOrDefaultAsync(
                x => x.ChatId == request.ChatId,
                cancellationToken);

        if (userChat == null)
        {
            const string errorMessage = ResponseMessageCodes.ChatNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var attachmentUniqueFileName = await UploadAttachmentIfExistsAsync(request);

        var messageEntity = MessageEntity.Create(
            request.UserId,
            request.ChatId,
            request.Text,
            request.InReplyToUser,
            request.InReplyToText,
            attachmentUniqueFileName);

        userChat.Chat.UpdateLastMessage(
            user.DisplayName,
            messageEntity.Text,
            messageEntity.CreatedAt,
            messageEntity.Id);

        dbContext.Chats.Update(userChat.Chat);
        dbContext.Messages.Add(messageEntity);

        await dbContext.SaveChangesAsync(cancellationToken);

        var authorImageUrl = $"{blobServiceSettings.MangoBlobAccess}/{user.Image}";

        var attachmentUrl = attachmentUniqueFileName == null
            ? null
            : $"{blobServiceSettings.MangoBlobAccess}/{attachmentUniqueFileName}";

        var messageNotification = new SendMessageNotification(
            messageEntity.Id,
            messageEntity.UserId,
            messageEntity.ChatId,
            user.DisplayName,
            user.DisplayNameColour,
            messageEntity.Text,
            messageEntity.CreatedAt,
            messageEntity.UpdatedAt,
            messageEntity.InReplyToUser,
            messageEntity.InReplyToText,
            authorImageUrl,
            attachmentUrl);

        await hubContext.Clients.Group(request.ChatId.ToString()).MessageSentAsync(messageNotification);

        return responseFactory.SuccessResponse(SendMessageResponse.FromSuccess(messageEntity.Id, attachmentUrl,
            messageEntity.CreatedAt));
    }

    private async Task<string> UploadAttachmentIfExistsAsync(SendMessageCommand request)
    {
        if (request.Attachment == null)
        {
            return null;
        }

        await new CommonFileValidator().ValidateAndThrowAsync(request.Attachment);

        var file = request.Attachment;
        var uniqueFileName = FileNameHelper.CreateUniqueFileName(file.FileName);

        await blobService.UploadFileBlobAsync(file.OpenReadStream(), file.ContentType, uniqueFileName);

        return uniqueFileName;
    }
}