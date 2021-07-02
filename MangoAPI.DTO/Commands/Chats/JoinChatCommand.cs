using MangoAPI.DTO.Responses.Chats;
using MediatR;

namespace MangoAPI.DTO.Commands.Chats
{
    public class JoinChatCommand : IRequest<JoinChatResponse>
    {
        public int ChatId { get; set; }
    }
}