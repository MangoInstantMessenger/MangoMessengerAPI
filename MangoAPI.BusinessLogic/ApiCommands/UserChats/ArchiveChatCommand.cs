using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public record ArchiveChatCommand : IRequest<ArchiveChatResponse>
    {
        public string ChatId { get; init; }
        public string UserId { get; init; }
        public bool Archived { get; init; }
    }
}
