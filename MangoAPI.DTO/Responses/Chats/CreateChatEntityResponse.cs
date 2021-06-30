using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Chats
{
    public class CreateChatEntityResponse : ResponseBase
    {
        public static CreateChatEntityResponse Suspicious => new()
        {
            Message = ResponseMessageCodes.CreateDirectChatSuspicious,
            Success = false
        };

        public static CreateChatEntityResponse RefreshTokenNotValidated => new()
        {
            Message = ResponseMessageCodes.InvalidRefreshTokenProvided,
            Success = false
        };

        public static CreateChatEntityResponse DirectChatCreateSuccess => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true
        };
    }
}