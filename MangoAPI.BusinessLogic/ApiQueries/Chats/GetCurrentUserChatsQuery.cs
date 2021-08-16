using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    public record GetCurrentUserChatsQuery : IRequest<GetCurrentUserChatsResponse>
    {
        public string UserId { get; init; }
    }
}