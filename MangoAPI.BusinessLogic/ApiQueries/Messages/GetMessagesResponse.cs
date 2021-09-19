using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using System.Collections.Generic;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public record GetMessagesResponse : ResponseBase<GetMessagesResponse>
    {
        public List<Message> Messages { get; init; }

        public static GetMessagesResponse FromSuccess(List<Message> messages)
        {
            return new()
            {
                Message = ResponseMessageCodes.Success,
                Messages = messages,
                Success = true,
            };
        }
    }
}