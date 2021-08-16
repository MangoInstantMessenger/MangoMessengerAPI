using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public record GetMessagesQuery : IRequest<GetMessagesResponse>
    {
        public string ChatId { get; init; }
        public string UserId { get; init; }
    }
}