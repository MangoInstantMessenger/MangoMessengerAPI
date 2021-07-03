using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Chats
{
    public class JoinChatResponse : ChatResponseBase<JoinChatResponse>
    {
        public static JoinChatResponse UserAlreadyJoined => new()
        {
            Message = ResponseMessageCodes.UserAlreadyJoined,
            Success = false
        };
    }
}