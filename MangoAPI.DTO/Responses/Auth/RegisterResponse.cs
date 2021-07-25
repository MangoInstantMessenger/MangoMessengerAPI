using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.DTO.Responses.Auth
{
    public class RegisterResponse : AuthResponseBase<RegisterResponse>
    {
        public string UserId { get; set; }

        public static RegisterResponse UserAlreadyRegistered => new()
        {
            Success = false,
            Message = ResponseMessageCodes.UserAlreadyRegistered
        };

        public static RegisterResponse InvalidEmail => new()
        {
            Success = false,
            Message = ResponseMessageCodes.InvalidEmail
        };

        public static RegisterResponse TermsNotAccepted => new()
        {
            Success = false,
            Message = ResponseMessageCodes.TermsNotAccepted
        };

        public static RegisterResponse FromSuccess(UserEntity userEntity) => new()
        {
            UserId = userEntity.Id,
            Success = true,
            Message = ResponseMessageCodes.Success
        };

        public static RegisterResponse WeakPassword => new()
        {
            Success = false,
            Message = ResponseMessageCodes.WeakPassword
        };

        public static RegisterResponse InvalidVerificationMethod => new()
        {
            Success = false,
            Message = ResponseMessageCodes.InvalidVerificationMethod
        };

        public static RegisterResponse PhoneOccupied => new()
        {
            Success = false,
            Message = ResponseMessageCodes.PhoneOccupied
        };

        public static RegisterResponse InvalidDisplayName => new()
        {
            Message = ResponseMessageCodes.InvalidDisplayName,
            Success = false
        };
    }
}