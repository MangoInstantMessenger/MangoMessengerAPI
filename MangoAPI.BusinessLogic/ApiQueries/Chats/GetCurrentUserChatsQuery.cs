namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    using MediatR;

    public record GetCurrentUserChatsQuery : IRequest<GetCurrentUserChatsResponse>
    {
        public string UserId { get; init; }
    }
}
