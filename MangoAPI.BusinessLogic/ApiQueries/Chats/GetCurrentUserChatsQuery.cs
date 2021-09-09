using System;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    public record GetCurrentUserChatsQuery : IRequest<GetCurrentUserChatsResponse>
    {
        public Guid UserId { get; init; }
    }
}
