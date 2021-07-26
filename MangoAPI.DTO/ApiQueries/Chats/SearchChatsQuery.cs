using MangoAPI.DTO.Responses.Chats;
using MediatR;

namespace MangoAPI.DTO.ApiQueries.Chats
{
    public class SearchChatsQuery : IRequest<SearchChatsResponse>
    {
        public string DisplayName { get; set; }
        public string UserId { get; set; }
    }
}