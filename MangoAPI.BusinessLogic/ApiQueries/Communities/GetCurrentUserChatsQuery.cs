using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities;

public record GetCurrentUserChatsQuery(Guid UserId)
    : IRequest<Result<GetCurrentUserChatsResponse>>;