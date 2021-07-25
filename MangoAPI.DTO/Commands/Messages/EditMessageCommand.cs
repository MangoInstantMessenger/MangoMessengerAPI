using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.DTO.Commands.Messages
{
    public class EditMessageCommand : IRequest<EditMessageResponse>
    {
        public string MessageId { get; set; }
        public string UserId { get; set; }
        public string ModifiedText { get; set; }
    }
}