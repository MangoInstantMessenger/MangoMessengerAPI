using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;

public record OpenSslDownloadPartnerPublicKeyQuery(Guid UserId, Guid RequestId) : IRequest<Result<OpenSslDownloadPartnerPublicKeyResponse>>;