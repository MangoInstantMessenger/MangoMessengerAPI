using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities;

public record SearchCommunityQuery(Guid UserId, string DisplayName) : IRequest<Result<SearchCommunityResponse>>;