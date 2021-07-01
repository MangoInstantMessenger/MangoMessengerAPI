using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Chats
{
    public class CreateChatEntityResponse : ResponseBase
    {
        public static CreateChatEntityResponse Suspicious => new()
        {
            Message = ResponseMessageCodes.CreateChatEntitySuspicious,
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

        public static CreateChatEntityResponse InvalidOrEmptyChatTitle => new()
        {
            Message = ResponseMessageCodes.InvalidOrEmptyGroupTitle,
            Success = false
        };

        public static CreateChatEntityResponse InvalidGroupType => new()
        {
            Message = ResponseMessageCodes.InvalidGroupType,
            Success = false
        };
    }
}