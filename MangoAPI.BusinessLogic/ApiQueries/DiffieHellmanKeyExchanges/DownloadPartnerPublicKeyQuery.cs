using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;

public record DownloadPartnerPublicKeyQuery(
        Guid UserId,
        Guid RequestId)
    : IRequest<Result<DownloadPartnerPublicKeyResponse>>;