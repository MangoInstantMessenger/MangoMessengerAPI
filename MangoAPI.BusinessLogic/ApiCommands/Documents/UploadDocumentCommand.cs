using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.Documents
{
    public record UploadDocumentCommand : IRequest<UploadDocumentResponse>
    {
        public IFormFile FormFile { get; init; }
    }
}