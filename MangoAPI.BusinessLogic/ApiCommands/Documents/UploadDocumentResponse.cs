using System.ComponentModel;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Documents
{
    public record UploadDocumentResponse : ResponseBase<UploadDocumentResponse>
    {
        [DefaultValue("testfile_980ef1cd-f879-453e-a435-60a0d60d79b9.txt")]
        public string FileName { get; init; }
        
        [DefaultValue("Uploads/testfile_980ef1cd-f879-453e-a435-60a0d60d79b9.txt")]
        public string FileUrl { get; init; }

        public static UploadDocumentResponse FromSuccess(string fileName, string fileUrl)
        {
            return new UploadDocumentResponse
            {
                Success = true,
                Message = ResponseMessageCodes.Success,
                FileName = fileName,
                FileUrl = fileUrl,
            };
        }
    }
}