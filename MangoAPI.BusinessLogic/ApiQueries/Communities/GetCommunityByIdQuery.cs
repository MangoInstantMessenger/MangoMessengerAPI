using System;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public record GetCommunityByIdQuery : IRequest<GetCommunityByIdResponse>
    {
        public Guid UserId { get; init; }
        public Guid ChatId { get; init; }
    }
}