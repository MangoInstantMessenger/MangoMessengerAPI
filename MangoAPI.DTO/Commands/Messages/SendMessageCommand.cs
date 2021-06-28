using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.DTO.Commands.Messages
{
    public class SendMessageCommand : IRequest<SendMessageResponse>
    {
    }
}