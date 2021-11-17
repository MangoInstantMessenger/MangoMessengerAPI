using System;

namespace MangoAPI.BusinessLogic.Models
{
    public record PublicKey
    {
        public Guid PartnerId { get; init; }
        public string PartnerPublicKey { get; init; }
    }
}