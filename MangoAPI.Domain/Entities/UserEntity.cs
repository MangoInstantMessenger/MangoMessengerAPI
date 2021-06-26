using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Domain.Entities
{
    public class UserEntity : IdentityUser
    {
        public string DisplayName { get; set; }
        public string Image { get; set; }
        public string Bio { get; set; }
        public bool Verified { get; set; }
        public int ConfirmationCode { get; set; }

        public virtual ICollection<RefreshTokenEntity> RefreshTokens { get; set; }
        public virtual ICollection<MessageEntity> Messages { get; set; }
        public virtual ICollection<UserChatEntity> UserChats { get; set; }
    }
}