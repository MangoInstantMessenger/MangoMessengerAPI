using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Documents;

public class UploadDocumentCommandHandler
    : IRequestHandler<UploadDocumentCommand, Result<UploadDocumentResponse>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<UploadDocumentResponse> _responseFactory;
    private readonly IBlobService _blobService;

    public UploadDocumentCommandHandler(
        MangoDbContext dbContext,
        ResponseFactory<UploadDocumentResponse> responseFactory,
        IBlobService blobService)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
        _blobService = blobService;
    }

    public async Task<Result<UploadDocumentResponse>> Handle(UploadDocumentCommand request,
        CancellationToken cancellationToken)
    {
        // var user = await _dbContext.Users
        //     .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);
        //
        // if (user == null)
        // {
        //     const string message = ResponseMessageCodes.UserNotFound;
        //     var details = ResponseMessageCodes.ErrorDictionary[message];
        //     return _responseFactory.ConflictResponse(message, details);
        // }
        
        var totalUploadedDocsCount = await _dbContext.Documents.CountAsync(x =>
            x.UserId == request.UserId &&
            x.UploadedAt > DateTime.UtcNow.AddHours(-1), cancellationToken);

        if (totalUploadedDocsCount > 10)
        {
            const string message = ResponseMessageCodes.UploadedDocumentsLimitReached10;
            var details = ResponseMessageCodes.ErrorDictionary[message];
            return _responseFactory.ConflictResponse(message, details);
        }

        var file = request.FormFile;
        var uniqueFileName = StringService.GetUniqueFileName(file.FileName);

        await _blobService.UploadFileBlobAsync(file.OpenReadStream(), request.ContentType, uniqueFileName);

        var documentEntity = new DocumentEntity
        {
            FileName = uniqueFileName,
            UserId = request.UserId,
            UploadedAt = DateTime.UtcNow
        };

        _dbContext.Documents.Add(documentEntity);

        await _dbContext.SaveChangesAsync(cancellationToken);

        var fileUrl = await _blobService.GetBlobAsync(uniqueFileName);

        return _responseFactory.SuccessResponse(
            UploadDocumentResponse.FromSuccess(documentEntity.FileName, fileUrl));
    }
}