using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public record SendMessageResponse : MessageResponseBase<SendMessageResponse>
    {
        public string MessageId { get; init; }

        public static SendMessageResponse FromSuccess(string messageId)
        {
            return new ()
            {
                Success = true,
                Message = ResponseMessageCodes.Success,
                MessageId = messageId,
            };
        }
    }
}
