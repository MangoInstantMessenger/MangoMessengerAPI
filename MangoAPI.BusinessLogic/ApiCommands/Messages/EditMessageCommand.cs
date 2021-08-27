namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    using MediatR;

    public record EditMessageCommand : IRequest<EditMessageResponse>
    {
        public string MessageId { get; init; }
        public string UserId { get; init; }
        public string ModifiedText { get; init; }
    }
}
