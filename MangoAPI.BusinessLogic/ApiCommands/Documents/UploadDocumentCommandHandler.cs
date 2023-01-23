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
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<UploadDocumentResponse> responseFactory;
    private readonly IBlobService blobService;

    public UploadDocumentCommandHandler(
        MangoDbContext dbContext,
        ResponseFactory<UploadDocumentResponse> responseFactory,
        IBlobService blobService)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.blobService = blobService;
    }

    public async Task<Result<UploadDocumentResponse>> Handle(
        UploadDocumentCommand request,
        CancellationToken cancellationToken)
    {
        var totalUploadedDocsCount = await dbContext.Documents.CountAsync(
            x =>
            x.UserId == request.UserId &&
            x.UploadedAt > DateTime.UtcNow.AddHours(-1), cancellationToken);

        if (totalUploadedDocsCount > 10)
        {
            const string message = ResponseMessageCodes.UploadedDocumentsLimitReached10;
            var details = ResponseMessageCodes.ErrorDictionary[message];
            return responseFactory.ConflictResponse(message, details);
        }

        var file = request.FormFile;
        var uniqueFileName = StringService.GetUniqueFileName(file.FileName);

        _ = await blobService.UploadFileBlobAsync(file.OpenReadStream(), request.ContentType, uniqueFileName);

        var documentEntity = new DocumentEntity
        {
            FileName = uniqueFileName,
            UserId = request.UserId,
            UploadedAt = DateTime.UtcNow,
        };

        _ = dbContext.Documents.Add(documentEntity);

        _ = await dbContext.SaveChangesAsync(cancellationToken);

        var fileUrl = await blobService.GetBlobAsync(uniqueFileName);

        return responseFactory.SuccessResponse(
            UploadDocumentResponse.FromSuccess(documentEntity.FileName, fileUrl));
    }
}
