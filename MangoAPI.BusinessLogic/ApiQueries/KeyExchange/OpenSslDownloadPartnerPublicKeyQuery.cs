using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.KeyExchange;

public record OpenSslDownloadPartnerPublicKeyQuery : IRequest<Result<OpenSslDownloadPartnerPublicKeyResponse>>
{
    public Guid UserId { get; init; }
    public Guid RequestId { get; init; }
}