using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.DTO.Commands.Messages
{
    public class SendMessageCommand : IRequest<SendMessageResponse>
    {
        public string Content { get; set; }
        public int ChatId { get; set; }
    }
}