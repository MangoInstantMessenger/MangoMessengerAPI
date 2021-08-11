using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.Responses.Messages
{
    public record SendMessageResponse : MessageResponseBase<SendMessageResponse>
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public string MessageId { get; init; }

        public static SendMessageResponse FromSuccess(string messageId) => new()
        {
            Success = true,
            Message = ResponseMessageCodes.Success,
            MessageId = messageId
        };
    }
}