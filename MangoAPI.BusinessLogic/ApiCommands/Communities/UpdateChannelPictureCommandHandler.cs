using System;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Entities;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public class UpdateChannelPictureCommandHandler : IRequestHandler<UpdateChanelPictureCommand, Result<UpdateChannelPictureResponse>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<UpdateChannelPictureResponse> _responseFactory;
    private readonly IBlobService _blobService;

    public UpdateChannelPictureCommandHandler(
        MangoDbContext dbContext,
        ResponseFactory<UpdateChannelPictureResponse> responseFactory,
        IBlobService blobService)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
        _blobService = blobService;
    }

    public async Task<Result<UpdateChannelPictureResponse>> Handle(UpdateChanelPictureCommand request, CancellationToken cancellationToken)
    {
        var totalUploadedDocsCount = await _dbContext.Documents.CountAsync(x =>
            x.UserId == request.UserId &&
            x.UploadedAt > DateTime.UtcNow.AddHours(-1), cancellationToken);

        if (totalUploadedDocsCount >= 10)
        {
            const string message = ResponseMessageCodes.UploadedDocumentsLimitReached10;
            var details = ResponseMessageCodes.ErrorDictionary[message];
            return _responseFactory.ConflictResponse(message, details);
        }

        var userChat = await _dbContext.UserChats
            .Include(x => x.Chat)
            .FirstOrDefaultAsync(x =>
                x.ChatId == request.ChatId &&
                x.UserId == request.UserId &&
                x.RoleId == (int) UserRole.Owner &&
                x.Chat.CommunityType != (int) CommunityType.DirectChat, cancellationToken);

        if (userChat is null)
        {
            const string errorMessage = ResponseMessageCodes.ChatNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, errorDescription);
        }
        
        var uniqueFileName = StringService.GetUniqueFileName(request.NewGroupPicture.FileName);

        await _blobService.UploadFileBlobAsync(uniqueFileName, request.NewGroupPicture);

        var newUserPicture = new DocumentEntity
        {
            FileName = uniqueFileName,
            UserId = request.UserId,
            UploadedAt = DateTime.UtcNow
        };

        _dbContext.Documents.Add(newUserPicture);

        userChat.Chat.Image = uniqueFileName;

        _dbContext.Update(userChat.Chat);

        await _dbContext.SaveChangesAsync(cancellationToken);

        var blobUrl = await _blobService.GetBlobAsync(uniqueFileName);
        var response = UpdateChannelPictureResponse.FromSuccess(blobUrl);

        return _responseFactory.SuccessResponse(response);
    }
}