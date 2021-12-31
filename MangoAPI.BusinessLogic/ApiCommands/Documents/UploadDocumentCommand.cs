using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.Documents
{
    public record UploadDocumentCommand : IRequest<Result<UploadDocumentResponse>>
    {
        public IFormFile FormFile { get; init; }

        public Guid UserId { get; init; }
    }
}