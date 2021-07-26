using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Messages
{
    public class EditMessageResponse : MessageResponseBase<EditMessageResponse>
    {
        public static EditMessageResponse EmptyMessage => new()
        {
          Message  = ResponseMessageCodes.EmptyMessage
        };
    }
}