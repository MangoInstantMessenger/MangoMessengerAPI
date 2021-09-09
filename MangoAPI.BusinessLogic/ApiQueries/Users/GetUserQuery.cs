using System;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    public record GetUserQuery : IRequest<GetUserResponse>
    {
        public Guid UserId { get; init; }
    }
}
