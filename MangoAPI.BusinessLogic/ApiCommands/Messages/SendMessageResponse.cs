using System;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public record SendMessageResponse : ResponseBase<SendMessageResponse>
    {
        public Guid MessageId { get; init; }

        public static SendMessageResponse FromSuccess(Guid messageId)
        {
            return new()
            {
                Success = true,
                Message = ResponseMessageCodes.Success,
                MessageId = messageId,
            };
        }
    }
}