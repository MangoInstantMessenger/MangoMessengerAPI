using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Messages
{
    public class DeleteMessageCommand : IRequest<DeleteMessageResponse>
    {
        public string MessageId { get; set; }
        public string UserId { get; set; }
    }
}