namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    using MediatR;

    public record SendMessageCommand : IRequest<SendMessageResponse>
    {
        public string MessageText { get; init; }
        public string UserId { get; init; }
        public string ChatId { get; init; }
    }
}
