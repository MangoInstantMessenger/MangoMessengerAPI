using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public record SearchChatMessagesQuery : IRequest<Result<SearchChatMessagesResponse>>
    {
        public Guid UserId { get; init; }
        public Guid ChatId { get; init; }
        public string MessageText { get; init; }
    }
}