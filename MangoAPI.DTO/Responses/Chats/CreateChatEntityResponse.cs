using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Chats
{
    public class CreateChatEntityResponse : ChatResponseBase<CreateChatEntityResponse>
    {
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