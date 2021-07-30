using MangoAPI.DTO.Responses.Chats;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Chats
{
    public record JoinChatCommand : IRequest<JoinChatResponse>
    {
        public string ChatId { get; set; }
        public string UserId { get; set; }
    }
}