namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    using MediatR;

    public record CreateDirectChatCommand : IRequest<CreateChatEntityResponse>
    {
        public string PartnerId { get; init; }
        public string UserId { get; init; }
    }
}
