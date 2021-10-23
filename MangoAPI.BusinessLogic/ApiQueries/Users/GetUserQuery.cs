using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    public record GetUserQuery : IRequest<GenericResponse<GetUserResponse>>
    {
        public Guid UserId { get; init; }
    }
}
