using System;

namespace MangoAPI.Domain.Entities
{
    public class SecretChatPublicKeyEntity
    {
        public Guid UserId { get; set; }
        public Guid SecretChatId { get; set; }
        public string PartnerPublicKey { get; set; }

        public UserEntity User { get; set; }
    }
}