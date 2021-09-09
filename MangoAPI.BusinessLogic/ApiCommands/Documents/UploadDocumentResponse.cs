using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Documents
{
    public record UploadDocumentResponse : ResponseBase<UploadDocumentResponse>
    {
        public string DocumentId { get; init; }

        public static UploadDocumentResponse FromSuccess(string documentId)
        {
            return new()
            {
                Success = true,
                Message = ResponseMessageCodes.Success,
                DocumentId = documentId
            };
        }
    }
}