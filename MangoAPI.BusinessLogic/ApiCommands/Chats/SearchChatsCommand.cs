namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    using MediatR;

    public record SearchChatsCommand : IRequest<SearchChatsResponse>
    {
        public string DisplayName { get; init; }
        public string UserId { get; init; }
    }
}
