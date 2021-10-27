using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public record SearchChatMessagesQuery : IRequest<Result<SearchChatMessagesResponse>>
    {
        public Guid UserId { get; set; }
        public Guid ChatId { get; set; }
        public string MessageText { get; set; }
    }
}