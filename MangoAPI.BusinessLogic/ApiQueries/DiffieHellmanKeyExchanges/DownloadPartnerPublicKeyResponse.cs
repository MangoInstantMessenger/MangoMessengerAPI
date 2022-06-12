using System;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;

public record DownloadPartnerPublicKeyResponse : ResponseBase
{
    public byte[] PublicKey { get; init; }
    public Guid PartnerId { get; init; }
}