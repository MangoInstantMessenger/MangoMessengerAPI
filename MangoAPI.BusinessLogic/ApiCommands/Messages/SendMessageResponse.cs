namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    using Responses;
    using Domain.Constants;

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
