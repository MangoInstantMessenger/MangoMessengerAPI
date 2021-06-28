using MangoAPI.DTO.Responses.Chats;
using MediatR;

namespace MangoAPI.DTO.Commands.Chats
{
    public class CreateChatCommand : IRequest<CreateChatResponse>
    {
    }
}