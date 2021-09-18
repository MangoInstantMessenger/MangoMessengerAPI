using System;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public record SearchCommunityQuery : IRequest<SearchCommunityResponse>
    {
        public string DisplayName { get; init; }
        public Guid UserId { get; init; }
    }
}