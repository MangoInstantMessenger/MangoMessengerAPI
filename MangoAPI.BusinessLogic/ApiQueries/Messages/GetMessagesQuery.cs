using System;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public record GetMessagesQuery : IRequest<GetMessagesResponse>
    {
        public Guid ChatId { get; init; }
        public Guid UserId { get; init; }
    }
}
