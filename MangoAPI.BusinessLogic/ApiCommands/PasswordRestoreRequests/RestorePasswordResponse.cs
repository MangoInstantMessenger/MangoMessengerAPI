using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public record RestorePasswordResponse : ResponseBase<RestorePasswordResponse>
    {
        public string RestorePasswordRequestId { get; set; }

        public static RestorePasswordResponse FromSuccess(string restorePasswordRequestId) => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            RestorePasswordRequestId = restorePasswordRequestId
        };
    }
}