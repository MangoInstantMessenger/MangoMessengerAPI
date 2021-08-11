using MangoAPI.DTO.Responses.Chats;
using MediatR;

namespace MangoAPI.DTO.ApiQueries.Chats
{
    public record SearchChatsQuery : IRequest<SearchChatsResponse>
    {
        public string DisplayName { get; init; }
        public string UserId { get; init; }
    }
}