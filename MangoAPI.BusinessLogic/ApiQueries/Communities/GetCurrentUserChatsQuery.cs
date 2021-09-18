using System;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public record GetCurrentUserChatsQuery : IRequest<GetCurrentUserChatsResponse>
    {
        public Guid UserId { get; init; }
    }
}
