using System;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    public record CreateChatEntityResponse : ChatResponseBase<CreateChatEntityResponse>
    {
        public Guid ChatId { get; init; }

        public static CreateChatEntityResponse FromSuccess(ChatEntity chatEntity)
        {
            return new ()
            {
                ChatId = chatEntity.Id,
                Message = ResponseMessageCodes.Success,
                Success = true,
            };
        }
    }
}
