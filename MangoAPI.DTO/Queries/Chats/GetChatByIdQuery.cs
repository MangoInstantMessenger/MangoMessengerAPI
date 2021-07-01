using MangoAPI.DTO.Responses.Chats;
using MediatR;

namespace MangoAPI.DTO.Queries.Chats
{
    public class GetChatByIdQuery : IRequest<GetChatByIdResponse>
    {
        public int ChatId { get; set; }
    }
}