﻿using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public class
    UpdateChannelPictureCommandHandler : IRequestHandler<UpdateChanelPictureCommand,
        Result<UpdateChannelPictureResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<UpdateChannelPictureResponse> responseFactory;
    private readonly IBlobService blobService;

    public UpdateChannelPictureCommandHandler(
        MangoDbContext dbContext,
        ResponseFactory<UpdateChannelPictureResponse> responseFactory,
        IBlobService blobService)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.blobService = blobService;
    }

    public async Task<Result<UpdateChannelPictureResponse>> Handle(
        UpdateChanelPictureCommand request,
        CancellationToken cancellationToken)
    {
        var userChat = await dbContext.UserChats
            .Include(x => x.Chat)
            .FirstOrDefaultAsync(
                x =>
                    x.ChatId == request.ChatId &&
                    x.UserId == request.UserId &&
                    x.RoleId == UserRole.Owner &&
                    x.Chat.CommunityType != CommunityType.DirectChat, cancellationToken);

        if (userChat is null)
        {
            const string errorMessage = ResponseMessageCodes.ChatNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var file = request.NewGroupPicture;
        var uniqueFileName = FileNameHelper.CreateUniqueFileName(file.FileName);
        var stream = file.OpenReadStream();

        await blobService.UploadFileBlobAsync(stream, request.ContentType, uniqueFileName);

        userChat.Chat.ChangeChatImage(uniqueFileName);

        dbContext.Update(userChat.Chat);

        await dbContext.SaveChangesAsync(cancellationToken);

        var blobUrl = await blobService.GetBlobUrlAsync(uniqueFileName);
        var response = UpdateChannelPictureResponse.FromSuccess(blobUrl, uniqueFileName);

        return responseFactory.SuccessResponse(response);
    }
}