using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Documents
{
    public record UploadDocumentCommand : IRequest<ResponseBase>
    {
        public string FileName { get; init; }
    }
}