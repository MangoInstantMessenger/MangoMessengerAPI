using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;

public record OpenSslDownloadPartnerPublicKeyQuery : IRequest<Result<OpenSslDownloadPartnerPublicKeyResponse>>
{
    public Guid UserId { get; init; }
    public Guid RequestId { get; init; }
}