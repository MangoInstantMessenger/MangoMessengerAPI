namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    using MediatR;

    public record JoinChatCommand : IRequest<JoinChatResponse>
    {
        public string ChatId { get; init; }
        public string UserId { get; init; }
    }
}
