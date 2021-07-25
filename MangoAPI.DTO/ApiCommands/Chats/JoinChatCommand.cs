using MangoAPI.DTO.Responses.Chats;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Chats
{
    public class JoinChatCommand : IRequest<JoinChatResponse>
    {
        public string ChatId { get; set; }
        public string UserId { get; set; }
    }
}