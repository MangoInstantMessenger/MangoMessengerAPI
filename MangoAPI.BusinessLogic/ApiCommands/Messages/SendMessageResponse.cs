namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    using MangoAPI.BusinessLogic.Responses;
    using MangoAPI.Domain.Constants;

    public record SendMessageResponse : MessageResponseBase<SendMessageResponse>
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
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
