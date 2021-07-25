using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.DTO.Queries.Messages
{
    public class GetMessagesQuery : IRequest<GetMessagesResponse>
    {
        public string ChatId { get; set; }
        public string UserId { get; set; }
    }
}