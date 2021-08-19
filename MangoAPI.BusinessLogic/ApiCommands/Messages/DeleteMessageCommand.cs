namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    using MediatR;

    public record DeleteMessageCommand : IRequest<DeleteMessageResponse>
    {
        public string MessageId { get; init; }
        public string UserId { get; init; }
    }
}
