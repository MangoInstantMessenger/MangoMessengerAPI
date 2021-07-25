using MangoAPI.DTO.Responses.Chats;
using MediatR;

namespace MangoAPI.DTO.Commands.Chats
{
    public class CreateDirectChatCommand : IRequest<CreateChatEntityResponse>
    {
        public string PartnerId { get; set; }
        public string UserId { get; set; }
    }
}