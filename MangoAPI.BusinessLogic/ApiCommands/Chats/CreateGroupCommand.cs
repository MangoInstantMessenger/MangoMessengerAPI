using MangoAPI.Domain.Enums;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    public record CreateGroupCommand : IRequest<CreateChatEntityResponse>
    {
        public ChatType GroupType { get; init; }
        public string GroupTitle { get; init; }
        public string UserId { get; init; }
    }
}