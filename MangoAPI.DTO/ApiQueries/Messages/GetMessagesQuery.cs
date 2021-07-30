using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.DTO.ApiQueries.Messages
{
    public record GetMessagesQuery : IRequest<GetMessagesResponse>
    {
        public string ChatId { get; set; }
        public string UserId { get; set; }
    }
}