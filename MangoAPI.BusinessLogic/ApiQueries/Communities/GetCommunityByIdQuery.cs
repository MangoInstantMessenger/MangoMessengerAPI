using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public record GetCommunityByIdQuery : IRequest<Result<GetCommunityByIdResponse>>
    {
        public Guid UserId { get; init; }
        public Guid ChatId { get; init; }
    }
}