using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Messages
{
    public record EditMessageCommand : IRequest<EditMessageResponse>
    {
        public string MessageId { get; init; }
        public string UserId { get; init; }
        public string ModifiedText { get; init; }
    }
}