using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    public record CreateDirectChatCommand : IRequest<CreateChatEntityResponse>
    {
        public string PartnerId { get; init; }
        public string UserId { get; init; }
    }
}
