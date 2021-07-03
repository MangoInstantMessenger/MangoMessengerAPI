using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Chats
{
    public class JoinChatResponse : ResponseBase
    {
        public static JoinChatResponse UserNotFound => new()
        {
            Message = ResponseMessageCodes.UserNotFound,
            Success = false
        };

        public static JoinChatResponse FromSuccess => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true
        };

        public static JoinChatResponse UserAlreadyJoined => new()
        {
            Message = ResponseMessageCodes.UserAlreadyJoined,
            Success = false
        };

        public static JoinChatResponse ChatNotFound => new()
        {
            Message = ResponseMessageCodes.ChatNotFound,
            Success = false
        };
    }
}