using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public record JoinChatCommand : IRequest<JoinChatResponse>
    {
        public string ChatId { get; init; }
        public string UserId { get; init; }
    }
}