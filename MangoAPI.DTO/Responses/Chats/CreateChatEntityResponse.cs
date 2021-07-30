using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.DTO.Responses.Chats
{
    public record CreateChatEntityResponse : ChatResponseBase<CreateChatEntityResponse>
    {
        public string ChatId { get; set; }

        public static CreateChatEntityResponse FromSuccess(ChatEntity chatEntity) => new()
        {
            ChatId = chatEntity.Id,
            Message = ResponseMessageCodes.Success,
            Success = true
        };
    }
}