using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    public record SearchChatsQuery : IRequest<SearchChatsResponse>
    {
        public string DisplayName { get; init; }
        public string UserId { get; init; }
    }
}