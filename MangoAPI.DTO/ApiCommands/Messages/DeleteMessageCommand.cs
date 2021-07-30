using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Messages
{
    public record DeleteMessageCommand : IRequest<DeleteMessageResponse>
    {
        public string MessageId { get; set; }
        public string UserId { get; set; }
    }
}