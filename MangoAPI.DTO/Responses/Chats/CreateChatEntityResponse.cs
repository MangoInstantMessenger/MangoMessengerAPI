using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.DTO.Responses.Chats
{
    public class CreateChatEntityResponse : ChatResponseBase<CreateChatEntityResponse>
    {
        public string ChatId { get; set; }

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

        public static CreateChatEntityResponse DirectChatAlreadyExists => new()
        {
            Message = ResponseMessageCodes.DirectChatAlreadyExists,
            Success = false
        };

        public static CreateChatEntityResponse FromSuccess(ChatEntity chatEntity) => new()
        {
            ChatId = chatEntity.Id,
            Message = ResponseMessageCodes.Success,
            Success = true
        };
    }
}