using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Documents
{
    public class UploadDocumentCommandHandler 
        : IRequestHandler<UploadDocumentCommand, Result<UploadDocumentResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly ResponseFactory<UploadDocumentResponse> _responseFactory;
        private readonly IBlobService _blobService;

        public UploadDocumentCommandHandler(
            MangoPostgresDbContext postgresDbContext,
            ResponseFactory<UploadDocumentResponse> responseFactory, 
            IBlobService blobService)
        {
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
            _blobService = blobService;
        }

        public async Task<Result<UploadDocumentResponse>> Handle(UploadDocumentCommand request,
            CancellationToken cancellationToken)
        {
            var blobContainerName = EnvironmentConstants.MangoBlobContainer;
            var uniqueFileName = GetUniqueFileName(request.FormFile.FileName);

            await _blobService.UploadFileBlob(uniqueFileName, request.FormFile, blobContainerName);

            var documentEntity = new DocumentEntity
            {
                FileName = uniqueFileName,
                UserId = request.UserId,
                UploadedAt = DateTime.Now
            };

            _postgresDbContext.Documents.Add(documentEntity);
            
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            var fileUrl = await _blobService.GetBlob(uniqueFileName, blobContainerName);
            
            return _responseFactory.SuccessResponse(
                UploadDocumentResponse.FromSuccess(documentEntity.FileName, fileUrl));
        }

        private static string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                   + "_"
                   + Guid.NewGuid()
                   + Path.GetExtension(fileName);
        }
    }
}