using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public record GetMessagesQuery : IRequest<Result<GetMessagesResponse>>
    {
        public Guid ChatId { get; init; }
        public Guid UserId { get; init; }
    }
}
