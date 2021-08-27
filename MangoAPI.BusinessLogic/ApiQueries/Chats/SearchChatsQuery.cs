namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    using MediatR;

    public record SearchChatsQuery : IRequest<SearchChatsResponse>
    {
        public string DisplayName { get; init; }
        public string UserId { get; init; }
    }
}