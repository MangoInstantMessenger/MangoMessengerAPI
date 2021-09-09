using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Hosting;

namespace MangoAPI.BusinessLogic.ApiCommands.Documents
{
    public class UploadDocumentCommandHandler : IRequestHandler<UploadDocumentCommand, ResponseBase>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IHostingEnvironment _environment;

        public UploadDocumentCommandHandler(MangoPostgresDbContext postgresDbContext, IHostingEnvironment environment)
        {
            _postgresDbContext = postgresDbContext;
            _environment = environment;
        }

        public async Task<ResponseBase> Handle(UploadDocumentCommand request, CancellationToken cancellationToken)
        {
            var uniqueFileName = GetUniqueFileName(request.FormFile.FileName);
            var uploads = Path.Combine(_environment.WebRootPath, "Uploads");
            var filePath = Path.Combine(uploads, uniqueFileName);
            
            await request.FormFile.CopyToAsync(new FileStream(filePath, FileMode.Create), cancellationToken);

            var documentEntity = new DocumentEntity
            {
                Id = Guid.NewGuid().ToString(),
                FileName = uniqueFileName,
                FilePath = filePath
            };

            await _postgresDbContext.Documents.AddAsync(documentEntity, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return ResponseBase.SuccessResponse;
        }

        private static string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                   + "_"
                   + Guid.NewGuid().ToString()[..4]
                   + Path.GetExtension(fileName);
        }
    }
}