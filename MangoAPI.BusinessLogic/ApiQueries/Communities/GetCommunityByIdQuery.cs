using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public record GetCommunityByIdQuery : IRequest<GenericResponse<GetCommunityByIdResponse, ErrorResponse>>
    {
        public Guid UserId { get; init; }
        public Guid ChatId { get; init; }
    }
}