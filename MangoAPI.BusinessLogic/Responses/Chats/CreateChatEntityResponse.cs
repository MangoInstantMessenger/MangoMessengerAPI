using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.BusinessLogic.Responses.Chats
{
    public record CreateChatEntityResponse : ChatResponseBase<CreateChatEntityResponse>
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public string ChatId { get; init; }

        public static CreateChatEntityResponse FromSuccess(ChatEntity chatEntity) => new()
        {
            ChatId = chatEntity.Id,
            Message = ResponseMessageCodes.Success,
            Success = true
        };
    }
}