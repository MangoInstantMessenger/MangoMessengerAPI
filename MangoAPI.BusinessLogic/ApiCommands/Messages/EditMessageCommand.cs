using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public record EditMessageCommand : IRequest<EditMessageResponse>
    {
        public string MessageId { get; init; }
        public string UserId { get; init; }
        public string ModifiedText { get; init; }
    }
}