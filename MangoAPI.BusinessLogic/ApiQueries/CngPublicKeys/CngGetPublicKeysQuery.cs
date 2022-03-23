using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.CngPublicKeys;

public record CngGetPublicKeysQuery : IRequest<Result<CngGetPublicKeysResponse>>
{
    public Guid UserId { get; init; }
}