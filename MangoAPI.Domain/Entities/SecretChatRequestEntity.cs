using System;

namespace MangoAPI.Domain.Entities
{
    public class SecretChatRequestEntity
    {
        public Guid SenderId { get; set; }
        public string SenderPublicKey { get; set; }
        public Guid UserId { get; set; }

        public UserEntity User { get; set; }
    }
}