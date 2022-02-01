using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities;

public record SearchCommunityQuery : IRequest<Result<SearchCommunityResponse>>
{
    public string DisplayName { get; init; }
    public Guid UserId { get; init; }
}