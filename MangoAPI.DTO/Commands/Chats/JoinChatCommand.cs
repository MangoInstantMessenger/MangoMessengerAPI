using MangoAPI.DTO.Responses.Chats;
using MediatR;

namespace MangoAPI.DTO.Commands.Chats
{
    public class JoinChatCommand : IRequest<JoinChatResponse>
    {
        public string ChatId { get; set; }
        public string UserId { get; set; }
    }
}