using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public record DeleteMessageResponse : MessageResponseBase<DeleteMessageResponse>
    {
        public string MessageId { get; init; }

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
