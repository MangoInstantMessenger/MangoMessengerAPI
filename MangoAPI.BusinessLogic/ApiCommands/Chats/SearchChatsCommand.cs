using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    public record SearchChatsCommand : IRequest<SearchChatsResponse>
    {
        public string DisplayName { get; init; }
        public string UserId { get; init; }
    }
}