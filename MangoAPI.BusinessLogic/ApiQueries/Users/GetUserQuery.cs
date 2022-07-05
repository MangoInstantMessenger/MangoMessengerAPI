using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Users;

#pragma warning disable SA1313
#pragma warning disable SA1009
public record GetUserQuery(Guid UserId) : IRequest<Result<GetUserResponse>>;
#pragma warning restore SA1009
#pragma warning restore SA1313
