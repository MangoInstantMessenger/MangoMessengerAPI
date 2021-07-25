using MangoAPI.DTO.Responses.Chats;
using MediatR;

namespace MangoAPI.DTO.Queries.Chats
{
    public class GetChatsQuery : IRequest<GetChatsResponse>
    {
        public string UserId { get; set; }
    }
}