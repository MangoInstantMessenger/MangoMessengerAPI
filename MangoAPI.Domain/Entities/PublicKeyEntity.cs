using System;

namespace MangoAPI.Domain.Entities
{
    public class PublicKeyEntity
    {
        public Guid UserId { get; set; }
        public Guid PartnerId { get; set; }
        public string PartnerPublicKey { get; set; }

        public UserEntity User { get; set; }
    }
}