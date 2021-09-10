using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Documents
{
    public record UploadDocumentResponse : ResponseBase<UploadDocumentResponse>
    {
        public string FileName { get; init; }
        public string FilePath { get; init; }

        public static UploadDocumentResponse FromSuccess(string fileName, string filePath)
        {
            return new()
            {
                Success = true,
                Message = ResponseMessageCodes.Success,
                FileName = fileName,
                FilePath = filePath,
            };
        }
    }
}