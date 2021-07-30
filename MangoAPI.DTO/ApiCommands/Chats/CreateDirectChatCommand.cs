using MangoAPI.DTO.Responses.Chats;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Chats
{
    public record CreateDirectChatCommand : IRequest<CreateChatEntityResponse>
    {
        public string PartnerId { get; set; }
        public string UserId { get; set; }
    }
}