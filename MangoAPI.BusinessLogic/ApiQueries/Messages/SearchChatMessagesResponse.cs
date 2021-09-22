using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using System.Collections.Generic;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public record SearchChatMessagesResponse : ResponseBase<SearchChatMessagesResponse>
    {
        public List<Message> Messages { get; init; }

        public static SearchChatMessagesResponse FromSuccess(List<Message> messages) =>
            new()
            {
                Messages = messages,
                Message = ResponseMessageCodes.Success,
                Success = true
            };
    }
}