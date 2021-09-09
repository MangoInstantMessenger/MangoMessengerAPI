using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Documents
{
    public record UploadDocumentResponse : ResponseBase<UploadDocumentResponse>
    {
        public string FileName { get; init; }

        public static UploadDocumentResponse FromSuccess(string fileName)
        {
            return new()
            {
                Success = true,
                Message = ResponseMessageCodes.Success,
                FileName = fileName,
            };
        }
    }
}