using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Messages
{
    public class EditMessageResponse : MessageResponseBase<EditMessageResponse>
    {
        public static EditMessageResponse MessageContentIsNullOrEmpty => new()
        {
          Message  = ResponseMessageCodes.MessageIsNullOrEmpty
        };
    }
}