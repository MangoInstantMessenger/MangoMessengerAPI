using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public record GetCurrentUserChatsQuery : IRequest<GenericResponse<GetCurrentUserChatsResponse>>
    {
        public Guid UserId { get; init; }
    }
}
