using MangoAPI.Domain.Constants;
using MangoAPI.DTO.Models;

namespace MangoAPI.DTO.Responses.Messages
{
    public class SendMessageResponse: MessageResponseBase<SendMessageResponse>
    {
        public string MessageId { get; set; }

        public static SendMessageResponse FromSuccess(string messageId) => new()
        {
            Success = true,
            Message = ResponseMessageCodes.Success,
            MessageId = messageId
        };

        public static SendMessageResponse EmptyMessage => new()
        {
            Success = false,
            Message = ResponseMessageCodes.EmptyMessage,
            MessageId = null
        };
    }
}