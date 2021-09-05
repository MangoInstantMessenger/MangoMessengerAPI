using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public record SearchChatMessagesQuery : IRequest<SearchChatMessagesResponse>
    {
        public string UserId { get; set; }
        public string ChatId { get; set; }
        public string MessageText { get; set; }
    }
}