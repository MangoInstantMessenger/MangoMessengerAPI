using System;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    public record GetChatByIdQuery : IRequest<GetChatByIdResponse>
    {
        public Guid UserId { get; init; }
        public Guid ChatId { get; init; }
    }
}