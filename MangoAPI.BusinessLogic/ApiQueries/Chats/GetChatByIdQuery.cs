using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    public record GetChatByIdQuery : IRequest<GetChatByIdResponse>
    {
        public string UserId { get; init; }
        public string ChatId { get; init; }
    }
}