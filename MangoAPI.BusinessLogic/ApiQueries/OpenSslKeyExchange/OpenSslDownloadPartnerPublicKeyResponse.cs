using System;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;

public record OpenSslDownloadPartnerPublicKeyResponse : ResponseBase
{
    public byte[] PublicKey { get; init; }
    public Guid PartnerId { get; init; }
}