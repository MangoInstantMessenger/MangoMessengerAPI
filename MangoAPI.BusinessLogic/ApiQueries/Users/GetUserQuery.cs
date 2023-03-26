using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Users;

public record GetUserQuery(Guid UserId)
    : IRequest<Result<GetUserResponse>>;