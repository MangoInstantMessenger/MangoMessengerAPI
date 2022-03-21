using System;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.KeyExchange;

public record OpenSslDownloadPartnerPublicKeyResponse : ResponseBase
{
    public byte[] PublicKey { get; init; }
    public Guid PartnerId { get; init; }
}