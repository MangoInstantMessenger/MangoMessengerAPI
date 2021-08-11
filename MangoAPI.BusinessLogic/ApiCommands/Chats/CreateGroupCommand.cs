using MangoAPI.Domain.Enums;
using MangoAPI.DTO.Responses.Chats;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Chats
{
    public record CreateGroupCommand : IRequest<CreateChatEntityResponse>
    {
        public ChatType GroupType { get; init; }
        public string GroupTitle { get; init; }
        public string UserId { get; init; }
    }
}