using System;
using System.ComponentModel;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public record DeleteMessageResponse : ResponseBase<DeleteMessageResponse>
    {
        [DefaultValue("ef885dda-e0d2-4fa8-86a8-27ef92acc942")]
        public Guid MessageId { get; init; }

        public static DeleteMessageResponse FromSuccess(MessageEntity message)
        {
            return new()
            {
                Success = true,
                Message = ResponseMessageCodes.Success,
                MessageId = message.Id,
            };
        }
    }
}
