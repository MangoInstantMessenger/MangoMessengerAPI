using MangoAPI.BusinessLogic.Responses.Chats;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    public record GetCurrentUserChatsQuery : IRequest<GetCurrentUserChatsResponse>
    {
        public string UserId { get; init; }
    }
}