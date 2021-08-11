using MangoAPI.BusinessLogic.Responses.Chats;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    public record JoinChatCommand : IRequest<JoinChatResponse>
    {
        public string ChatId { get; init; }
        public string UserId { get; init; }
    }
}