using MangoAPI.Domain.Constants;

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
    }
}