using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Auth
{
    public class ConfirmRegisterResponse : ResponseBase
    {
        public static ConfirmRegisterResponse InvalidOrExpired => new ()
        {
            Success = false,
            Message = ResponseMessageCodes.ConfirmRegisterInvalidIdentifier
        };
        
        public static ConfirmRegisterResponse SuccessResponse => new ()
        {
            Success = true,
            Message = ResponseMessageCodes.Success
        };
    }
}