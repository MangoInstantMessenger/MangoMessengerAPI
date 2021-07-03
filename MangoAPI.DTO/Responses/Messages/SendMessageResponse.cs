using MangoAPI.Domain.Constants;
using MangoAPI.DTO.Models;

namespace MangoAPI.DTO.Responses.Messages
{
    public class SendMessageResponse: MessageResponseBase<SendMessageResponse>
    {
        public Message ChatMessage { get; set; }

        public static SendMessageResponse FromSuccess(Message message) => new()
        {
            Success = true,
            Message = ResponseMessageCodes.Success,
            ChatMessage = message
        };
    }
}