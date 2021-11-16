using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.PublicKeys
{
    public record GetPublicKeysQuery : IRequest<Result<GetPublicKeysResponse>>
    {
        public Guid UserId { get; init; }
    }
}