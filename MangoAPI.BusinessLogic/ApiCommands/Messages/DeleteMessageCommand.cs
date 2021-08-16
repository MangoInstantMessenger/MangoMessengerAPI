using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public record DeleteMessageCommand : IRequest<DeleteMessageResponse>
    {
        public string MessageId { get; init; }
        public string UserId { get; init; }
    }
}