using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.DTO.Commands.Messages
{
    public class DeleteMessageCommand : IRequest<DeleteMessageResponse>
    {
        public int MessageId { get; set; }
    }
}