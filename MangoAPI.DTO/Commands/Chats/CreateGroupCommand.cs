using MangoAPI.Domain.Enums;
using MangoAPI.DTO.Responses.Chats;
using MediatR;

namespace MangoAPI.DTO.Commands.Chats
{
    public class CreateGroupCommand : IRequest<CreateChatEntityResponse>
    {
        public ChatType GroupType { get; set; }
        public string GroupTitle { get; set; }
        public string UserId { get; set; }
    }
}