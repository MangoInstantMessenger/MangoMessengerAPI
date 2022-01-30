using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Users;

public record GetUserQuery : IRequest<Result<GetUserResponse>>
{
    public Guid UserId { get; init; }
}