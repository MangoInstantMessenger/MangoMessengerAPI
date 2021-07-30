using MangoAPI.DTO.Responses.Chats;
using MediatR;

namespace MangoAPI.DTO.ApiQueries.Chats
{
    public record GetCurrentUserChatsQuery : IRequest<GetCurrentUserChatsResponse>
    {
        public string UserId { get; init; }
    }
}