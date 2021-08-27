namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    using MangoAPI.Domain.Constants;
    using MangoAPI.Domain.Entities;
    using Responses;

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
