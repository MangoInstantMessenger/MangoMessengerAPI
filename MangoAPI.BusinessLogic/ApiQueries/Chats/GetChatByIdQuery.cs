using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    public record GetChatByIdQuery : IRequest<GetChatByIdResponse>
    {
        public string UserId { get; set; }
        public string ChatId { get; set; }
    }
}