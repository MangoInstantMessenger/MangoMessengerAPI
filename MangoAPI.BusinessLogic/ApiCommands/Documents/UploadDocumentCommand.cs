using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.Documents
{
    public record UploadDocumentCommand : IRequest<GenericResponse<UploadDocumentResponse,ErrorResponse>>
    {
        public IFormFile FormFile { get; init; }
    }
}